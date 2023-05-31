namespace Довідник_нумізмата
{
    partial class GeneralCollection
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
            CoinLabel = new Label();
            CollectorLabel = new Label();
            dataGridViewCoin = new DataGridView();
            dataGridViewCollector = new DataGridView();
            buttonComeBackToMenu = new Button();
            textBoxCoinFind = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxCollectorFind = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollector).BeginInit();
            SuspendLayout();
            // 
            // CoinLabel
            // 
            CoinLabel.Anchor = AnchorStyles.None;
            CoinLabel.AutoSize = true;
            CoinLabel.BackColor = SystemColors.GradientActiveCaption;
            CoinLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CoinLabel.Location = new Point(12, 57);
            CoinLabel.Name = "CoinLabel";
            CoinLabel.Size = new Size(157, 25);
            CoinLabel.TabIndex = 0;
            CoinLabel.Text = "Колекція монет:";
            // 
            // CollectorLabel
            // 
            CollectorLabel.Anchor = AnchorStyles.None;
            CollectorLabel.AutoSize = true;
            CollectorLabel.BackColor = SystemColors.GradientActiveCaption;
            CollectorLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CollectorLabel.Location = new Point(870, 57);
            CollectorLabel.Name = "CollectorLabel";
            CollectorLabel.Size = new Size(185, 25);
            CollectorLabel.TabIndex = 1;
            CollectorLabel.Text = "Наші колекціонери";
            // 
            // dataGridViewCoin
            // 
            dataGridViewCoin.Anchor = AnchorStyles.None;
            dataGridViewCoin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoin.Location = new Point(12, 85);
            dataGridViewCoin.Name = "dataGridViewCoin";
            dataGridViewCoin.RowTemplate.Height = 25;
            dataGridViewCoin.Size = new Size(518, 333);
            dataGridViewCoin.TabIndex = 2;
            // 
            // dataGridViewCollector
            // 
            dataGridViewCollector.Anchor = AnchorStyles.None;
            dataGridViewCollector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCollector.Location = new Point(536, 85);
            dataGridViewCollector.Name = "dataGridViewCollector";
            dataGridViewCollector.RowTemplate.Height = 25;
            dataGridViewCollector.Size = new Size(519, 333);
            dataGridViewCollector.TabIndex = 3;
            // 
            // buttonComeBackToMenu
            // 
            buttonComeBackToMenu.Anchor = AnchorStyles.None;
            buttonComeBackToMenu.Location = new Point(487, 12);
            buttonComeBackToMenu.Name = "buttonComeBackToMenu";
            buttonComeBackToMenu.Size = new Size(90, 39);
            buttonComeBackToMenu.TabIndex = 14;
            buttonComeBackToMenu.Text = "Меню";
            buttonComeBackToMenu.UseVisualStyleBackColor = true;
            buttonComeBackToMenu.Click += buttonComeBackToMenu_Click;
            // 
            // textBoxCoinFind
            // 
            textBoxCoinFind.Anchor = AnchorStyles.None;
            textBoxCoinFind.Location = new Point(170, 447);
            textBoxCoinFind.Name = "textBoxCoinFind";
            textBoxCoinFind.Size = new Size(310, 23);
            textBoxCoinFind.TabIndex = 15;
            textBoxCoinFind.TextChanged += textBoxCoinFind_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 440);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 16;
            label1.Text = "Пошук монети:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(525, 440);
            label2.Name = "label2";
            label2.Size = new Size(227, 30);
            label2.TabIndex = 17;
            label2.Text = "Пошук колекціонера:";
            // 
            // textBoxCollectorFind
            // 
            textBoxCollectorFind.Anchor = AnchorStyles.None;
            textBoxCollectorFind.Location = new Point(758, 447);
            textBoxCollectorFind.Name = "textBoxCollectorFind";
            textBoxCollectorFind.Size = new Size(308, 23);
            textBoxCollectorFind.TabIndex = 18;
            textBoxCollectorFind.TextChanged += textBoxCollectorFind_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(388, 508);
            button1.Name = "button1";
            button1.Size = new Size(142, 48);
            button1.TabIndex = 19;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(536, 508);
            button2.Name = "button2";
            button2.Size = new Size(142, 48);
            button2.TabIndex = 20;
            button2.Text = "Оновити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1067, 618);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxCollectorFind);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCoinFind);
            Controls.Add(buttonComeBackToMenu);
            Controls.Add(dataGridViewCollector);
            Controls.Add(dataGridViewCoin);
            Controls.Add(CollectorLabel);
            Controls.Add(CoinLabel);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CoinLabel;
        private Label CollectorLabel;
        private DataGridView dataGridViewCoin;
        private DataGridView dataGridViewCollector;
        private Button buttonComeBackToMenu;
        private TextBox textBoxCoinFind;
        private Label label1;
        private Label label2;
        private TextBox textBoxCollectorFind;
        private Button button1;
        private Button button2;
    }
}