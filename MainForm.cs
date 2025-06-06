using FitnessApp.Activities;
using FitnessApp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class MainForm : Form
    {
        private readonly List<UserGoal> _goals = new List<UserGoal>();
        private readonly List<ActivityRecord> _activities = new List<ActivityRecord>();
        private readonly NotificationWrapper _notificationWrapper;
        private Activity _currentActivity;

        public MainForm()
        {
            InitializeComponent();
            LoadSampleData();
            _notificationWrapper = new NotificationWrapper();
            _notificationWrapper.AddService(new ConsoleNotificationService());
            _currentActivity?.Attach(new ActivityObserver(this));
        }

        public class ConsoleNotificationService : INotificationService
        {
            public async Task SendNotificationAsync(string message)
            {
                MessageBox.Show(message, "Уведомление системы",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                await Task.CompletedTask;
            }
        }

        public void ShowActivityNotification(string message)
        {
            // Показываем в MessageBox
            MessageBox.Show(message, "Новая активность",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Или в консоль для отладки
            Console.WriteLine($"Activity notification: {message}");
        }

        private void UpdateCaloriesCalculation()
        {
            if (_currentActivity != null && numMinutes.Value > 0)
            {
                int duration = (int)numMinutes.Value;
                txtCalories.Text = _currentActivity.CalculateCalories(duration).ToString();
            }
        }

        private void numMinutes_ValueChanged(object sender, EventArgs e)
        {
            UpdateCaloriesCalculation();
        }

        private void LoadSampleData()
        {
            // Загрузка тестовых данных
            _goals.Add(new UserGoal
            {
                ActivityType = "Бег",
                TargetValue = 50,
                StartDate = DateTime.Now.AddDays(-7),
                EndDate = DateTime.Now.AddDays(30)
            });

            UpdateGoalsList();
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            var goalForm = new GoalForm();
            if (goalForm.ShowDialog() == DialogResult.OK)
            {
                _goals.Add(goalForm.Goal);
                UpdateGoalsList();
            }
        }

        private void UpdateGoalsList()
        {
            lstGoals.DataSource = null;
            lstGoals.DataSource = _goals;
            lstGoals.DisplayMember = "Description";
        }

        private void btnRunning_Click(object sender, EventArgs e)
        {
            _currentActivity = new RunningActivity();
            UpdateActivityInfo();
        }

        private void btnCycling_Click(object sender, EventArgs e)
        {
            _currentActivity = new CyclingActivity();
            UpdateActivityInfo();
        }

        private void UpdateActivityInfo()
        {
            lblActivityType.Text = _currentActivity?.ActivityType ?? "Не выбрана";
            grpActivityData.Enabled = _currentActivity != null;
        }

        private void btnSaveActivity_Click(object sender, EventArgs e)
        {
            if (_currentActivity == null)
            {
                MessageBox.Show("Сначала выберите тип активности", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Парсим введённые данные
                int duration = (int)numMinutes.Value;

                // Создаём и заполняем запись активности
                var record = new ActivityRecord
                {
                    ActivityType = _currentActivity.ActivityType,
                    Date = dtpActivityDate.Value,
                    Distance = double.Parse(txtDistance.Text),
                    Duration = TimeSpan.FromMinutes(duration),
                    AvgSpeed = double.Parse(txtAvgSpeed.Text),
                    Calories = _currentActivity.CalculateCalories(duration) 
                };

                // Сохраняем активность
                _activities.Add(record);

                // Обновляем интерфейс
                txtCalories.Text = record.Calories.ToString();

                // Проверяем прогресс целей
                CheckGoalsProgress(record);

                // Уведомляем наблюдателей
                string notificationMessage = $"Сохранена {record.ActivityType} активность:\n" +
                                           $"Дистанция: {record.Distance} км\n" +
                                           $"Время: {record.Duration:hh\\:mm}\n" +
                                           $"Калории: {record.Calories}";
                _notificationWrapper.NotifyAsync(notificationMessage);

                MessageBox.Show("Активность сохранена!", "Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введённых данных", "Ошибка формата",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неожиданная ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CheckGoalsProgress(ActivityRecord record)
        {
            foreach (var goal in _goals.Where(g =>
                g.ActivityType == record.ActivityType &&
                !g.IsCompleted))
            {
                double totalDistance = _activities
                    .Where(a => a.ActivityType == goal.ActivityType)
                    .Where(a => a.Date >= goal.StartDate)
                    .Where(a => a.Date <= goal.EndDate)
                    .Sum(a => a.Distance);

                double progress = (totalDistance / goal.TargetValue) * 100;

                if (progress >= 100)
                {
                    goal.IsCompleted = true;
                    string message = $"🎉 Поздравляем! Вы достигли цели {goal.ActivityType} {goal.TargetValue} км!";
                    await _notificationWrapper.NotifyAsync(message);
                    MessageBox.Show(message, "Цель достигнута",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnShowProgress_Click(object sender, EventArgs e)
        {
            if (lstGoals.SelectedItem is UserGoal selectedGoal)
            {
                var totalDistance = _activities
                    .Where(a => a.ActivityType == selectedGoal.ActivityType &&
                               a.Date >= selectedGoal.StartDate &&
                               a.Date <= selectedGoal.EndDate)
                    .Sum(a => a.Distance);

                var progress = totalDistance / selectedGoal.TargetValue * 100;

                MessageBox.Show($"Прогресс цели: {progress:F1}%\n" +
                              $"Пройдено: {totalDistance:F1} км из {selectedGoal.TargetValue} км\n" +
                              $"Осталось: {selectedGoal.TargetValue - totalDistance:F1} км",
                              "Прогресс");
            }
        }
    }
}
