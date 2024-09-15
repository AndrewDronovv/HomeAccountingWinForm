using HomeAccounting.Domain;
using HomeAccounting.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAccountingWinForm
{
    public partial class MainForm : Form
    {
        protected IServiceProvider ServiceProvider { get; set; }
        protected AppDbContext _context { get; set; }

        public MainForm(IServiceProvider serviceProvider, AppDbContext context)
        {
            ServiceProvider = serviceProvider;
            _context = context;

            InitializeComponent();

            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";

            StartPosition = FormStartPosition.CenterParent;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            InitCategories();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = DateTime.Parse(datePicker.Text);

            if (string.IsNullOrWhiteSpace(amountBox.Text))
            {
                MessageBox.Show("Введите сумму");
                return;
            }

            decimal amount = int.Parse(amountBox.Text);
            string comment = commentBox.Text;

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию");
                return;
            }

            try
            {
                Transaction transaction = new()
                {
                    Date = date,
                    Amount = amount,
                    Comment = comment,
                    CategoryId = ((Category)cmbCategory.SelectedItem).Id,
                    UserId = 1
                };

                _context.Transactions.Add(transaction);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InitCategories()
        {
            Category[] categories = _context.Categories
                .Where(c => c.IsIncome == incomeRadioBtn.Checked)
                .ToArray();

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(categories);
        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = null;
            InitCategories();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var statisticForm = ServiceProvider.GetService<StatisticForm>();
            statisticForm.Show();
        }
    }
}
