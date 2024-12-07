using Tyuiu.TomilovDA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_TDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_TDA.Text);
                int stopStep = Convert.ToInt32(textBoxVarEnd_TDA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArr = new double[len];

                valueArr = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_TDA.Titles.Add("������ ������� F(x)");

                this.chartFunction_TDA.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_TDA.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_TDA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArr[i]));
                    this.chartFunction_TDA.Series[0].Points.AddXY(startStep, valueArr[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_TDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ������� ������ ����-24-1 ������� ������� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
