using Tyuiu.TomilovDA.Sprint6.Task5.V27.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Sprint6Task5\InPutDataFileTask5V27.txt";
        private void buttonDone_TDA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewFunction_TDA.ColumnCount = 2;
                dataGridViewFunction_TDA.Columns[0].Width = 20;
                dataGridViewFunction_TDA.Columns[1].Width = 50;

                this.chartResult_TDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_TDA.ChartAreas[0].AxisY.Title = "Ось Y";

                chartResult_TDA.Series[0].Points.Clear();

                double[] nums = new double[ds.len];
                nums = ds.LoadFromDataFile(path);
                for (int i = 0; i < nums.Length; i++)
                {
                    dataGridViewFunction_TDA.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                    chartResult_TDA.Series[0].Points.AddXY(i, nums[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные или файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_TDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-24-1 Томилов Дмитрий Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_TDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void textBoxCondition_TDA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
