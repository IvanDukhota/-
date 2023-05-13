namespace Довідник_нумізмата
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            textBoxCoinName = new TextBox();
            buttonShowCoinInfo = new Button();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            textBoxCollectorName = new TextBox();
            buttonShowCollectorInfo = new Button();
            richTextBox2 = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 26);
            label1.TabIndex = 0;
            label1.Text = " Довідник Нумізмата:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 42);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 2;
            label2.Text = "Монети:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1061, 77);
            label3.Name = "label3";
            label3.Size = new Size(171, 26);
            label3.TabIndex = 3;
            label3.Text = "Колекціонери:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 115);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(320, 244);
            dataGridView.TabIndex = 4;
            // 
            // textBoxCoinName
            // 
            textBoxCoinName.BackColor = SystemColors.InactiveCaption;
            textBoxCoinName.Location = new Point(338, 115);
            textBoxCoinName.Multiline = true;
            textBoxCoinName.Name = "textBoxCoinName";
            textBoxCoinName.Size = new Size(281, 61);
            textBoxCoinName.TabIndex = 5;
            // 
            // buttonShowCoinInfo
            // 
            buttonShowCoinInfo.BackColor = SystemColors.HotTrack;
            buttonShowCoinInfo.Location = new Point(532, 137);
            buttonShowCoinInfo.Name = "buttonShowCoinInfo";
            buttonShowCoinInfo.Size = new Size(87, 39);
            buttonShowCoinInfo.TabIndex = 6;
            buttonShowCoinInfo.Text = "Пошук";
            buttonShowCoinInfo.UseVisualStyleBackColor = false;
            buttonShowCoinInfo.Click += buttonShowCoinInfo_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaption;
            richTextBox1.Location = new Point(338, 182);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(281, 177);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(912, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(320, 244);
            dataGridView1.TabIndex = 8;
            // 
            // textBoxCollectorName
            // 
            textBoxCollectorName.BackColor = SystemColors.InactiveCaption;
            textBoxCollectorName.Location = new Point(625, 115);
            textBoxCollectorName.Multiline = true;
            textBoxCollectorName.Name = "textBoxCollectorName";
            textBoxCollectorName.Size = new Size(281, 61);
            textBoxCollectorName.TabIndex = 9;
            // 
            // buttonShowCollectorInfo
            // 
            buttonShowCollectorInfo.BackColor = SystemColors.HotTrack;
            buttonShowCollectorInfo.Location = new Point(625, 137);
            buttonShowCollectorInfo.Name = "buttonShowCollectorInfo";
            buttonShowCollectorInfo.Size = new Size(87, 39);
            buttonShowCollectorInfo.TabIndex = 10;
            buttonShowCollectorInfo.Text = "Пошук";
            buttonShowCollectorInfo.UseVisualStyleBackColor = false;
            buttonShowCollectorInfo.Click += buttonShowCollectorInfo_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.InactiveCaption;
            richTextBox2.Location = new Point(625, 182);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(281, 177);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1244, 715);
            Controls.Add(richTextBox2);
            Controls.Add(buttonShowCollectorInfo);
            Controls.Add(textBoxCollectorName);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonShowCoinInfo);
            Controls.Add(textBoxCoinName);
            Controls.Add(dataGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView;
        private TextBox textBoxCoinName;
        private Button buttonShowCoinInfo;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private TextBox textBoxCollectorName;
        private Button buttonShowCollectorInfo;
        private RichTextBox richTextBox2;
    }
}
