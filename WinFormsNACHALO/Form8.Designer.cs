namespace WinFormsNACHALO
{
    partial class Form8
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
            buttonSave = new Button();
            labelEventDate = new Label();
            labelEventTime = new Label();
            labelEventDuration = new Label();
            labelEventLocation = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePickerEventDate
            // 
            dateTimePickerEventDate.Location = new Point(181, 23);
            dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            dateTimePickerEventDate.Size = new Size(482, 31);
            dateTimePickerEventDate.TabIndex = 0;
            // 
            // textBoxEventTime
            // 
            textBoxEventTime.Location = new Point(181, 90);
            textBoxEventTime.Name = "textBoxEventTime";
            textBoxEventTime.Size = new Size(482, 31);
            textBoxEventTime.TabIndex = 1;
            // 
            // textBoxEventDuration
            // 
            textBoxEventDuration.Location = new Point(181, 145);
            textBoxEventDuration.Name = "textBoxEventDuration";
            textBoxEventDuration.Size = new Size(482, 31);
            textBoxEventDuration.TabIndex = 2;
            // 
            // textBoxEventLocation
            // 
            textBoxEventLocation.BackColor = SystemColors.HighlightText;
            textBoxEventLocation.Location = new Point(181, 202);
            textBoxEventLocation.Name = "textBoxEventLocation";
            textBoxEventLocation.Size = new Size(482, 31);
            textBoxEventLocation.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.IndianRed;
            buttonSave.Location = new Point(385, 282);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(278, 101);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Зберегти зміни";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelEventDate
            // 
            labelEventDate.AutoSize = true;
            labelEventDate.Location = new Point(12, 29);
            labelEventDate.Name = "labelEventDate";
            labelEventDate.Size = new Size(93, 25);
            labelEventDate.TabIndex = 5;
            labelEventDate.Text = "Дата події";
            labelEventDate.Click += labelEventDate_Click;
            // 
            // labelEventTime
            // 
            labelEventTime.AutoSize = true;
            labelEventTime.Location = new Point(11, 96);
            labelEventTime.Name = "labelEventTime";
            labelEventTime.Size = new Size(85, 25);
            labelEventTime.TabIndex = 6;
            labelEventTime.Text = "Час події";
            // 
            // labelEventDuration
            // 
            labelEventDuration.AutoSize = true;
            labelEventDuration.Location = new Point(12, 145);
            labelEventDuration.Name = "labelEventDuration";
            labelEventDuration.Size = new Size(142, 25);
            labelEventDuration.TabIndex = 7;
            labelEventDuration.Text = "Тривалість події";
            // 
            // labelEventLocation
            // 
            labelEventLocation.AutoSize = true;
            labelEventLocation.Location = new Point(11, 202);
            labelEventLocation.Name = "labelEventLocation";
            labelEventLocation.Size = new Size(104, 25);
            labelEventLocation.TabIndex = 8;
            labelEventLocation.Text = "Місце події";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(12, 282);
            button1.Name = "button1";
            button1.Size = new Size(278, 101);
            button1.TabIndex = 9;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(707, 395);
            Controls.Add(button1);
            Controls.Add(labelEventLocation);
            Controls.Add(labelEventDuration);
            Controls.Add(labelEventTime);
            Controls.Add(labelEventDate);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEventLocation);
            Controls.Add(textBoxEventDuration);
            Controls.Add(textBoxEventTime);
            Controls.Add(dateTimePickerEventDate);
            MaximumSize = new Size(729, 451);
            MinimumSize = new Size(729, 451);
            Name = "Form8";
            Text = "Редагування";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePickerEventDate;
        private System.Windows.Forms.TextBox textBoxEventTime;
        private System.Windows.Forms.TextBox textBoxEventDuration;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventDuration;
        private System.Windows.Forms.Label labelEventLocation;
        private Button button1;
    }
}