namespace Tyuiu.TomilovDA.Sprint6.Task3.V6
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
            groupBoxMain_TDA = new GroupBox();
            textBoxCondition_TDA = new TextBox();
            groupBoxInput_TDA = new GroupBox();
            dataGridViewMatrix_TDA = new DataGridView();
            groupBoxOutput_TDA = new GroupBox();
            dataGridViewResult_TDA = new DataGridView();
            labelResult_TDA = new Label();
            buttonDone_TDA = new Button();
            buttonHelp_TDA = new Button();
            groupBoxMain_TDA.SuspendLayout();
            groupBoxInput_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_TDA).BeginInit();
            groupBoxOutput_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_TDA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain_TDA
            // 
            groupBoxMain_TDA.AccessibleName = "Условие";
            groupBoxMain_TDA.Controls.Add(textBoxCondition_TDA);
            groupBoxMain_TDA.Location = new Point(12, 12);
            groupBoxMain_TDA.Name = "groupBoxMain_TDA";
            groupBoxMain_TDA.Size = new Size(336, 346);
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
            textBoxCondition_TDA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.\r\n\r\nРезультат вывести в DataGridView.\r\n";
            // 
            // groupBoxInput_TDA
            // 
            groupBoxInput_TDA.Controls.Add(dataGridViewMatrix_TDA);
            groupBoxInput_TDA.Location = new Point(354, 12);
            groupBoxInput_TDA.Name = "groupBoxInput_TDA";
            groupBoxInput_TDA.Size = new Size(257, 346);
            groupBoxInput_TDA.TabIndex = 1;
            groupBoxInput_TDA.TabStop = false;
            groupBoxInput_TDA.Text = "Ввод данных";
            // 
            // dataGridViewMatrix_TDA
            // 
            dataGridViewMatrix_TDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_TDA.ColumnHeadersVisible = false;
            dataGridViewMatrix_TDA.Location = new Point(22, 44);
            dataGridViewMatrix_TDA.Name = "dataGridViewMatrix_TDA";
            dataGridViewMatrix_TDA.RowHeadersVisible = false;
            dataGridViewMatrix_TDA.Size = new Size(219, 284);
            dataGridViewMatrix_TDA.TabIndex = 3;
            // 
            // groupBoxOutput_TDA
            // 
            groupBoxOutput_TDA.Controls.Add(dataGridViewResult_TDA);
            groupBoxOutput_TDA.Controls.Add(labelResult_TDA);
            groupBoxOutput_TDA.Location = new Point(620, 12);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(241, 346);
            groupBoxOutput_TDA.TabIndex = 2;
            groupBoxOutput_TDA.TabStop = false;
            groupBoxOutput_TDA.Text = "Вывод данных";
            // 
            // dataGridViewResult_TDA
            // 
            dataGridViewResult_TDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_TDA.ColumnHeadersVisible = false;
            dataGridViewResult_TDA.Location = new Point(16, 44);
            dataGridViewResult_TDA.Name = "dataGridViewResult_TDA";
            dataGridViewResult_TDA.RowHeadersVisible = false;
            dataGridViewResult_TDA.Size = new Size(219, 284);
            dataGridViewResult_TDA.TabIndex = 2;
            // 
            // labelResult_TDA
            // 
            labelResult_TDA.AutoSize = true;
            labelResult_TDA.Location = new Point(16, 26);
            labelResult_TDA.Name = "labelResult_TDA";
            labelResult_TDA.Size = new Size(63, 15);
            labelResult_TDA.TabIndex = 1;
            labelResult_TDA.Text = "Результат:";
            // 
            // buttonDone_TDA
            // 
            buttonDone_TDA.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_TDA.Location = new Point(709, 364);
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
            buttonHelp_TDA.Location = new Point(663, 364);
            buttonHelp_TDA.Name = "buttonHelp_TDA";
            buttonHelp_TDA.Size = new Size(36, 35);
            buttonHelp_TDA.TabIndex = 4;
            buttonHelp_TDA.Text = "?";
            buttonHelp_TDA.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 411);
            Controls.Add(buttonHelp_TDA);
            Controls.Add(buttonDone_TDA);
            Controls.Add(groupBoxOutput_TDA);
            Controls.Add(groupBoxInput_TDA);
            Controls.Add(groupBoxMain_TDA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Томилов Д.А.";
            Load += FormMain_Load;
            groupBoxMain_TDA.ResumeLayout(false);
            groupBoxMain_TDA.PerformLayout();
            groupBoxInput_TDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_TDA).EndInit();
            groupBoxOutput_TDA.ResumeLayout(false);
            groupBoxOutput_TDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_TDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_TDA;
        private GroupBox groupBoxInput_TDA;
        private GroupBox groupBoxOutput_TDA;
        private Label labelResult_TDA;
        private Button buttonDone_TDA;
        private Button buttonHelp_TDA;
        private TextBox textBoxCondition_TDA;
        private DataGridView dataGridViewResult_TDA;
        private DataGridView dataGridViewMatrix_TDA;
    }
}
