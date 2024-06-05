using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsNACHALO
{
    public partial class Form8 : Form
    {
        private Event eventToEdit;

        public Form8(Event eventToEdit)
        {
            InitializeComponent();
            this.eventToEdit = eventToEdit;
            LoadEventData();
        }

        //перевірка вводу 
        private void LoadEventData()
        {
            dateTimePickerEventDate.Value = eventToEdit.Date;
            textBoxEventTime.Text = eventToEdit.Time;
            textBoxEventDuration.Text = eventToEdit.Duration;
            textBoxEventLocation.Text = eventToEdit.Location;
        }

        //перевірка при редагуванні
        private bool ValidateInputs()
        {
            DateTime tempDate;
            if (!DateTime.TryParse(textBoxEventTime.Text, out tempDate))
            {
                MessageBox.Show("Введіть час.", "Невірне введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEventDuration.Text))
            {
                MessageBox.Show("Введіть тривалість.", "Невірне введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEventLocation.Text))
            {
                MessageBox.Show("Введіть місцезнаходження.", "Невірне введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //збереження
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                eventToEdit.Date = dateTimePickerEventDate.Value.Date;
                eventToEdit.Time = textBoxEventTime.Text;
                eventToEdit.Duration = textBoxEventDuration.Text;
                eventToEdit.Location = textBoxEventLocation.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        //назад
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //enter
        private void Form0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var activeControl = this.ActiveControl;
                if (activeControl is Button button)
                {
                    button.PerformClick();
                }
            }
        }

        private void labelEventDate_Click(object sender, EventArgs e)
        {

        }

    }
}