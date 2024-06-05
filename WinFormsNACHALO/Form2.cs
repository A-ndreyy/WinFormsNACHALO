using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsNACHALO
{
    public partial class Form2 : Form
    {
        private const string JsonFileName = "events.json";
        private List<Form7.Event> allEvents;

        public Form2()
        {
            InitializeComponent();
            LoadEventDataFromJson();
        }

        // завантаження с  JSON
        private void LoadEventDataFromJson()
        {
            string jsonFilePath = Path.Combine(Application.StartupPath, JsonFileName);
            if (File.Exists(jsonFilePath))
            {
                allEvents = JsonConvert.DeserializeObject<List<Form7.Event>>(File.ReadAllText(jsonFilePath));

                allEvents = allEvents.OrderBy(ev => ev.Date).ThenBy(ev => ev.Time).ToList();

                dataGridViewEvents.DataSource = allEvents;
            }
        }

        //назад
        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = new Form0();
            mainForm.Show();
            this.Close();
        }


        //  пошук
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime searchDate = dateTimePicker.Value.Date;

            var filteredEvents = allEvents.Where(ev => ev.Date.Date == searchDate).ToList();

            dataGridViewEvents.DataSource = filteredEvents;
        }

        // еnter 
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



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form2_Leave(object sender, EventArgs e)
        {
            Close();
        }
    }
}