using HomeAccounting.Domain;
using HomeAccounting.Domain.Entities;
using System.Text.RegularExpressions;

namespace StoreWinFrom.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext _context;

        public RegisterForm(AppDbContext context)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _context = context;
        }
        public RegisterForm()
        {
            
        }
        private void btnSaveRegForm_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string patronymic = txtPatronymic.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(lastname) || (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)))
            {
                txtLastName.BackColor = Color.LightGoldenrodYellow;
                txtName.BackColor = Color.LightGoldenrodYellow;
                txtUserName.BackColor = Color.LightGoldenrodYellow;
                txtPassword.BackColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните все подсвеченные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string pattern = @"^[a-zA-Z0-9]*$";
            if (!Regex.IsMatch(username, pattern) || !Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("Логин и пароль содержит \nтолько английские буквы и цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = Regex.Replace(username, "[^a-zA-Z0-9]", "");
                txtPassword.Text = Regex.Replace(password, "[^a-zA-Z0-9]", "");
                txtPassword.BackColor = Color.LightGoldenrodYellow;
                return;
            }

            try
            {
                User user = new()
                {
                    Name = name,
                    LastName = lastname,
                    Patronymic = patronymic,
                    Username = username,
                    Password = password,
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните все необходимые поля", "Ошибка");
                return;
            }
        }     
        

        private void btnEscapeRegForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
