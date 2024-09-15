namespace HomeAccountingWinForm
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            datePicker = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            Operation = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label10 = new Label();
            cmbCategory = new ComboBox();
            panel1 = new Panel();
            expenditureRadioBtn = new RadioButton();
            incomeRadioBtn = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.Location = new Point(790, 103);
            datePicker.Margin = new Padding(4, 5, 4, 5);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(195, 31);
            datePicker.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Category, Sum, Operation, Comment });
            dataGridView1.Location = new Point(40, 204);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(709, 396);
            dataGridView1.TabIndex = 16;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 200;
            // 
            // Sum
            // 
            Sum.DataPropertyName = "Sum";
            Sum.HeaderText = "Сумма";
            Sum.MinimumWidth = 8;
            Sum.Name = "Sum";
            Sum.ReadOnly = true;
            Sum.Width = 150;
            // 
            // Operation
            // 
            Operation.DataPropertyName = "Operation";
            Operation.HeaderText = "Операция";
            Operation.MinimumWidth = 8;
            Operation.Name = "Operation";
            Operation.ReadOnly = true;
            Operation.Width = 150;
            // 
            // Comment
            // 
            Comment.HeaderText = "Комментарий";
            Comment.MinimumWidth = 8;
            Comment.Name = "Comment";
            Comment.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(802, 163);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(183, 70);
            button1.TabIndex = 17;
            button1.Text = "Сформировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 10F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(704, 110);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(57, 24);
            label10.TabIndex = 22;
            label10.Text = "Дата";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(359, 41);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 33);
            cmbCategory.TabIndex = 23;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(expenditureRadioBtn);
            panel1.Controls.Add(incomeRadioBtn);
            panel1.Location = new Point(95, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 67);
            panel1.TabIndex = 27;
            // 
            // expenditureRadioBtn
            // 
            expenditureRadioBtn.AutoSize = true;
            expenditureRadioBtn.ForeColor = SystemColors.Control;
            expenditureRadioBtn.Location = new Point(134, 17);
            expenditureRadioBtn.Name = "expenditureRadioBtn";
            expenditureRadioBtn.Size = new Size(93, 29);
            expenditureRadioBtn.TabIndex = 29;
            expenditureRadioBtn.TabStop = true;
            expenditureRadioBtn.Text = "Расход";
            expenditureRadioBtn.UseVisualStyleBackColor = true;
            expenditureRadioBtn.CheckedChanged += expenditureRadioBtn_CheckedChanged;
            // 
            // incomeRadioBtn
            // 
            incomeRadioBtn.AutoSize = true;
            incomeRadioBtn.ForeColor = SystemColors.Control;
            incomeRadioBtn.Location = new Point(3, 17);
            incomeRadioBtn.Name = "incomeRadioBtn";
            incomeRadioBtn.Size = new Size(89, 29);
            incomeRadioBtn.TabIndex = 28;
            incomeRadioBtn.TabStop = true;
            incomeRadioBtn.Text = "Доход";
            incomeRadioBtn.UseVisualStyleBackColor = true;
            incomeRadioBtn.CheckedChanged += incomeRadioBtn_CheckedChanged;
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 681);
            Controls.Add(panel1);
            Controls.Add(cmbCategory);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(datePicker);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StatisticForm";
            Text = "Sta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datePicker;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label10;
        private ComboBox cmbCategory;
        private Panel panel1;
        private RadioButton expenditureRadioBtn;
        private RadioButton incomeRadioBtn;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn Operation;
        private DataGridViewTextBoxColumn Comment;
    }
}