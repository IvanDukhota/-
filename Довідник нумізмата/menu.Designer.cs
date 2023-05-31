namespace Довідник_нумізмата
{
    partial class menu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Open1Button = new Button();
            Open2Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 0;
            label1.Text = "Меню";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 127);
            label2.Name = "label2";
            label2.Size = new Size(221, 87);
            label2.TabIndex = 1;
            label2.Text = "Інформація про колекцію монет та відомих колекціонерів!\r\n\r\n!\r\n";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(476, 127);
            label3.Name = "label3";
            label3.Size = new Size(144, 87);
            label3.TabIndex = 2;
            label3.Text = "Переглянути власну колекцію!";
            // 
            // Open1Button
            // 
            Open1Button.Anchor = AnchorStyles.None;
            Open1Button.BackColor = SystemColors.ButtonFace;
            Open1Button.Location = new Point(164, 231);
            Open1Button.Name = "Open1Button";
            Open1Button.Size = new Size(113, 46);
            Open1Button.TabIndex = 3;
            Open1Button.Text = "Відкрити";
            Open1Button.UseVisualStyleBackColor = false;
            Open1Button.Click += Open1Button_Click;
            // 
            // Open2Button
            // 
            Open2Button.Anchor = AnchorStyles.None;
            Open2Button.BackColor = SystemColors.ButtonFace;
            Open2Button.Location = new Point(488, 231);
            Open2Button.Name = "Open2Button";
            Open2Button.Size = new Size(113, 46);
            Open2Button.TabIndex = 4;
            Open2Button.Text = "Відкрити";
            Open2Button.UseVisualStyleBackColor = false;
            Open2Button.Click += Open2Button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(Open2Button);
            Controls.Add(Open1Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Open1Button;
        private Button Open2Button;
    }
}