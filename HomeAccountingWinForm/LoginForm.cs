using HomeAccounting.Domain;
using HomeAccountingWinForm;
using Microsoft.Extensions.DependencyInjection;
using StoreWinFrom.Forms;

namespace StoreWinFrom
{

    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IServiceProvider serviceProvider, AppDbContext context)
        {
            InitializeComponent();

            _context = context;
            _serviceProvider = serviceProvider;
        }

        private void btnEscapeLogForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите выйти из приложения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                Show();
            }
        }

        private void btnEnterLogForm_Click(object sender, EventArgs e)
        {
            var username = txtLoginInput.Text;
            var password = txtPasswordInput.Text;

            var isExist = _context.Users.Any(u => u.Username == username && u.Password == password);
            if (!isExist)
            {
                MessageBox.Show("Неверный пароль, попробуйте еще раз", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            var mainForm = _serviceProvider.GetService<MainForm>();
            mainForm.Show();
        }

        private void btnVisiblePassword_Click(object sender, EventArgs e)
        {
            btnInvisiblePassword.Visible = true;
            btnVisiblePassword.Visible = false;
            txtPasswordInput.UseSystemPasswordChar = false;
        }

        private void btnInvisiblePassword_Click(object sender, EventArgs e)
        {
            btnInvisiblePassword.Visible = false;
            btnVisiblePassword.Visible = true;
            txtPasswordInput.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registerForm = _serviceProvider.GetService<RegisterForm>();
            registerForm.Show();
        }
    }
}
