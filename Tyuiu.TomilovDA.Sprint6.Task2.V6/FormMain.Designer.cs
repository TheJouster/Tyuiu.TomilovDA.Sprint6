namespace Tyuiu.TomilovDA.Sprint6.Task2.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxMain_TDA = new GroupBox();
            textBoxCondition_TDA = new TextBox();
            pictureBoxTask_TDA = new PictureBox();
            groupBoxInput_TDA = new GroupBox();
            labelVarEnd_TDA = new Label();
            textBoxVarEnd_TDA = new TextBox();
            labelVarStart_TDA = new Label();
            textBoxVarStart_TDA = new TextBox();
            groupBoxOutput_TDA = new GroupBox();
            dataGridViewFunction_TDA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            labelResult_TDA = new Label();
            buttonDone_TDA = new Button();
            buttonHelp_TDA = new Button();
            chartFunction_TDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxMain_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_TDA).BeginInit();
            groupBoxInput_TDA.SuspendLayout();
            groupBoxOutput_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_TDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_TDA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain_TDA
            // 
            groupBoxMain_TDA.AccessibleName = "Условие";
            groupBoxMain_TDA.Controls.Add(textBoxCondition_TDA);
            groupBoxMain_TDA.Controls.Add(pictureBoxTask_TDA);
            groupBoxMain_TDA.Location = new Point(12, 12);
            groupBoxMain_TDA.Name = "groupBoxMain_TDA";
            groupBoxMain_TDA.Size = new Size(455, 255);
            groupBoxMain_TDA.TabIndex = 0;
            groupBoxMain_TDA.TabStop = false;
            groupBoxMain_TDA.Text = "Условие";
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
            textBoxCondition_TDA.Text = "Вычислить выражение по формуле на заданном диапазоне";
            // 
            // pictureBoxTask_TDA
            // 
            pictureBoxTask_TDA.BackgroundImageLayout = ImageLayout.None;
            pictureBoxTask_TDA.Image = Properties.Resources.imgCondition3;
            pictureBoxTask_TDA.Location = new Point(12, 206);
            pictureBoxTask_TDA.Name = "pictureBoxTask_TDA";
            pictureBoxTask_TDA.Size = new Size(314, 43);
            pictureBoxTask_TDA.TabIndex = 0;
            pictureBoxTask_TDA.TabStop = false;
            // 
            // groupBoxInput_TDA
            // 
            groupBoxInput_TDA.Controls.Add(labelVarEnd_TDA);
            groupBoxInput_TDA.Controls.Add(textBoxVarEnd_TDA);
            groupBoxInput_TDA.Controls.Add(labelVarStart_TDA);
            groupBoxInput_TDA.Controls.Add(textBoxVarStart_TDA);
            groupBoxInput_TDA.Location = new Point(18, 273);
            groupBoxInput_TDA.Name = "groupBoxInput_TDA";
            groupBoxInput_TDA.Size = new Size(449, 85);
            groupBoxInput_TDA.TabIndex = 1;
            groupBoxInput_TDA.TabStop = false;
            groupBoxInput_TDA.Text = "Ввод данных";
            // 
            // labelVarEnd_TDA
            // 
            labelVarEnd_TDA.AutoSize = true;
            labelVarEnd_TDA.Location = new Point(263, 26);
            labelVarEnd_TDA.Name = "labelVarEnd_TDA";
            labelVarEnd_TDA.Size = new Size(160, 15);
            labelVarEnd_TDA.TabIndex = 3;
            labelVarEnd_TDA.Text = "Введите конечное значение";
            // 
            // textBoxVarEnd_TDA
            // 
            textBoxVarEnd_TDA.Location = new Point(239, 44);
            textBoxVarEnd_TDA.Name = "textBoxVarEnd_TDA";
            textBoxVarEnd_TDA.Size = new Size(204, 23);
            textBoxVarEnd_TDA.TabIndex = 2;
            // 
            // labelVarStart_TDA
            // 
            labelVarStart_TDA.AutoSize = true;
            labelVarStart_TDA.Location = new Point(24, 26);
            labelVarStart_TDA.Name = "labelVarStart_TDA";
            labelVarStart_TDA.Size = new Size(166, 15);
            labelVarStart_TDA.TabIndex = 1;
            labelVarStart_TDA.Text = "Введите начальное значение";
            // 
            // textBoxVarStart_TDA
            // 
            textBoxVarStart_TDA.Location = new Point(6, 44);
            textBoxVarStart_TDA.Name = "textBoxVarStart_TDA";
            textBoxVarStart_TDA.Size = new Size(204, 23);
            textBoxVarStart_TDA.TabIndex = 0;
            // 
            // groupBoxOutput_TDA
            // 
            groupBoxOutput_TDA.Controls.Add(dataGridViewFunction_TDA);
            groupBoxOutput_TDA.Controls.Add(labelResult_TDA);
            groupBoxOutput_TDA.Location = new Point(473, 12);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(546, 346);
            groupBoxOutput_TDA.TabIndex = 2;
            groupBoxOutput_TDA.TabStop = false;
            groupBoxOutput_TDA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_TDA
            // 
            dataGridViewFunction_TDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_TDA.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewFunction_TDA.Location = new Point(6, 44);
            dataGridViewFunction_TDA.Name = "dataGridViewFunction_TDA";
            dataGridViewFunction_TDA.RowHeadersVisible = false;
            dataGridViewFunction_TDA.Size = new Size(169, 284);
            dataGridViewFunction_TDA.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 75;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.Name = "FX";
            FX.ReadOnly = true;
            FX.Width = 75;
            // 
            // labelResult_TDA
            // 
            labelResult_TDA.AutoSize = true;
            labelResult_TDA.Location = new Point(6, 26);
            labelResult_TDA.Name = "labelResult_TDA";
            labelResult_TDA.Size = new Size(63, 15);
            labelResult_TDA.TabIndex = 1;
            labelResult_TDA.Text = "Результат:";
            // 
            // buttonDone_TDA
            // 
            buttonDone_TDA.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_TDA.Location = new Point(867, 364);
            buttonDone_TDA.Name = "buttonDone_TDA";
            buttonDone_TDA.Size = new Size(152, 35);
            buttonDone_TDA.TabIndex = 3;
            buttonDone_TDA.Text = "Выполнить";
            buttonDone_TDA.UseVisualStyleBackColor = false;
            buttonDone_TDA.Click += buttonDone_TDA_Click;
            // 
            // buttonHelp_TDA
            // 
            buttonHelp_TDA.BackColor = Color.FromArgb(192, 192, 255);
            buttonHelp_TDA.FlatStyle = FlatStyle.Flat;
            buttonHelp_TDA.Location = new Point(825, 364);
            buttonHelp_TDA.Name = "buttonHelp_TDA";
            buttonHelp_TDA.Size = new Size(36, 35);
            buttonHelp_TDA.TabIndex = 4;
            buttonHelp_TDA.Text = "?";
            buttonHelp_TDA.UseVisualStyleBackColor = false;
            buttonHelp_TDA.Click += buttonHelp_TDA_Click;
            // 
            // chartFunction_TDA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_TDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_TDA.Legends.Add(legend1);
            chartFunction_TDA.Location = new Point(654, 34);
            chartFunction_TDA.Name = "chartFunction_TDA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "F(X)";
            chartFunction_TDA.Series.Add(series1);
            chartFunction_TDA.Size = new Size(359, 306);
            chartFunction_TDA.TabIndex = 5;
            chartFunction_TDA.Text = "График";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 411);
            Controls.Add(chartFunction_TDA);
            Controls.Add(buttonHelp_TDA);
            Controls.Add(buttonDone_TDA);
            Controls.Add(groupBoxOutput_TDA);
            Controls.Add(groupBoxInput_TDA);
            Controls.Add(groupBoxMain_TDA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 6 | Томилов Д.А.";
            groupBoxMain_TDA.ResumeLayout(false);
            groupBoxMain_TDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_TDA).EndInit();
            groupBoxInput_TDA.ResumeLayout(false);
            groupBoxInput_TDA.PerformLayout();
            groupBoxOutput_TDA.ResumeLayout(false);
            groupBoxOutput_TDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_TDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_TDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_TDA;
        private PictureBox pictureBoxTask_TDA;
        private GroupBox groupBoxInput_TDA;
        private GroupBox groupBoxOutput_TDA;
        private Label labelResult_TDA;
        private Button buttonDone_TDA;
        private TextBox textBoxVarStart_TDA;
        private Label labelVarStart_TDA;
        private Button buttonHelp_TDA;
        private TextBox textBoxCondition_TDA;
        private Label labelVarEnd_TDA;
        private TextBox textBoxVarEnd_TDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_TDA;
        private DataGridView dataGridViewFunction_TDA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
    }
}
