using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtolVA.Sprint7.Project.V2.Lib;
using System.IO;

namespace Tyuiu.ShtolVA.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogProjectV2_SVA.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonProgramm_SVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonQuickGuide_SVA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddition_SVA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOpenFile_SVA.Rows.Add();
                for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labelPoisk_SVA_Click(object sender, EventArgs e)
        {

        }



        private void buttonFile_SVA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogProjectV2_SVA.ShowDialog();
                openFilePath = openFileDialogProjectV2_SVA.FileName;

                matrix = ds.LoadDataFromFile(openFilePath);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewOpenFile_SVA.Rows.Clear();
                dataGridViewOpenFile_SVA.Columns.Clear();
                dataGridViewOpenFile_SVA.RowCount = rows + 1;
                dataGridViewOpenFile_SVA.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = false;
                    }
                }
                this.dataGridViewOpenFile_SVA.DefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridViewOpenFile_SVA.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static string[,] mtrxSearch;



        private void buttonGraf_SVA_Click(object sender, EventArgs e)
        {
            FormCharts formCharts = new FormCharts();
            formCharts.Show();
        }
        private void buttonQuickGuide_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProjectV2_SVA.SetToolTip(buttonQuickGuide_SVA, "Открыть краткое руководство");
        }

        private void buttonProgramm_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProjectV2_SVA.SetToolTip(buttonProgramm_SVA, "Открыть  информацию о разработчике");
        }

        private void buttonGraF_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProjectV2_SVA.SetToolTip(buttonGraf_SVA, "Открыть графики");
        }

        private void buttonFile_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProjectV2_SVA.SetToolTip(buttonFile_SVA, "Открыть файл");
        }

        private void buttonDelete_SVA_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_SVA.RowCount != 0)
            {
                int nad = -1;
                for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                    {
                        if (dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected == true)
                        {
                            nad = j;
                            break;
                        }
                    }
                    if (nad > -1) break;
                }
                if (nad > -1)
                {
                    if (dataGridViewOpenFile_SVA.Rows[0].Cells[nad].Selected == true) MessageBox.Show("Первую строку нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var result = MessageBox.Show($"{"Удалить данную строку?" + "\r"}{"Ее невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int k = -1; int udal = 0;
                            for (int i = 1; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_SVA.Rows[i].Cells[nad].Selected == true)
                                {
                                    k = i;
                                    break;
                                }
                                if (k > -1) break;
                            }
                            for (int i = 1; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_SVA.Rows[i].Cells[nad].Selected == true) udal++;
                            }
                            for (int r = 0; r < udal; r++) dataGridViewOpenFile_SVA.Rows.Remove(dataGridViewOpenFile_SVA.Rows[k]);
                            for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                    }
                }
                else MessageBox.Show("Выберите строку, которую ходите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSave_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProjectV2_SVA.SetToolTip(buttonSave_SVA, "Сохранить файл");
        }

        private void textBoxPoisk_SVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPoisk_SVA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < mtrxSearch.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mtrxSearch.GetUpperBound(1); j++)
                    {
                        if (mtrxSearch[i, j] != null)
                        {
                            string elmnt = mtrxSearch[i, j].ToLower();
                            if (elmnt.Contains(textBoxPoisk_SVA.Text.ToLower())) dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = true;
                        }
                    }
                }
            }
        }

        private void textBoxPoisk_SVA_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SVA.RowCount != 0)
            {
                mtrxSearch = new string[dataGridViewOpenFile_SVA.RowCount, dataGridViewOpenFile_SVA.ColumnCount];
                for (int i = 0; i < mtrxSearch.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mtrxSearch.GetUpperBound(1); j++)
                    {
                        mtrxSearch[i, j] = Convert.ToString(dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value);
                        dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = false;
                    }
                }

                textBoxKolvo_SVA.Text = "";
                textBoxSum_SVA.Text = "";
                textBoxAverage_SVA.Text = "";
                textBoxMin_SVA.Text = "";
                textBoxMax_SVA.Text = "";
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static string[,] mtrxSort;
        static int poid = 0;
        private void comboBoxSort_SVA_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SVA.RowCount != 0)
            {
                mtrxSort = new string[dataGridViewOpenFile_SVA.RowCount, dataGridViewOpenFile_SVA.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                    {
                        mtrxSort[i, j] = Convert.ToString(dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value);
                    }
                }
                poid++;

                int soid = 0; int k = -1;
                for (int i = 1; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount; j++)
                    {
                        if (dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value == null) soid++;
                    }
                    if (soid == dataGridViewOpenFile_SVA.ColumnCount)
                    {
                        k = i;
                        break;
                    }
                    else soid = 0;
                }
                if (k > 0) MessageBox.Show("Пожалуйста, удалите все пустые строки, кроме последней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxSort_SVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSort_SVA.SelectedItem != null && dataGridViewOpenFile_SVA.RowCount != 0)
            {
                int soid = 0; int k = -1;
                for (int i = 1; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount; j++)
                    {
                        if (dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value == null) soid++;
                    }
                    if (soid == dataGridViewOpenFile_SVA.ColumnCount)
                    {
                        k = i;
                        break;
                    }
                    else soid = 0;
                }
                if (k > 0) MessageBox.Show("Пожалуйста, удалите все пустые строки, кроме последней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int groid = 0;
                    for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected == false) groid++;
                        }
                    }
                    if (groid != (dataGridViewOpenFile_SVA.RowCount - 1) * (dataGridViewOpenFile_SVA.ColumnCount - 1))
                    {
                        int columnIndex = -1;
                        for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                            {
                                if (dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value != null)
                                {
                                    if (dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected == true)
                                    {
                                        columnIndex = j;
                                        break;
                                    }
                                }
                            }
                            if (columnIndex > -1) break;
                        }

                        for (int i = 1; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                        {
                            double cellValue;
                            if (dataGridViewOpenFile_SVA.Rows[i].Cells[columnIndex].Value != null && double.TryParse(dataGridViewOpenFile_SVA.Rows[i].Cells[columnIndex].Value.ToString(), out cellValue))
                            {
                                dataGridViewOpenFile_SVA.Rows[i].Cells[columnIndex].Value = cellValue;
                            }
                        }

                        string selectedItem = comboBoxSort_SVA.SelectedItem.ToString();
                        if (selectedItem == "По возрастанию (от А до Я)" && poid != 0)
                        {
                            DataGridViewRow row = dataGridViewOpenFile_SVA.Rows[0];
                            dataGridViewOpenFile_SVA.Rows.Remove(dataGridViewOpenFile_SVA.Rows[0]);

                            DataGridViewColumn column = dataGridViewOpenFile_SVA.Columns[columnIndex];

                            dataGridViewOpenFile_SVA.Sort(column, ListSortDirection.Ascending);
                            dataGridViewOpenFile_SVA.Rows.Insert(0, row);

                            for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                        else if (selectedItem == "По убыванию (от Я до А)" && poid != 0)
                        {
                            DataGridViewRow row = dataGridViewOpenFile_SVA.Rows[0];
                            dataGridViewOpenFile_SVA.Rows.Remove(dataGridViewOpenFile_SVA.Rows[0]);

                            DataGridViewColumn column = dataGridViewOpenFile_SVA.Columns[columnIndex];

                            dataGridViewOpenFile_SVA.Sort(column, ListSortDirection.Descending);
                            dataGridViewOpenFile_SVA.Rows.Insert(0, row);

                            for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                        else MessageBox.Show("Не забудьте нажать на пустое поле ввода сортирвоки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBoxKolvo_SVA.Text = "";
                        textBoxSum_SVA.Text = "";
                        textBoxAverage_SVA.Text = "";
                        textBoxMin_SVA.Text = "";
                        textBoxMax_SVA.Text = "";
                    }
                    else if (groid == (dataGridViewOpenFile_SVA.RowCount - 1) * (dataGridViewOpenFile_SVA.ColumnCount - 1) && poid != 0)
                    {
                        MessageBox.Show("Пожалуйста, выберите столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (groid == (dataGridViewOpenFile_SVA.RowCount - 1) * (dataGridViewOpenFile_SVA.ColumnCount - 1) && poid == 0)
                    {
                        MessageBox.Show($"{"Пожалуйста, выберите столбец." + "\r"}{"Не забудьте нажать на пустое поле ввода сортирвоки!"}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDeletSort_SVA_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_SVA.RowCount != 0 && poid != 0)
            {
                for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value = mtrxSort[i, j];
                        dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            else if (dataGridViewOpenFile_SVA.RowCount != 0 && poid == 0) MessageBox.Show("Нажимайте на пустое поле ввода сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static string[,] mtrxFilter;
        static int bulo = 0;
        private void textBoxFilter_SVA_KeyDoWn(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SVA.RowCount != 0)
            {
                mtrxFilter = new string[dataGridViewOpenFile_SVA.RowCount, dataGridViewOpenFile_SVA.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                    {
                        mtrxFilter[i, j] = Convert.ToString(dataGridViewOpenFile_SVA.Rows[i].Cells[j].Value);
                    }
                }
                bulo++;
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxKolvo_SVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKolvo_SVA_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SVA.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile_SVA.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SVA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SVA.Rows[i].Cells[j].Selected == true)
                            {
                                nugno = j;
                                break;
                            }
                            if (nugno > -1) break;
                        }
                    }

                    if (nugno > -1)
                    {
                        int counter = 0;
                        for (int r = 0; r < dataGridViewOpenFile_SVA.RowCount; r++)
                        {
                            if (dataGridViewOpenFile_SVA.Rows[r].Cells[nugno].Selected == true) counter++;
                        }
                        textBoxKolvo_SVA.Text = Convert.ToString(counter);
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
