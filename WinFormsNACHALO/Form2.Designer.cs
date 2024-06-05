namespace WinFormsNACHALO
{
    partial class Form2
    {
        // Добавляемые компоненты
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button1;

        private void InitializeComponent()
        {
            dataGridViewEvents = new DataGridView();
            dateTimePicker = new DateTimePicker();
            buttonSearch = new Button();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(20, 79);
            dataGridViewEvents.Margin = new Padding(5, 6, 5, 6);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 62;
            dataGridViewEvents.Size = new Size(664, 657);
            dataGridViewEvents.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = SystemColors.ActiveCaptionText;
            dateTimePicker.CalendarMonthBackground = Color.IndianRed;
            dateTimePicker.Location = new Point(20, 24);
            dateTimePicker.Margin = new Padding(5, 6, 5, 6);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(358, 31);
            dateTimePicker.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.IndianRed;
            buttonSearch.Location = new Point(388, 15);
            buttonSearch.Margin = new Padding(5, 6, 5, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(139, 46);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(537, 15);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(147, 47);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, -7);
            label2.Name = "label2";
            label2.Size = new Size(250, 25);
            label2.TabIndex = 4;
            label2.Text = " Пошук доступний по даті";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(703, 747);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePicker);
            Controls.Add(dataGridViewEvents);
            Margin = new Padding(5, 6, 5, 6);
            MaximumSize = new Size(725, 803);
            MinimumSize = new Size(725, 803);
            Name = "Form2";
            Text = "Календр записів";
            Load += Form2_Load;
            DragEnter += Form2_DragEnter;
            Leave += Form2_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
    }
}