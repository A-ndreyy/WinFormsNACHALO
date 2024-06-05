namespace WinFormsNACHALO
{
    partial class Form7
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
        private void InitializeComponent()
        {
            dateTimePickerEventDate = new DateTimePicker();
            textBoxEventTime = new TextBox();
            textBoxEventDuration = new TextBox();
            textBoxEventLocation = new TextBox();
            buttonAddEvent = new Button();
            labelДата = new Label();
            labelEventTime = new Label();
            labelEventDuration = new Label();
            labelEventLocation = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePickerEventDate
            // 
            dateTimePickerEventDate.Location = new Point(156, 19);
            dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            dateTimePickerEventDate.Size = new Size(498, 31);
            dateTimePickerEventDate.TabIndex = 0;
            // 
            // textBoxEventTime
            // 
            textBoxEventTime.Location = new Point(156, 82);
            textBoxEventTime.Name = "textBoxEventTime";
            textBoxEventTime.Size = new Size(498, 31);
            textBoxEventTime.TabIndex = 1;
            // 
            // textBoxEventDuration
            // 
            textBoxEventDuration.Location = new Point(156, 165);
            textBoxEventDuration.Name = "textBoxEventDuration";
            textBoxEventDuration.Size = new Size(498, 31);
            textBoxEventDuration.TabIndex = 2;
            // 
            // textBoxEventLocation
            // 
            textBoxEventLocation.Location = new Point(159, 258);
            textBoxEventLocation.Name = "textBoxEventLocation";
            textBoxEventLocation.Size = new Size(495, 31);
            textBoxEventLocation.TabIndex = 3;
            // 
            // buttonAddEvent
            // 
            buttonAddEvent.BackColor = Color.IndianRed;
            buttonAddEvent.Location = new Point(407, 363);
            buttonAddEvent.Name = "buttonAddEvent";
            buttonAddEvent.Size = new Size(247, 92);
            buttonAddEvent.TabIndex = 4;
            buttonAddEvent.Text = "Записати";
            buttonAddEvent.UseVisualStyleBackColor = false;
            buttonAddEvent.Click += buttonAddEvent_Click;
            // 
            // labelДата
            // 
            labelДата.AutoSize = true;
            labelДата.Location = new Point(12, 19);
            labelДата.Name = "labelДата";
            labelДата.Size = new Size(93, 25);
            labelДата.TabIndex = 5;
            labelДата.Text = "Дата події";
            // 
            // labelEventTime
            // 
            labelEventTime.Location = new Point(12, 82);
            labelEventTime.Name = "labelEventTime";
            labelEventTime.Size = new Size(106, 28);
            labelEventTime.TabIndex = 6;
            labelEventTime.Text = "Час події";
            // 
            // labelEventDuration
            // 
            labelEventDuration.AutoSize = true;
            labelEventDuration.Location = new Point(12, 171);
            labelEventDuration.Name = "labelEventDuration";
            labelEventDuration.Size = new Size(142, 25);
            labelEventDuration.TabIndex = 7;
            labelEventDuration.Text = "Тривалість події";
            // 
            // labelEventLocation
            // 
            labelEventLocation.Location = new Point(12, 261);
            labelEventLocation.Name = "labelEventLocation";
            labelEventLocation.Size = new Size(129, 28);
            labelEventLocation.TabIndex = 8;
            labelEventLocation.Text = "Місце події";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(21, 363);
            button1.Name = "button1";
            button1.Size = new Size(247, 92);
            button1.TabIndex = 9;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form7
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(692, 467);
            Controls.Add(button1);
            Controls.Add(labelEventLocation);
            Controls.Add(labelEventDuration);
            Controls.Add(labelEventTime);
            Controls.Add(labelДата);
            Controls.Add(buttonAddEvent);
            Controls.Add(textBoxEventLocation);
            Controls.Add(textBoxEventDuration);
            Controls.Add(textBoxEventTime);
            Controls.Add(dateTimePickerEventDate);
            MaximumSize = new Size(714, 523);
            MinimumSize = new Size(714, 523);
            Name = "Form7";
            Text = "Додати запис";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePickerEventDate;
        private System.Windows.Forms.TextBox textBoxEventTime;
        private System.Windows.Forms.TextBox textBoxEventDuration;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Label labelДата;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventDuration;
        private System.Windows.Forms.Label labelEventLocation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
    }
}
