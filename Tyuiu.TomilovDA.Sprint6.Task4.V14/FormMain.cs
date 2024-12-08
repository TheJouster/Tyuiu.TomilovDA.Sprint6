using Tyuiu.TomilovDA.Sprint6.Task4.V14.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_TDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-24-1 Томилов Дмитрий Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataService ds = new DataService();
        private void buttonDone_TDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_TDA.Text);
                int endStep = Convert.ToInt32(textBoxVarEnd_TDA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, endStep).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, endStep);

                this.chartResult_TDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_TDA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_TDA.Text = "";
                chartResult_TDA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartResult_TDA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_TDA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_TDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V14.txt";
                File.WriteAllText(path, textBoxResult_TDA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_TDA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
