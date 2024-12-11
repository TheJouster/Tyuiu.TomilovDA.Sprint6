using Tyuiu.TomilovDA.Sprint6.Task7.V19.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task7.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_TDA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_TDA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonDone_TDA_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] arrayValues = new int[rows, columns];
                arrayValues = ds.GetMatrix(openFilePath);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_TDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                buttonSave_TDA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные или файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_TDA.ColumnCount = columns;
            dataGridViewIn_TDA.RowCount = rows;
            dataGridViewOut_TDA.ColumnCount = columns;
            dataGridViewOut_TDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_TDA.Columns[i].Width = 25;
                dataGridViewOut_TDA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_TDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_TDA.Enabled = true;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_TDA.ColumnCount = 50;
            dataGridViewOut_TDA.ColumnCount = 50;

            dataGridViewIn_TDA.RowCount = 50;
            dataGridViewOut_TDA.RowCount = 50;

            panelTextBoxInput_TDA.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_TDA.Columns[i].Width = 25;
                dataGridViewOut_TDA.Columns[i].Width = 25;
            }
        }

        private void buttonSave_TDA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_TDA.FileName = "OutPutFileTask7V19.csv";
            saveFileDialogMatrix_TDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_TDA.ShowDialog();

            string path = saveFileDialogMatrix_TDA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_TDA.RowCount;
            int columns = dataGridViewOut_TDA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_TDA.Rows[i].Cells[j].Value.ToString() + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_TDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_TDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_TDA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_TDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_TDA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_TDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_TDA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_TDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_TDA.ToolTipTitle = "Справка";
        }
    }
}
