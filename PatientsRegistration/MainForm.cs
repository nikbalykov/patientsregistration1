using PatientsRegistration.Filler;
using PatientsRegistration.Helper;
using PatientsRegistration.Service;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PatientsRegistration
{
    public partial class MainForm : Form
    {
        RecordContext db;

        public MainForm()
        {
            InitializeComponent();

            db = new RecordContext();
        }

        private void ConfigureDataGridView()
        {
            foreach (DataGridViewRow row in mainDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }

            DataGridViewHelper.ConfigureColumns(mainDataGridView);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEditForm addOrEditForm = new AddOrEditForm();
            DialogResult result = addOrEditForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Record record = new Record();

            int year = Convert.ToInt32(yearNumericUpDown.Value);
            int month = Convert.ToInt32(monthNumericUpDown.Value);

            FormFiller.FillRecordWithData(record, addOrEditForm, year, month);

            db.Records.Add(record);
            db.SaveChanges();

            RefreshData();

            MessageBox.Show("Запись добавлена.");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.SelectedRows.Count == 1)
            {
                int index = mainDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(mainDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Record record = db.Records.Find(id);

                AddOrEditForm addOrEditForm = new AddOrEditForm();

                FormFiller.FillFormWithData(addOrEditForm, record);

                DialogResult result = addOrEditForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                int year = Convert.ToInt32(yearNumericUpDown.Value);
                int month = Convert.ToInt32(monthNumericUpDown.Value);

                FormFiller.FillRecordWithData(record, addOrEditForm, year, month);

                db.SaveChanges();

                RefreshData();

                MessageBox.Show("Запись обновлена.");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData() 
        {
            using (RecordContext db = new RecordContext())
            {
                mainDataGridView.DataSource = db.Records.Where(r => r.Month == monthNumericUpDown.Value
                && r.Year == yearNumericUpDown.Value).ToList();

                ConfigureDataGridView();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.SelectedRows.Count == 1)
            {
                int index = mainDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(mainDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Record record = db.Records.Find(id);
                db.Records.Remove(record);
                db.SaveChanges();

                RefreshData();

                MessageBox.Show("Запись удалена.");
            }
        }

        private void deleteMonthButton_Click(object sender, EventArgs e)
        {
            RefreshData();

            ApprovalForm approvalForm = new ApprovalForm();

            DialogResult result = approvalForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            else 
            {
                foreach (DataGridViewRow row in mainDataGridView.Rows)
                {
                    Record record = db.Records.Find(Convert.ToInt32(row.Cells[0].Value));
                    db.Records.Remove(record);
                    db.SaveChanges();
                }

                RefreshData();

                MessageBox.Show("Данные за месяц успешно удалены.");
            }
        }

        private void startNewMonthButton_Click(object sender, EventArgs e)
        {
            RefreshData();

            if (mainDataGridView.Rows.Count == 0)
            {
                DataFiller.InitializeMonth(db, Convert.ToInt32(yearNumericUpDown.Value),
                    Convert.ToInt32(monthNumericUpDown.Value));

                RefreshData();
            }
            else 
            {
                MessageBox.Show("Данные по выбранному месяцу уже существуют.");
            }  
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            ExcelService excelService = new ExcelService();

            excelService.CreateReport(Convert.ToInt32(monthNumericUpDown.Value),
                Convert.ToInt32(yearNumericUpDown.Value));
        }
    }
}
