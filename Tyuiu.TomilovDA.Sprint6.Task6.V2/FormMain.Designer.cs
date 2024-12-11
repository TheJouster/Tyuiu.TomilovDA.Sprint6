namespace Tyuiu.TomilovDA.Sprint6.Task6.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxMain_TDA = new GroupBox();
            textBoxCondition_TDA = new TextBox();
            buttonDone_TDA = new Button();
            buttonHelp_TDA = new Button();
            buttonOpen_TDA = new Button();
            panelTop_TDA = new Panel();
            groupBoxOutput_TDA = new GroupBox();
            textBoxOutput_TDA = new TextBox();
            panelTextBoxInput_TDA = new Panel();
            groupBoxInput_TDA = new GroupBox();
            textBoxInput_TDA = new TextBox();
            splitterResult_TDA = new Splitter();
            panelChartResult_TDA = new Panel();
            openFileDialogTask_TDA = new OpenFileDialog();
            toolTipOpen_TDA = new ToolTip(components);
            groupBoxMain_TDA.SuspendLayout();
            panelTop_TDA.SuspendLayout();
            groupBoxOutput_TDA.SuspendLayout();
            panelTextBoxInput_TDA.SuspendLayout();
            groupBoxInput_TDA.SuspendLayout();
            panelChartResult_TDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_TDA
            // 
            groupBoxMain_TDA.AccessibleName = "Условие";
            groupBoxMain_TDA.Controls.Add(textBoxCondition_TDA);
            groupBoxMain_TDA.Location = new Point(12, 74);
            groupBoxMain_TDA.Name = "groupBoxMain_TDA";
            groupBoxMain_TDA.Size = new Size(840, 64);
            groupBoxMain_TDA.TabIndex = 0;
            groupBoxMain_TDA.TabStop = false;
            groupBoxMain_TDA.Text = "Условие";
            // 
            // textBoxCondition_TDA
            // 
            textBoxCondition_TDA.BackColor = SystemColors.Menu;
            textBoxCondition_TDA.BorderStyle = BorderStyle.None;
            textBoxCondition_TDA.Dock = DockStyle.Fill;
            textBoxCondition_TDA.Location = new Point(3, 19);
            textBoxCondition_TDA.Multiline = true;
            textBoxCondition_TDA.Name = "textBoxCondition_TDA";
            textBoxCondition_TDA.ReadOnly = true;
            textBoxCondition_TDA.Size = new Size(834, 42);
            textBoxCondition_TDA.TabIndex = 1;
            textBoxCondition_TDA.Text = resources.GetString("textBoxCondition_TDA.Text");
            textBoxCondition_TDA.TextChanged += textBoxCondition_TDA_TextChanged;
            // 
            // buttonDone_TDA
            // 
            buttonDone_TDA.BackColor = SystemColors.Menu;
            buttonDone_TDA.Enabled = false;
            buttonDone_TDA.Image = Properties.Resources.page_white_go;
            buttonDone_TDA.Location = new Point(109, 3);
            buttonDone_TDA.Name = "buttonDone_TDA";
            buttonDone_TDA.Size = new Size(99, 71);
            buttonDone_TDA.TabIndex = 3;
            toolTipOpen_TDA.SetToolTip(buttonDone_TDA, "Обрабатывает файл по условию");
            buttonDone_TDA.UseVisualStyleBackColor = false;
            buttonDone_TDA.Click += buttonDone_TDA_Click;
            // 
            // buttonHelp_TDA
            // 
            buttonHelp_TDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_TDA.BackColor = SystemColors.Menu;
            buttonHelp_TDA.Image = Properties.Resources.information;
            buttonHelp_TDA.Location = new Point(760, 3);
            buttonHelp_TDA.Name = "buttonHelp_TDA";
            buttonHelp_TDA.Size = new Size(92, 71);
            buttonHelp_TDA.TabIndex = 4;
            toolTipOpen_TDA.SetToolTip(buttonHelp_TDA, "Сведения о программе");
            buttonHelp_TDA.UseVisualStyleBackColor = false;
            buttonHelp_TDA.Click += buttonHelp_TDA_Click;
            // 
            // buttonOpen_TDA
            // 
            buttonOpen_TDA.BackColor = SystemColors.Menu;
            buttonOpen_TDA.Image = Properties.Resources.folder_page;
            buttonOpen_TDA.Location = new Point(3, 3);
            buttonOpen_TDA.Name = "buttonOpen_TDA";
            buttonOpen_TDA.Size = new Size(100, 71);
            buttonOpen_TDA.TabIndex = 5;
            toolTipOpen_TDA.SetToolTip(buttonOpen_TDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen_TDA.UseVisualStyleBackColor = false;
            buttonOpen_TDA.Click += buttonOpen_TDA_Click;
            // 
            // panelTop_TDA
            // 
            panelTop_TDA.Controls.Add(groupBoxMain_TDA);
            panelTop_TDA.Controls.Add(buttonHelp_TDA);
            panelTop_TDA.Controls.Add(buttonOpen_TDA);
            panelTop_TDA.Controls.Add(buttonDone_TDA);
            panelTop_TDA.Dock = DockStyle.Top;
            panelTop_TDA.Location = new Point(0, 0);
            panelTop_TDA.Name = "panelTop_TDA";
            panelTop_TDA.Size = new Size(864, 144);
            panelTop_TDA.TabIndex = 6;
            // 
            // groupBoxOutput_TDA
            // 
            groupBoxOutput_TDA.Controls.Add(textBoxOutput_TDA);
            groupBoxOutput_TDA.Dock = DockStyle.Fill;
            groupBoxOutput_TDA.Location = new Point(0, 0);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(441, 417);
            groupBoxOutput_TDA.TabIndex = 2;
            groupBoxOutput_TDA.TabStop = false;
            groupBoxOutput_TDA.Text = "Вывод данных";
            // 
            // textBoxOutput_TDA
            // 
            textBoxOutput_TDA.Dock = DockStyle.Fill;
            textBoxOutput_TDA.Location = new Point(3, 19);
            textBoxOutput_TDA.Multiline = true;
            textBoxOutput_TDA.Name = "textBoxOutput_TDA";
            textBoxOutput_TDA.ReadOnly = true;
            textBoxOutput_TDA.Size = new Size(435, 395);
            textBoxOutput_TDA.TabIndex = 1;
            // 
            // panelTextBoxInput_TDA
            // 
            panelTextBoxInput_TDA.Controls.Add(groupBoxInput_TDA);
            panelTextBoxInput_TDA.Dock = DockStyle.Left;
            panelTextBoxInput_TDA.Location = new Point(0, 144);
            panelTextBoxInput_TDA.Name = "panelTextBoxInput_TDA";
            panelTextBoxInput_TDA.Size = new Size(420, 417);
            panelTextBoxInput_TDA.TabIndex = 7;
            // 
            // groupBoxInput_TDA
            // 
            groupBoxInput_TDA.Controls.Add(textBoxInput_TDA);
            groupBoxInput_TDA.Dock = DockStyle.Fill;
            groupBoxInput_TDA.Location = new Point(0, 0);
            groupBoxInput_TDA.Name = "groupBoxInput_TDA";
            groupBoxInput_TDA.Size = new Size(420, 417);
            groupBoxInput_TDA.TabIndex = 0;
            groupBoxInput_TDA.TabStop = false;
            groupBoxInput_TDA.Text = "Ввод данных";
            // 
            // textBoxInput_TDA
            // 
            textBoxInput_TDA.Dock = DockStyle.Fill;
            textBoxInput_TDA.Location = new Point(3, 19);
            textBoxInput_TDA.Multiline = true;
            textBoxInput_TDA.Name = "textBoxInput_TDA";
            textBoxInput_TDA.ReadOnly = true;
            textBoxInput_TDA.Size = new Size(414, 395);
            textBoxInput_TDA.TabIndex = 0;
            // 
            // splitterResult_TDA
            // 
            splitterResult_TDA.Location = new Point(420, 144);
            splitterResult_TDA.Name = "splitterResult_TDA";
            splitterResult_TDA.Size = new Size(3, 417);
            splitterResult_TDA.TabIndex = 8;
            splitterResult_TDA.TabStop = false;
            // 
            // panelChartResult_TDA
            // 
            panelChartResult_TDA.Controls.Add(groupBoxOutput_TDA);
            panelChartResult_TDA.Dock = DockStyle.Fill;
            panelChartResult_TDA.Location = new Point(423, 144);
            panelChartResult_TDA.Name = "panelChartResult_TDA";
            panelChartResult_TDA.Size = new Size(441, 417);
            panelChartResult_TDA.TabIndex = 9;
            // 
            // toolTipOpen_TDA
            // 
            toolTipOpen_TDA.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpen_TDA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 561);
            Controls.Add(panelChartResult_TDA);
            Controls.Add(splitterResult_TDA);
            Controls.Add(panelTextBoxInput_TDA);
            Controls.Add(panelTop_TDA);
            MinimumSize = new Size(880, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 2 | Томилов Д.А.";
            groupBoxMain_TDA.ResumeLayout(false);
            groupBoxMain_TDA.PerformLayout();
            panelTop_TDA.ResumeLayout(false);
            groupBoxOutput_TDA.ResumeLayout(false);
            groupBoxOutput_TDA.PerformLayout();
            panelTextBoxInput_TDA.ResumeLayout(false);
            groupBoxInput_TDA.ResumeLayout(false);
            groupBoxInput_TDA.PerformLayout();
            panelChartResult_TDA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_TDA;
        private Button buttonDone_TDA;
        private Button buttonHelp_TDA;
        private TextBox textBoxCondition_TDA;
        private Button buttonOpen_TDA;
        private Panel panelTop_TDA;
        private GroupBox groupBoxOutput_TDA;
        private Panel panelTextBoxInput_TDA;
        private Splitter splitterResult_TDA;
        private Panel panelChartResult_TDA;
        private TextBox textBoxInput_TDA;
        private GroupBox groupBoxInput_TDA;
        private TextBox textBoxOutput_TDA;
        private OpenFileDialog openFileDialogTask_TDA;
        private ToolTip toolTipOpen_TDA;
    }
}
