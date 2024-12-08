namespace Tyuiu.TomilovDA.Sprint6.Task4.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxMain_TDA = new GroupBox();
            pictureBoxFunction_TDA = new PictureBox();
            textBoxCondition_TDA = new TextBox();
            groupBoxInput_TDA = new GroupBox();
            labelVarEnd_TDA = new Label();
            textBoxVarEnd_TDA = new TextBox();
            labelVarStart_TDA = new Label();
            textBoxVarStart_TDA = new TextBox();
            buttonDone_TDA = new Button();
            buttonHelp_TDA = new Button();
            buttonSave_TDA = new Button();
            panelTop_TDA = new Panel();
            chartResult_TDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult_TDA = new TextBox();
            groupBoxOutput_TDA = new GroupBox();
            panelTextResult_TDA = new Panel();
            splitterResult_TDA = new Splitter();
            panelChartResult_TDA = new Panel();
            groupBoxMain_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_TDA).BeginInit();
            groupBoxInput_TDA.SuspendLayout();
            panelTop_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_TDA).BeginInit();
            groupBoxOutput_TDA.SuspendLayout();
            panelTextResult_TDA.SuspendLayout();
            panelChartResult_TDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_TDA
            // 
            groupBoxMain_TDA.AccessibleName = "Условие";
            groupBoxMain_TDA.Controls.Add(pictureBoxFunction_TDA);
            groupBoxMain_TDA.Controls.Add(textBoxCondition_TDA);
            groupBoxMain_TDA.Location = new Point(12, 5);
            groupBoxMain_TDA.Name = "groupBoxMain_TDA";
            groupBoxMain_TDA.Size = new Size(336, 143);
            groupBoxMain_TDA.TabIndex = 0;
            groupBoxMain_TDA.TabStop = false;
            groupBoxMain_TDA.Text = "Условие";
            // 
            // pictureBoxFunction_TDA
            // 
            pictureBoxFunction_TDA.Image = Properties.Resources.imgCondition5;
            pictureBoxFunction_TDA.Location = new Point(38, 96);
            pictureBoxFunction_TDA.Name = "pictureBoxFunction_TDA";
            pictureBoxFunction_TDA.Size = new Size(240, 40);
            pictureBoxFunction_TDA.TabIndex = 2;
            pictureBoxFunction_TDA.TabStop = false;
            // 
            // textBoxCondition_TDA
            // 
            textBoxCondition_TDA.BackColor = SystemColors.Menu;
            textBoxCondition_TDA.BorderStyle = BorderStyle.None;
            textBoxCondition_TDA.Location = new Point(6, 22);
            textBoxCondition_TDA.Multiline = true;
            textBoxCondition_TDA.Name = "textBoxCondition_TDA";
            textBoxCondition_TDA.ReadOnly = true;
            textBoxCondition_TDA.Size = new Size(320, 68);
            textBoxCondition_TDA.TabIndex = 1;
            textBoxCondition_TDA.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазоне.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл.\r\n";
            // 
            // groupBoxInput_TDA
            // 
            groupBoxInput_TDA.Controls.Add(labelVarEnd_TDA);
            groupBoxInput_TDA.Controls.Add(textBoxVarEnd_TDA);
            groupBoxInput_TDA.Controls.Add(labelVarStart_TDA);
            groupBoxInput_TDA.Controls.Add(textBoxVarStart_TDA);
            groupBoxInput_TDA.Location = new Point(357, 5);
            groupBoxInput_TDA.Name = "groupBoxInput_TDA";
            groupBoxInput_TDA.Size = new Size(257, 143);
            groupBoxInput_TDA.TabIndex = 1;
            groupBoxInput_TDA.TabStop = false;
            groupBoxInput_TDA.Text = "Ввод данных";
            // 
            // labelVarEnd_TDA
            // 
            labelVarEnd_TDA.AutoSize = true;
            labelVarEnd_TDA.Location = new Point(49, 86);
            labelVarEnd_TDA.Name = "labelVarEnd_TDA";
            labelVarEnd_TDA.Size = new Size(160, 15);
            labelVarEnd_TDA.TabIndex = 6;
            labelVarEnd_TDA.Text = "Введите конечное значение";
            // 
            // textBoxVarEnd_TDA
            // 
            textBoxVarEnd_TDA.Location = new Point(25, 104);
            textBoxVarEnd_TDA.Name = "textBoxVarEnd_TDA";
            textBoxVarEnd_TDA.Size = new Size(204, 23);
            textBoxVarEnd_TDA.TabIndex = 5;
            // 
            // labelVarStart_TDA
            // 
            labelVarStart_TDA.AutoSize = true;
            labelVarStart_TDA.Location = new Point(43, 22);
            labelVarStart_TDA.Name = "labelVarStart_TDA";
            labelVarStart_TDA.Size = new Size(166, 15);
            labelVarStart_TDA.TabIndex = 5;
            labelVarStart_TDA.Text = "Введите начальное значение";
            // 
            // textBoxVarStart_TDA
            // 
            textBoxVarStart_TDA.Location = new Point(25, 40);
            textBoxVarStart_TDA.Name = "textBoxVarStart_TDA";
            textBoxVarStart_TDA.Size = new Size(204, 23);
            textBoxVarStart_TDA.TabIndex = 4;
            // 
            // buttonDone_TDA
            // 
            buttonDone_TDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_TDA.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_TDA.Location = new Point(640, 17);
            buttonDone_TDA.Name = "buttonDone_TDA";
            buttonDone_TDA.Size = new Size(209, 35);
            buttonDone_TDA.TabIndex = 3;
            buttonDone_TDA.Text = "Выполнить";
            buttonDone_TDA.UseVisualStyleBackColor = false;
            buttonDone_TDA.Click += buttonDone_TDA_Click;
            // 
            // buttonHelp_TDA
            // 
            buttonHelp_TDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_TDA.BackColor = Color.FromArgb(192, 192, 255);
            buttonHelp_TDA.Location = new Point(640, 104);
            buttonHelp_TDA.Name = "buttonHelp_TDA";
            buttonHelp_TDA.Size = new Size(209, 37);
            buttonHelp_TDA.TabIndex = 4;
            buttonHelp_TDA.Text = "Справка";
            buttonHelp_TDA.UseVisualStyleBackColor = false;
            buttonHelp_TDA.Click += buttonHelp_TDA_Click;
            // 
            // buttonSave_TDA
            // 
            buttonSave_TDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_TDA.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_TDA.Location = new Point(640, 60);
            buttonSave_TDA.Name = "buttonSave_TDA";
            buttonSave_TDA.Size = new Size(209, 35);
            buttonSave_TDA.TabIndex = 5;
            buttonSave_TDA.Text = "Сохранить";
            buttonSave_TDA.UseVisualStyleBackColor = false;
            buttonSave_TDA.Click += buttonSave_TDA_Click;
            // 
            // panelTop_TDA
            // 
            panelTop_TDA.Controls.Add(groupBoxMain_TDA);
            panelTop_TDA.Controls.Add(buttonHelp_TDA);
            panelTop_TDA.Controls.Add(buttonSave_TDA);
            panelTop_TDA.Controls.Add(groupBoxInput_TDA);
            panelTop_TDA.Controls.Add(buttonDone_TDA);
            panelTop_TDA.Dock = DockStyle.Top;
            panelTop_TDA.Location = new Point(0, 0);
            panelTop_TDA.Name = "panelTop_TDA";
            panelTop_TDA.Size = new Size(864, 155);
            panelTop_TDA.TabIndex = 6;
            // 
            // chartResult_TDA
            // 
            chartArea2.Name = "ChartArea1";
            chartResult_TDA.ChartAreas.Add(chartArea2);
            chartResult_TDA.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartResult_TDA.Legends.Add(legend2);
            chartResult_TDA.Location = new Point(0, 0);
            chartResult_TDA.Name = "chartResult_TDA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "F(X)";
            chartResult_TDA.Series.Add(series2);
            chartResult_TDA.Size = new Size(552, 406);
            chartResult_TDA.TabIndex = 3;
            chartResult_TDA.Text = "chart_Result_TDA";
            title2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title2.Name = "TitleFunction";
            title2.Text = "График функции F(X)";
            chartResult_TDA.Titles.Add(title2);
            // 
            // textBoxResult_TDA
            // 
            textBoxResult_TDA.BackColor = SystemColors.ControlLightLight;
            textBoxResult_TDA.Dock = DockStyle.Fill;
            textBoxResult_TDA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_TDA.Location = new Point(3, 19);
            textBoxResult_TDA.Multiline = true;
            textBoxResult_TDA.Name = "textBoxResult_TDA";
            textBoxResult_TDA.ReadOnly = true;
            textBoxResult_TDA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_TDA.Size = new Size(303, 384);
            textBoxResult_TDA.TabIndex = 2;
            textBoxResult_TDA.TextChanged += textBoxResult_TDA_TextChanged;
            // 
            // groupBoxOutput_TDA
            // 
            groupBoxOutput_TDA.Controls.Add(textBoxResult_TDA);
            groupBoxOutput_TDA.Dock = DockStyle.Fill;
            groupBoxOutput_TDA.Location = new Point(0, 0);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(309, 406);
            groupBoxOutput_TDA.TabIndex = 2;
            groupBoxOutput_TDA.TabStop = false;
            groupBoxOutput_TDA.Text = "Вывод данных";
            // 
            // panelTextResult_TDA
            // 
            panelTextResult_TDA.Controls.Add(groupBoxOutput_TDA);
            panelTextResult_TDA.Dock = DockStyle.Left;
            panelTextResult_TDA.Location = new Point(0, 155);
            panelTextResult_TDA.Name = "panelTextResult_TDA";
            panelTextResult_TDA.Size = new Size(309, 406);
            panelTextResult_TDA.TabIndex = 7;
            // 
            // splitterResult_TDA
            // 
            splitterResult_TDA.Location = new Point(309, 155);
            splitterResult_TDA.Name = "splitterResult_TDA";
            splitterResult_TDA.Size = new Size(3, 406);
            splitterResult_TDA.TabIndex = 8;
            splitterResult_TDA.TabStop = false;
            // 
            // panelChartResult_TDA
            // 
            panelChartResult_TDA.Controls.Add(chartResult_TDA);
            panelChartResult_TDA.Dock = DockStyle.Fill;
            panelChartResult_TDA.Location = new Point(312, 155);
            panelChartResult_TDA.Name = "panelChartResult_TDA";
            panelChartResult_TDA.Size = new Size(552, 406);
            panelChartResult_TDA.TabIndex = 9;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 561);
            Controls.Add(panelChartResult_TDA);
            Controls.Add(splitterResult_TDA);
            Controls.Add(panelTextResult_TDA);
            Controls.Add(panelTop_TDA);
            MinimumSize = new Size(880, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 14 | Томилов Д.А.";
            groupBoxMain_TDA.ResumeLayout(false);
            groupBoxMain_TDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_TDA).EndInit();
            groupBoxInput_TDA.ResumeLayout(false);
            groupBoxInput_TDA.PerformLayout();
            panelTop_TDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_TDA).EndInit();
            groupBoxOutput_TDA.ResumeLayout(false);
            groupBoxOutput_TDA.PerformLayout();
            panelTextResult_TDA.ResumeLayout(false);
            panelChartResult_TDA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_TDA;
        private GroupBox groupBoxInput_TDA;
        private Button buttonDone_TDA;
        private Button buttonHelp_TDA;
        private TextBox textBoxCondition_TDA;
        private PictureBox pictureBoxFunction_TDA;
        private Label labelVarStart_TDA;
        private TextBox textBoxVarStart_TDA;
        private Label labelVarEnd_TDA;
        private TextBox textBoxVarEnd_TDA;
        private Button buttonSave_TDA;
        private Panel panelTop_TDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_TDA;
        private TextBox textBoxResult_TDA;
        private GroupBox groupBoxOutput_TDA;
        private Panel panelTextResult_TDA;
        private Splitter splitterResult_TDA;
        private Panel panelChartResult_TDA;
    }
}
