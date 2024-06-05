using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsNACHALO
{
    public partial class Form7 : Form
    {
        
        public DateTime EventDate { get; private set; }
        public string EventTime { get; private set; }
        public string EventDuration { get; private set; }
        public string EventLocation { get; private set; }

        public Form7()
        {
            InitializeComponent();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {


            if (ValidateInputs())
            {
                // перевірка даних з текстових полів
                EventDate = dateTimePickerEventDate.Value.Date;
                EventTime = textBoxEventTime.Text;
                EventDuration = textBoxEventDuration.Text;
                EventLocation = textBoxEventLocation.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

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

        public class Event
        {
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public string Duration { get; set; }
            public string Location { get; set; }
        }

        //назад
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
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
    }
}