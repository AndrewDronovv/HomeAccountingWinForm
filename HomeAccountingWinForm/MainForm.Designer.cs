namespace HomeAccountingWinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            amountBox = new TextBox();
            AddBtn = new Button();
            cmbCategory = new ComboBox();
            commentBox = new TextBox();
            datePicker = new DateTimePicker();
            expenditureRadioBtn = new RadioButton();
            incomeRadioBtn = new RadioButton();
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // amountBox
            // 
            amountBox.Font = new Font("Segoe UI", 10F);
            amountBox.Location = new Point(271, 453);
            amountBox.Margin = new Padding(4, 5, 4, 5);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(195, 34);
            amountBox.TabIndex = 4;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Transparent;
            AddBtn.BackgroundImageLayout = ImageLayout.Center;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            AddBtn.ForeColor = SystemColors.ButtonFace;
            AddBtn.Location = new Point(271, 599);
            AddBtn.Margin = new Padding(4, 5, 4, 5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(195, 58);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(271, 382);
            cmbCategory.Margin = new Padding(4, 5, 4, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(195, 36);
            cmbCategory.TabIndex = 10;
            // 
            // commentBox
            // 
            commentBox.Font = new Font("Segoe UI", 10F);
            commentBox.Location = new Point(271, 525);
            commentBox.Margin = new Padding(4, 5, 4, 5);
            commentBox.Name = "commentBox";
            commentBox.Size = new Size(195, 34);
            commentBox.TabIndex = 11;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Segoe UI", 10F);
            datePicker.Location = new Point(271, 122);
            datePicker.Margin = new Padding(4, 5, 4, 5);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(195, 34);
            datePicker.TabIndex = 13;
            // 
            // expenditureRadioBtn
            // 
            expenditureRadioBtn.AutoSize = true;
            expenditureRadioBtn.ForeColor = SystemColors.ButtonHighlight;
            expenditureRadioBtn.Location = new Point(20, 78);
            expenditureRadioBtn.Margin = new Padding(4, 5, 4, 5);
            expenditureRadioBtn.Name = "expenditureRadioBtn";
            expenditureRadioBtn.Size = new Size(99, 32);
            expenditureRadioBtn.TabIndex = 15;
            expenditureRadioBtn.TabStop = true;
            expenditureRadioBtn.Text = "Расход";
            expenditureRadioBtn.UseVisualStyleBackColor = true;
            expenditureRadioBtn.CheckedChanged += RadioBtn_CheckedChanged;
            // 
            // incomeRadioBtn
            // 
            incomeRadioBtn.AutoSize = true;
            incomeRadioBtn.Checked = true;
            incomeRadioBtn.ForeColor = SystemColors.ButtonHighlight;
            incomeRadioBtn.Location = new Point(20, 20);
            incomeRadioBtn.Margin = new Padding(4, 5, 4, 5);
            incomeRadioBtn.Name = "incomeRadioBtn";
            incomeRadioBtn.Size = new Size(95, 32);
            incomeRadioBtn.TabIndex = 16;
            incomeRadioBtn.TabStop = true;
            incomeRadioBtn.Text = "Доход";
            incomeRadioBtn.UseVisualStyleBackColor = true;
            incomeRadioBtn.CheckedChanged += RadioBtn_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(incomeRadioBtn);
            panel1.Controls.Add(expenditureRadioBtn);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(271, 213);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 137);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(605, 599);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(195, 58);
            button1.TabIndex = 18;
            button1.Text = "Статистика";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 10F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(110, 535);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 24);
            label6.TabIndex = 19;
            label6.Text = "Комментарий";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 10F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(196, 132);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 24);
            label7.TabIndex = 19;
            label7.Text = "Дата";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 10F);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(180, 463);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 24);
            label8.TabIndex = 20;
            label8.Text = "Сумма";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 10F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(110, 272);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(143, 24);
            label9.TabIndex = 20;
            label9.Text = "Вид операции";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 10F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(146, 394);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(107, 24);
            label10.TabIndex = 21;
            label10.Text = "Категория";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 825);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(datePicker);
            Controls.Add(commentBox);
            Controls.Add(cmbCategory);
            Controls.Add(AddBtn);
            Controls.Add(amountBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox amountBox;
        private Button AddBtn;
        private ComboBox cmbCategory;
        private TextBox commentBox;
        private DateTimePicker datePicker;
        private RadioButton expenditureRadioBtn;
        private RadioButton incomeRadioBtn;
        private Panel panel1;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}