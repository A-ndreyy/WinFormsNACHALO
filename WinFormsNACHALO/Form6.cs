using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsNACHALO
{
    public partial class Form6 : Form
    {
        private List<Event> events;

        public Form6()
        {
            InitializeComponent();
            LoadEvents();
            SetupDataGridView();
            HighlightEventDates();
        }

        //завантаження c json
        private void LoadEvents()
        {
            string filePath = "events.json";
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                events = JsonConvert.DeserializeObject<List<Event>>(jsonData) ?? new List<Event>();
            }
            else
            {
                events = new List<Event>();
            }
        }

        //збереження у json
        private void SaveEvents()
        {
            string filePath = "events.json";
            string jsonData = JsonConvert.SerializeObject(events, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        //відображення даних про події
        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = new List<Event>(); //спочатку порожній
        }

        //календар
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            var eventsForSelectedDate = events.Where(ev => ev.Date.Date == selectedDate.Date).ToList();
            dataGridView1.DataSource = eventsForSelectedDate;
        }

        //виділяє дати
        private void HighlightEventDates()
        {
            var datesWithEvents = events.Select(ev => ev.Date.Date).Distinct().ToArray();
            monthCalendar1.BoldedDates = datesWithEvents;
        }

        //запис
        private void AddEvent(DateTime date, string time, string duration, string location)
        {
            // Перевірка на існування події з тією ж датою та часом
            var existingEvent = events.FirstOrDefault(ev => ev.Date == date && ev.Time == time);
            if (existingEvent != null)
            {
                MessageBox.Show("Подія з цією датою та часом вже існує.", "Дублювання події", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Створення нового об'єкта Event
            var newEvent = new Event
            {
                Date = date,
                Time = time,
                Duration = duration,
                Location = location
            };
            // Додавання нового об'єкта до списку events
            events.Add(newEvent);

            // Збереження даних події
            SaveEvents();

            // Оновлення виділених дат у календарі
            HighlightEventDates();

            // Оновлення таблиці даних
            monthCalendar1_DateChanged(null, null);
        }

        //запис
        private void button2_Click(object sender, EventArgs e)
        {

            var addEventForm = new Form7();
            if (addEventForm.ShowDialog(this) == DialogResult.OK)
            {
                AddEvent(addEventForm.EventDate, addEventForm.EventTime, addEventForm.EventDuration, addEventForm.EventLocation);
            }
        }

        //редагування
        private void EditEvent(Event eventToEdit)
        {
            var editEventForm = new Form8(eventToEdit);
            if (editEventForm.ShowDialog(this) == DialogResult.OK)
            {
                SaveEvents();
                HighlightEventDates();
                monthCalendar1_DateChanged(null, null);
            }
        }

        //редагування
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedEvent = dataGridView1.CurrentRow.DataBoundItem as Event;
                if (selectedEvent != null)
                {
                    EditEvent(selectedEvent);
                }
            }
            else
            {
                MessageBox.Show("Виберіть подію для редагування.", "Подія не вибрана", MessageBoxButtons.OK,MessageBoxIcon.Warning); 
            } 
        }

        //видалення
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedEvent = dataGridView1.CurrentRow.DataBoundItem as Event;
                if (selectedEvent != null)
                {
                    events.Remove(selectedEvent);
                    SaveEvents();
                    HighlightEventDates();
                    monthCalendar1_DateChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Виберіть подію для видалення.", "Подія не вибрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //назад
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            var mainForm = new Form0();
            mainForm.Show();
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
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEvents();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    } 
}