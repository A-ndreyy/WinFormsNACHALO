namespace WinFormsNACHALO
{
    partial class Form0
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(216, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 355);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(365, 108);
            button2.Name = "button2";
            button2.Size = new Size(271, 111);
            button2.TabIndex = 1;
            button2.Text = "Додати запис";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(56, 108);
            button1.Name = "button1";
            button1.Size = new Size(271, 111);
            button1.TabIndex = 0;
            button1.Text = "Календар записів";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(438, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 60);
            label1.TabIndex = 2;
            label1.Text = "Щоденик";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(239, 531);
            label2.Name = "label2";
            label2.Size = new Size(666, 28);
            label2.TabIndex = 3;
            label2.Text = "Перегляд записаних справ доступий у розділі \"Календар записів\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(305, 559);
            label3.Name = "label3";
            label3.Size = new Size(547, 28);
            label3.TabIndex = 4;
            label3.Text = "Записати справи можливо у розділі \"Додати справи\"";
            label3.Click += label3_Click;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1110, 612);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximumSize = new Size(1132, 668);
            MinimumSize = new Size(722, 540);
            Name = "Form0";
            Text = "Щоденик";
            Load += Form0_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}