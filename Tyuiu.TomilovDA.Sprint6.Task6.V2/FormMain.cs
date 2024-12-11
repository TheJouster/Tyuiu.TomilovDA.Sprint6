using Tyuiu.TomilovDA.Sprint6.Task6.V2.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonDone_TDA_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput_TDA.Text = ds.CollectTextFromFile(openFilePath);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные или файл не существует", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_TDA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }



        private void textBoxCondition_TDA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonOpen_TDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_TDA.ShowDialog();
            openFilePath = openFileDialogTask_TDA.FileName;
            textBoxInput_TDA.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_TDA.Text = groupBoxOutput_TDA.Text + " " + openFileDialogTask_TDA.FileName;
            buttonDone_TDA.Enabled = true;

        }
    }
}
