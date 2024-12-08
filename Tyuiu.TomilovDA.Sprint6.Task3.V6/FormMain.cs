using System.Drawing.Drawing2D;
using Tyuiu.TomilovDA.Sprint6.Task3.V6.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task3.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[,] { {-2,-10,-8,11,1 },
                                   {-15,-9,-4,-15,18 },
                                   {-15,12,7,6,9 },
                                   {-14,-10,10,18,-5 },
                                   {-1, 7,-19,-19,-4 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            dataGridViewMatrix_TDA.ColumnCount = cols;
            dataGridViewMatrix_TDA.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_TDA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_TDA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonDone_TDA_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            dataGridViewResult_TDA.ColumnCount = cols;
            dataGridViewResult_TDA.RowCount = rows;
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult_TDA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_TDA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_TDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-24-1 Томилов Дмитрий Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
