namespace Justin_Smith_Unit2_IT481
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
            ViewDatabase = new Button();
            RecordCount = new Button();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            ConnectionBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ViewDatabase
            // 
            ViewDatabase.Location = new Point(51, 83);
            ViewDatabase.Name = "ViewDatabase";
            ViewDatabase.Size = new Size(297, 127);
            ViewDatabase.TabIndex = 0;
            ViewDatabase.Text = "View Database";
            ViewDatabase.UseVisualStyleBackColor = true;
            ViewDatabase.Click += button1_Click;
            // 
            // RecordCount
            // 
            RecordCount.Location = new Point(354, 83);
            RecordCount.Name = "RecordCount";
            RecordCount.Size = new Size(297, 127);
            RecordCount.TabIndex = 1;
            RecordCount.Text = "Show record count";
            RecordCount.UseVisualStyleBackColor = true;
            RecordCount.Click += RecordCount_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.GradientInactiveCaption;
            richTextBox1.Location = new Point(56, 13);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(710, 64);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "Welcome to my Northwind Database";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(713, 189);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ConnectionBox
            // 
            ConnectionBox.Location = new Point(663, 93);
            ConnectionBox.Name = "ConnectionBox";
            ConnectionBox.Size = new Size(100, 117);
            ConnectionBox.TabIndex = 4;
            ConnectionBox.Text = "";
            ConnectionBox.TextChanged += ConnectionBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(ConnectionBox);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Controls.Add(RecordCount);
            Controls.Add(ViewDatabase);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ViewDatabase;
        private Button RecordCount;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private RichTextBox ConnectionBox;
    }
}
