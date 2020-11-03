using System.Windows.Forms;

namespace PatientsRegistration.Helper
{
    public static class DataGridViewHelper
    {
        public static void ConfigureColumns(DataGridView mainDataGridView)
        {
            mainDataGridView.Columns[3].HeaderText = "Год";
            mainDataGridView.Columns[4].HeaderText = "Месяц";
            mainDataGridView.Columns[5].HeaderText = "Наименование";
            mainDataGridView.Columns[6].HeaderText = "Группа отделений";
            mainDataGridView.Columns[7].HeaderText = "Число коек";
            mainDataGridView.Columns[8].HeaderText = "Состояло";
            mainDataGridView.Columns[9].HeaderText = "Поступило всего";
            mainDataGridView.Columns[10].HeaderText = "В т.ч. сельских";
            mainDataGridView.Columns[11].HeaderText = "Переведено из др";
            mainDataGridView.Columns[12].HeaderText = "Переведено в др";
            mainDataGridView.Columns[13].HeaderText = "Выписано";
            mainDataGridView.Columns[14].HeaderText = "Умерло";
            mainDataGridView.Columns[15].HeaderText = "Состоит";
            mainDataGridView.Columns[16].HeaderText = "План к/дн";
            mainDataGridView.Columns[17].HeaderText = "Факт к/дн";
            mainDataGridView.Columns[18].HeaderText = "К/дн сельских";
            mainDataGridView.Columns[19].HeaderText = "% выполнения плана";
            mainDataGridView.Columns[20].HeaderText = "Летальность";
            mainDataGridView.Columns[21].HeaderText = "Среднее пребывание";
            mainDataGridView.Columns[22].HeaderText = "Работа койки";
            mainDataGridView.Columns[23].HeaderText = "Оборот койки";
            mainDataGridView.Columns[24].HeaderText = "% сельских жителей";
            mainDataGridView.Columns[0].Visible = false;
            mainDataGridView.Columns[1].Visible = false;
            mainDataGridView.Columns[2].Visible = false;
        }
    }
}
