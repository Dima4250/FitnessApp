namespace FitnessApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpActivityType = new System.Windows.Forms.GroupBox();
            this.lblActivityType = new System.Windows.Forms.Label();
            this.btnCycling = new System.Windows.Forms.Button();
            this.btnRunning = new System.Windows.Forms.Button();
            this.grpActivityData = new System.Windows.Forms.GroupBox();
            this.lblCaloriesUnit = new System.Windows.Forms.Label();
            this.lblSpeedUnit = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblMinutesUnit = new System.Windows.Forms.Label();
            this.lblDistanceUnit = new System.Windows.Forms.Label();
            this.btnSendNotifications = new System.Windows.Forms.Button();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveActivity = new System.Windows.Forms.Button();
            this.txtAvgSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpActivityDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGoals = new System.Windows.Forms.GroupBox();
            this.btnShowProgress = new System.Windows.Forms.Button();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.lstGoals = new System.Windows.Forms.ListBox();
            this.grpActivityType.SuspendLayout();
            this.grpActivityData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.grpGoals.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpActivityType
            // 
            this.grpActivityType.Controls.Add(this.lblActivityType);
            this.grpActivityType.Controls.Add(this.btnCycling);
            this.grpActivityType.Controls.Add(this.btnRunning);
            this.grpActivityType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpActivityType.Location = new System.Drawing.Point(12, 12);
            this.grpActivityType.Name = "grpActivityType";
            this.grpActivityType.Size = new System.Drawing.Size(360, 80);
            this.grpActivityType.TabIndex = 0;
            this.grpActivityType.TabStop = false;
            this.grpActivityType.Text = "Тип активности";
            // 
            // lblActivityType
            // 
            this.lblActivityType.AutoSize = true;
            this.lblActivityType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActivityType.Location = new System.Drawing.Point(240, 35);
            this.lblActivityType.Name = "lblActivityType";
            this.lblActivityType.Size = new System.Drawing.Size(86, 17);
            this.lblActivityType.TabIndex = 2;
            this.lblActivityType.Text = "Не выбрана";
            // 
            // btnCycling
            // 
            this.btnCycling.Location = new System.Drawing.Point(120, 30);
            this.btnCycling.Name = "btnCycling";
            this.btnCycling.Size = new System.Drawing.Size(100, 30);
            this.btnCycling.TabIndex = 1;
            this.btnCycling.Text = "Велосипед";
            this.btnCycling.UseVisualStyleBackColor = true;
            this.btnCycling.Click += new System.EventHandler(this.btnCycling_Click);
            // 
            // btnRunning
            // 
            this.btnRunning.Location = new System.Drawing.Point(15, 30);
            this.btnRunning.Name = "btnRunning";
            this.btnRunning.Size = new System.Drawing.Size(100, 30);
            this.btnRunning.TabIndex = 0;
            this.btnRunning.Text = "Бег";
            this.btnRunning.UseVisualStyleBackColor = true;
            this.btnRunning.Click += new System.EventHandler(this.btnRunning_Click);
            // 
            // grpActivityData
            // 
            this.grpActivityData.Controls.Add(this.lblCaloriesUnit);
            this.grpActivityData.Controls.Add(this.lblSpeedUnit);
            this.grpActivityData.Controls.Add(this.numMinutes);
            this.grpActivityData.Controls.Add(this.lblMinutesUnit);
            this.grpActivityData.Controls.Add(this.lblDistanceUnit);
            this.grpActivityData.Controls.Add(this.btnSendNotifications);
            this.grpActivityData.Controls.Add(this.txtCalories);
            this.grpActivityData.Controls.Add(this.label5);
            this.grpActivityData.Controls.Add(this.btnSaveActivity);
            this.grpActivityData.Controls.Add(this.txtAvgSpeed);
            this.grpActivityData.Controls.Add(this.label4);
            this.grpActivityData.Controls.Add(this.label3);
            this.grpActivityData.Controls.Add(this.txtDistance);
            this.grpActivityData.Controls.Add(this.label2);
            this.grpActivityData.Controls.Add(this.dtpActivityDate);
            this.grpActivityData.Controls.Add(this.label1);
            this.grpActivityData.Enabled = false;
            this.grpActivityData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpActivityData.Location = new System.Drawing.Point(12, 98);
            this.grpActivityData.Name = "grpActivityData";
            this.grpActivityData.Size = new System.Drawing.Size(360, 280);
            this.grpActivityData.TabIndex = 1;
            this.grpActivityData.TabStop = false;
            this.grpActivityData.Text = "Данные тренировки";
            // 
            // lblCaloriesUnit
            // 
            this.lblCaloriesUnit.AutoSize = true;
            this.lblCaloriesUnit.Location = new System.Drawing.Point(320, 203);
            this.lblCaloriesUnit.Name = "lblCaloriesUnit";
            this.lblCaloriesUnit.Size = new System.Drawing.Size(34, 17);
            this.lblCaloriesUnit.TabIndex = 15;
            this.lblCaloriesUnit.Text = "ккал";
            // 
            // lblSpeedUnit
            // 
            this.lblSpeedUnit.AutoSize = true;
            this.lblSpeedUnit.Location = new System.Drawing.Point(319, 165);
            this.lblSpeedUnit.Name = "lblSpeedUnit";
            this.lblSpeedUnit.Size = new System.Drawing.Size(35, 17);
            this.lblSpeedUnit.TabIndex = 14;
            this.lblSpeedUnit.Text = "км/ч";
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(120, 115);
            this.numMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(120, 25);
            this.numMinutes.TabIndex = 16;
            this.numMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMinutes.ValueChanged += new System.EventHandler(this.numMinutes_ValueChanged);
            // 
            // lblMinutesUnit
            // 
            this.lblMinutesUnit.AutoSize = true;
            this.lblMinutesUnit.Location = new System.Drawing.Point(250, 120);
            this.lblMinutesUnit.Name = "lblMinutesUnit";
            this.lblMinutesUnit.Size = new System.Drawing.Size(50, 17);
            this.lblMinutesUnit.TabIndex = 13;
            this.lblMinutesUnit.Text = "минут";
            // 
            // lblDistanceUnit
            // 
            this.lblDistanceUnit.AutoSize = true;
            this.lblDistanceUnit.Location = new System.Drawing.Point(331, 83);
            this.lblDistanceUnit.Name = "lblDistanceUnit";
            this.lblDistanceUnit.Size = new System.Drawing.Size(23, 17);
            this.lblDistanceUnit.TabIndex = 12;
            this.lblDistanceUnit.Text = "км";
            // 
            // btnSendNotifications
            // 
            this.btnSendNotifications.Location = new System.Drawing.Point(180, 230);
            this.btnSendNotifications.Name = "btnSendNotifications";
            this.btnSendNotifications.Size = new System.Drawing.Size(170, 35);
            this.btnSendNotifications.TabIndex = 11;
            this.btnSendNotifications.Text = "Отправить уведомления";
            this.btnSendNotifications.UseVisualStyleBackColor = true;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(120, 195);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.ReadOnly = true;
            this.txtCalories.Size = new System.Drawing.Size(191, 25);
            this.txtCalories.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Калории:";
            // 
            // btnSaveActivity
            // 
            this.btnSaveActivity.Location = new System.Drawing.Point(15, 230);
            this.btnSaveActivity.Name = "btnSaveActivity";
            this.btnSaveActivity.Size = new System.Drawing.Size(150, 35);
            this.btnSaveActivity.TabIndex = 8;
            this.btnSaveActivity.Text = "Сохранить тренировку";
            this.btnSaveActivity.UseVisualStyleBackColor = true;
            this.btnSaveActivity.Click += new System.EventHandler(this.btnSaveActivity_Click);
            // 
            // txtAvgSpeed
            // 
            this.txtAvgSpeed.Location = new System.Drawing.Point(141, 157);
            this.txtAvgSpeed.Name = "txtAvgSpeed";
            this.txtAvgSpeed.Size = new System.Drawing.Size(170, 25);
            this.txtAvgSpeed.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Средняя скорость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(120, 75);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(191, 25);
            this.txtDistance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дистанция:";
            // 
            // dtpActivityDate
            // 
            this.dtpActivityDate.Location = new System.Drawing.Point(120, 35);
            this.dtpActivityDate.Name = "dtpActivityDate";
            this.dtpActivityDate.Size = new System.Drawing.Size(170, 25);
            this.dtpActivityDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // grpGoals
            // 
            this.grpGoals.Controls.Add(this.btnShowProgress);
            this.grpGoals.Controls.Add(this.btnAddGoal);
            this.grpGoals.Controls.Add(this.lstGoals);
            this.grpGoals.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpGoals.Location = new System.Drawing.Point(390, 12);
            this.grpGoals.Name = "grpGoals";
            this.grpGoals.Size = new System.Drawing.Size(300, 366);
            this.grpGoals.TabIndex = 2;
            this.grpGoals.TabStop = false;
            this.grpGoals.Text = "Мои цели";
            // 
            // btnShowProgress
            // 
            this.btnShowProgress.Location = new System.Drawing.Point(150, 320);
            this.btnShowProgress.Name = "btnShowProgress";
            this.btnShowProgress.Size = new System.Drawing.Size(140, 35);
            this.btnShowProgress.TabIndex = 2;
            this.btnShowProgress.Text = "Показать прогресс";
            this.btnShowProgress.UseVisualStyleBackColor = true;
            this.btnShowProgress.Click += new System.EventHandler(this.btnShowProgress_Click);
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.Location = new System.Drawing.Point(10, 320);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(130, 35);
            this.btnAddGoal.TabIndex = 1;
            this.btnAddGoal.Text = "Добавить цель";
            this.btnAddGoal.UseVisualStyleBackColor = true;
            this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
            // 
            // lstGoals
            // 
            this.lstGoals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstGoals.FormattingEnabled = true;
            this.lstGoals.ItemHeight = 15;
            this.lstGoals.Location = new System.Drawing.Point(10, 25);
            this.lstGoals.Name = "lstGoals";
            this.lstGoals.Size = new System.Drawing.Size(280, 289);
            this.lstGoals.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 391);
            this.Controls.Add(this.grpGoals);
            this.Controls.Add(this.grpActivityData);
            this.Controls.Add(this.grpActivityType);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фитнес Трекер";
            this.grpActivityType.ResumeLayout(false);
            this.grpActivityType.PerformLayout();
            this.grpActivityData.ResumeLayout(false);
            this.grpActivityData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.grpGoals.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpActivityType;
        private System.Windows.Forms.Label lblActivityType;
        private System.Windows.Forms.Button btnCycling;
        private System.Windows.Forms.Button btnRunning;
        private System.Windows.Forms.GroupBox grpActivityData;
        private System.Windows.Forms.Label lblCaloriesUnit;
        private System.Windows.Forms.Label lblSpeedUnit;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label lblMinutesUnit;
        private System.Windows.Forms.Label lblDistanceUnit;
        private System.Windows.Forms.Button btnSendNotifications;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveActivity;
        private System.Windows.Forms.TextBox txtAvgSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpActivityDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGoals;
        private System.Windows.Forms.Button btnShowProgress;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.ListBox lstGoals;
    }
}

