using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class GoalForm : Form
    {
        public UserGoal Goal { get; private set; }


        public GoalForm()
        {
            InitializeComponent();
            SetupNameField();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddMonths(1);
        }

        private void SetupNameField()
        {
            // Поле для названия цели
            lblName.Location = new Point(15, 20);
            this.Controls.Add(lblName);

            txtName.Size = new Size(200, 25);
            this.Controls.Add(txtName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Goal = new UserGoal
            {
                Name = txtName.Text.Trim(),
                ActivityType = cmbActivityType.SelectedItem.ToString(),
                TargetValue = double.Parse(txtTargetValue.Text),
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
