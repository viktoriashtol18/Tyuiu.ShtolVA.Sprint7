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
                dataGridViewOpenFile_SVA.ColumnCount = columns ;

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

        private void textBoxPoisk_SVA_TextChanged(object sender, EventArgs e)
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


    }
}