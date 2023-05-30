namespace Довідник_нумізмата
{
    partial class Form1
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
            LoginLabel = new Label();
            PasswordLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            EnterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 24);
            label1.MaximumSize = new Size(163, 32);
            label1.MinimumSize = new Size(163, 32);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "Авторизація";
           
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.None;
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(40, 122);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(37, 15);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(20, 167);
            PasswordLabel.MaximumSize = new Size(57, 15);
            PasswordLabel.MinimumSize = new Size(57, 15);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.None;
            LoginTextBox.Location = new Point(83, 119);
            LoginTextBox.MaximumSize = new Size(202, 23);
            LoginTextBox.MinimumSize = new Size(202, 23);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(202, 23);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.None;
            PasswordTextBox.Location = new Point(83, 164);
            PasswordTextBox.MaximumSize = new Size(202, 23);
            PasswordTextBox.MinimumSize = new Size(202, 23);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(202, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EnterButton
            // 
            EnterButton.Anchor = AnchorStyles.None;
            EnterButton.BackColor = SystemColors.ScrollBar;
            EnterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EnterButton.Location = new Point(102, 226);
            EnterButton.MaximumSize = new Size(151, 49);
            EnterButton.MinimumSize = new Size(151, 49);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(151, 49);
            EnterButton.TabIndex = 5;
            EnterButton.Text = "Вхід";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(334, 405);
            Controls.Add(EnterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button EnterButton;
    }
}