namespace StoreWinFrom
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            btnEnterLogForm = new Button();
            label3 = new Label();
            btnVisiblePassword = new Button();
            btnEscapeLogForm = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtLoginInput = new TextBox();
            txtPasswordInput = new TextBox();
            btnInvisiblePassword = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 28F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(253, 310);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(379, 67);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(189, 472);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 34);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnterLogForm
            // 
            btnEnterLogForm.BackColor = Color.Transparent;
            btnEnterLogForm.Cursor = Cursors.Hand;
            btnEnterLogForm.FlatAppearance.BorderColor = Color.White;
            btnEnterLogForm.FlatAppearance.BorderSize = 0;
            btnEnterLogForm.FlatAppearance.MouseDownBackColor = Color.White;
            btnEnterLogForm.FlatAppearance.MouseOverBackColor = Color.White;
            btnEnterLogForm.FlatStyle = FlatStyle.Flat;
            btnEnterLogForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnEnterLogForm.ForeColor = Color.WhiteSmoke;
            btnEnterLogForm.Location = new Point(336, 635);
            btnEnterLogForm.Margin = new Padding(4, 5, 4, 5);
            btnEnterLogForm.Name = "btnEnterLogForm";
            btnEnterLogForm.Size = new Size(111, 62);
            btnEnterLogForm.TabIndex = 5;
            btnEnterLogForm.Text = "Войти";
            btnEnterLogForm.UseVisualStyleBackColor = false;
            btnEnterLogForm.Click += btnEnterLogForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 14F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(170, 557);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 34);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVisiblePassword
            // 
            btnVisiblePassword.BackColor = Color.Transparent;
            btnVisiblePassword.FlatAppearance.BorderSize = 0;
            btnVisiblePassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVisiblePassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVisiblePassword.FlatStyle = FlatStyle.Flat;
            btnVisiblePassword.ForeColor = Color.Transparent;
            btnVisiblePassword.Image = (Image)resources.GetObject("btnVisiblePassword.Image");
            btnVisiblePassword.Location = new Point(580, 550);
            btnVisiblePassword.Margin = new Padding(4, 5, 4, 5);
            btnVisiblePassword.Name = "btnVisiblePassword";
            btnVisiblePassword.Size = new Size(53, 47);
            btnVisiblePassword.TabIndex = 6;
            btnVisiblePassword.UseVisualStyleBackColor = false;
            btnVisiblePassword.Click += btnVisiblePassword_Click;
            // 
            // btnEscapeLogForm
            // 
            btnEscapeLogForm.BackColor = Color.Transparent;
            btnEscapeLogForm.Cursor = Cursors.Hand;
            btnEscapeLogForm.FlatAppearance.BorderColor = Color.White;
            btnEscapeLogForm.FlatAppearance.BorderSize = 0;
            btnEscapeLogForm.FlatAppearance.MouseDownBackColor = Color.White;
            btnEscapeLogForm.FlatAppearance.MouseOverBackColor = Color.White;
            btnEscapeLogForm.FlatStyle = FlatStyle.Flat;
            btnEscapeLogForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnEscapeLogForm.ForeColor = Color.WhiteSmoke;
            btnEscapeLogForm.Location = new Point(457, 635);
            btnEscapeLogForm.Margin = new Padding(4, 5, 4, 5);
            btnEscapeLogForm.Name = "btnEscapeLogForm";
            btnEscapeLogForm.Size = new Size(113, 62);
            btnEscapeLogForm.TabIndex = 7;
            btnEscapeLogForm.Text = "Выход";
            btnEscapeLogForm.UseVisualStyleBackColor = false;
            btnEscapeLogForm.Click += btnEscapeLogForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 190);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 94);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(289, 552);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 0);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(293, 472);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 0);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // txtLoginInput
            // 
            txtLoginInput.Location = new Point(336, 472);
            txtLoginInput.Margin = new Padding(4, 5, 4, 5);
            txtLoginInput.MaxLength = 50;
            txtLoginInput.Name = "txtLoginInput";
            txtLoginInput.Size = new Size(234, 31);
            txtLoginInput.TabIndex = 12;
            // 
            // txtPasswordInput
            // 
            txtPasswordInput.Location = new Point(336, 557);
            txtPasswordInput.Margin = new Padding(4, 5, 4, 5);
            txtPasswordInput.MaxLength = 50;
            txtPasswordInput.Name = "txtPasswordInput";
            txtPasswordInput.Size = new Size(234, 31);
            txtPasswordInput.TabIndex = 13;
            txtPasswordInput.UseSystemPasswordChar = true;
            // 
            // btnInvisiblePassword
            // 
            btnInvisiblePassword.BackColor = Color.Transparent;
            btnInvisiblePassword.FlatAppearance.BorderSize = 0;
            btnInvisiblePassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInvisiblePassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInvisiblePassword.FlatStyle = FlatStyle.Flat;
            btnInvisiblePassword.ForeColor = Color.Transparent;
            btnInvisiblePassword.Image = (Image)resources.GetObject("btnInvisiblePassword.Image");
            btnInvisiblePassword.Location = new Point(580, 550);
            btnInvisiblePassword.Margin = new Padding(4, 5, 4, 5);
            btnInvisiblePassword.Name = "btnInvisiblePassword";
            btnInvisiblePassword.Size = new Size(53, 47);
            btnInvisiblePassword.TabIndex = 14;
            btnInvisiblePassword.UseVisualStyleBackColor = false;
            btnInvisiblePassword.Visible = false;
            btnInvisiblePassword.Click += btnInvisiblePassword_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 14F, FontStyle.Bold);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(351, 707);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(211, 62);
            button1.TabIndex = 15;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(909, 853);
            Controls.Add(button1);
            Controls.Add(btnInvisiblePassword);
            Controls.Add(txtPasswordInput);
            Controls.Add(txtLoginInput);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEscapeLogForm);
            Controls.Add(btnVisiblePassword);
            Controls.Add(label1);
            Controls.Add(btnEnterLogForm);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEnterLogForm;
        private Label label3;
        private Button btnVisiblePassword;
        private Button btnEscapeLogForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtLoginInput;
        private TextBox txtPasswordInput;
        private Button btnInvisiblePassword;
        private Button button1;
    }
}
