namespace StoreWinFrom.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSaveRegForm = new Button();
            btnEscapeRegForm = new Button();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtPatronymic = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(169, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 34);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 14F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(231, 253);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 34);
            label3.TabIndex = 6;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 14F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(167, 317);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 34);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(113, 65);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(560, 43);
            label6.TabIndex = 9;
            label6.Text = "Окно регистрации сотрудника";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 14F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(209, 380);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 34);
            label9.TabIndex = 15;
            label9.Text = "Логин";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 14F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(190, 447);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(113, 34);
            label10.TabIndex = 17;
            label10.Text = "Пароль";
            // 
            // btnSaveRegForm
            // 
            btnSaveRegForm.BackColor = Color.Transparent;
            btnSaveRegForm.FlatAppearance.BorderSize = 0;
            btnSaveRegForm.FlatStyle = FlatStyle.Flat;
            btnSaveRegForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnSaveRegForm.ForeColor = Color.WhiteSmoke;
            btnSaveRegForm.Location = new Point(336, 508);
            btnSaveRegForm.Margin = new Padding(4, 5, 4, 5);
            btnSaveRegForm.Name = "btnSaveRegForm";
            btnSaveRegForm.Size = new Size(173, 62);
            btnSaveRegForm.TabIndex = 18;
            btnSaveRegForm.Text = "Сохранить";
            btnSaveRegForm.UseVisualStyleBackColor = false;
            btnSaveRegForm.Click += btnSaveRegForm_Click;
            // 
            // btnEscapeRegForm
            // 
            btnEscapeRegForm.BackColor = Color.Transparent;
            btnEscapeRegForm.FlatAppearance.BorderSize = 0;
            btnEscapeRegForm.FlatStyle = FlatStyle.Flat;
            btnEscapeRegForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnEscapeRegForm.ForeColor = Color.WhiteSmoke;
            btnEscapeRegForm.Location = new Point(336, 593);
            btnEscapeRegForm.Margin = new Padding(4, 5, 4, 5);
            btnEscapeRegForm.Name = "btnEscapeRegForm";
            btnEscapeRegForm.Size = new Size(173, 62);
            btnEscapeRegForm.TabIndex = 19;
            btnEscapeRegForm.Text = "Отмена";
            btnEscapeRegForm.UseVisualStyleBackColor = false;
            btnEscapeRegForm.Click += btnEscapeRegForm_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(309, 183);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(228, 31);
            txtLastName.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(309, 253);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 31);
            txtName.TabIndex = 21;
            // 
            // txtPatronymic
            // 
            txtPatronymic.Location = new Point(309, 317);
            txtPatronymic.Margin = new Padding(4, 5, 4, 5);
            txtPatronymic.Name = "txtPatronymic";
            txtPatronymic.Size = new Size(228, 31);
            txtPatronymic.TabIndex = 22;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(309, 380);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(228, 31);
            txtUserName.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(309, 447);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 31);
            txtPassword.TabIndex = 26;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(767, 698);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPatronymic);
            Controls.Add(txtName);
            Controls.Add(txtLastName);
            Controls.Add(btnEscapeRegForm);
            Controls.Add(btnSaveRegForm);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label9;
        private Label label10;
        private Button btnSaveRegForm;
        private Button btnEscapeRegForm;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtPatronymic;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}