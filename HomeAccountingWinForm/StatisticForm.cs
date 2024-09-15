using HomeAccounting.Domain;
using HomeAccounting.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAccountingWinForm
{
    public partial class StatisticForm : Form
    {
        private readonly AppDbContext _context;
        public StatisticForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedDate = datePicker.Value;
            var transactions = _context.Transactions
                .Include(t => t.Category)
                .Where(t => t.Date.Month == selectedDate.Month && t.Date.Year == selectedDate.Year)
                .ToList();
            var transactionGroups = transactions
                .GroupBy(t => t.Category.Name)
                .Select(g => new
                {
                    Category = g.Key,
                    Sum = g.Sum(t => t.Amount),
                    Operation = g.First().Category.IsIncome ? "Доход" : "Расход",
                    Comment = g.First().Comment,
                });
            dataGridView1.Rows.Clear();
            foreach (var transactionGroup in transactionGroups)
            {
                dataGridView1.Rows.Add(transactionGroup.Category, transactionGroup.Sum, transactionGroup.Operation, transactionGroup.Comment);
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
        private void LoadDataGridView()
        {
            string categoryName = cmbCategory.Text;
            var data = _context.Transactions
                .Include(c => c.Category)
                .Where(c => c.Category.Name == categoryName)
                .ToList();

            var transactionGroups = data
                            .GroupBy(t => t.Category.Name)
                            .Select(g => new
                            {
                                Category = g.Key,
                                Sum = g.Sum(t => t.Amount),
                                Operation = g.First().Category.IsIncome ? "Доход" : "Расход",
                                Comment = g.First().Comment,
                            });

            if (incomeRadioBtn.Checked)
            {
                transactionGroups = transactionGroups.OrderBy(t => t.Operation == "Доход");
            }
            else if (expenditureRadioBtn.Checked)
            {
                transactionGroups = transactionGroups.OrderBy(t => t.Operation == "Расход");
            }

            dataGridView1.Rows.Clear();

            foreach (var category in transactionGroups)
            {
                dataGridView1.Rows.Add(category.Category, category.Sum, category.Operation, category.Comment);
            }
        }

        private void incomeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            InitCategories();
            var data = _context.Transactions
                .Include(c => c.Category)
                .Where(c => c.Category.IsIncome == true)
                .ToList();

            var transactionGroups = data
                            .GroupBy(t => t.Category.Name)
                            .Select(g => new
                            {
                                Category = g.Key,
                                Sum = g.Sum(t => t.Amount),
                                Operation = g.First().Category.IsIncome ? "Доход" : "Расход",
                                Comment = g.First().Comment,
                            });

            dataGridView1.Rows.Clear();

            foreach (var category in transactionGroups)
            {
                dataGridView1.Rows.Add(category.Category, category.Sum, category.Operation, category.Comment);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedId = cmbCategory.Text;
            LoadDataGridView();
        }

        private void expenditureRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            InitCategories();
            var data = _context.Transactions
                .Include(c => c.Category)
                .Where(c => c.Category.IsIncome == false)
                .ToList();

            var transactionGroups = data
                            .GroupBy(t => t.Category.Name)
                            .Select(g => new
                            {
                                Category = g.Key,
                                Sum = g.Sum(t => t.Amount),
                                Operation = g.First().Category.IsIncome ? "Доход" : "Расход",
                                Comment = g.First().Comment,
                            });

            dataGridView1.Rows.Clear();

            foreach (var category in transactionGroups)
            {
                dataGridView1.Rows.Add(category.Category, category.Sum, category.Operation, category.Comment);
            }
        }
    }
}
