namespace Tyuiu.TomilovDA.Sprint6.Task1.V10
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
            pictureBoxTask_TDA = new PictureBox();
            groupBoxInput_TDA = new GroupBox();
            labelVarEnd_TDA = new Label();
            textBoxVarEnd_TDA = new TextBox();
            labelVarStart_TDA = new Label();
            textBoxVarStart_TDA = new TextBox();
            groupBoxOutput_TDA = new GroupBox();
            labelResult_TDA = new Label();
            textBoxResult_TDA = new TextBox();
            buttonDone_TDA = new Button();
            buttonHelp_TDA = new Button();
            groupBoxMain_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_TDA).BeginInit();
            groupBoxInput_TDA.SuspendLayout();
            groupBoxOutput_TDA.SuspendLayout();
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
            pictureBoxTask_TDA.Image = Properties.Resources.imgCondition2;
            pictureBoxTask_TDA.Location = new Point(12, 206);
            pictureBoxTask_TDA.Name = "pictureBoxTask_TDA";
            pictureBoxTask_TDA.Size = new Size(363, 43);
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
            groupBoxOutput_TDA.Controls.Add(labelResult_TDA);
            groupBoxOutput_TDA.Controls.Add(textBoxResult_TDA);
            groupBoxOutput_TDA.Location = new Point(473, 12);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(248, 346);
            groupBoxOutput_TDA.TabIndex = 2;
            groupBoxOutput_TDA.TabStop = false;
            groupBoxOutput_TDA.Text = "Вывод данных";
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
            // textBoxResult_TDA
            // 
            textBoxResult_TDA.BackColor = SystemColors.ControlLightLight;
            textBoxResult_TDA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_TDA.Location = new Point(6, 44);
            textBoxResult_TDA.Multiline = true;
            textBoxResult_TDA.Name = "textBoxResult_TDA";
            textBoxResult_TDA.ReadOnly = true;
            textBoxResult_TDA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_TDA.Size = new Size(242, 284);
            textBoxResult_TDA.TabIndex = 0;
            // 
            // buttonDone_TDA
            // 
            buttonDone_TDA.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_TDA.Location = new Point(569, 364);
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
            buttonHelp_TDA.Location = new Point(506, 364);
            buttonHelp_TDA.Name = "buttonHelp_TDA";
            buttonHelp_TDA.Size = new Size(36, 35);
            buttonHelp_TDA.TabIndex = 4;
            buttonHelp_TDA.Text = "?";
            buttonHelp_TDA.UseVisualStyleBackColor = false;
            buttonHelp_TDA.Click += buttonHelp_TDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 411);
            Controls.Add(buttonHelp_TDA);
            Controls.Add(buttonDone_TDA);
            Controls.Add(groupBoxOutput_TDA);
            Controls.Add(groupBoxInput_TDA);
            Controls.Add(groupBoxMain_TDA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 10 | Томилов Д.А.";
            groupBoxMain_TDA.ResumeLayout(false);
            groupBoxMain_TDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_TDA).EndInit();
            groupBoxInput_TDA.ResumeLayout(false);
            groupBoxInput_TDA.PerformLayout();
            groupBoxOutput_TDA.ResumeLayout(false);
            groupBoxOutput_TDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_TDA;
        private PictureBox pictureBoxTask_TDA;
        private GroupBox groupBoxInput_TDA;
        private GroupBox groupBoxOutput_TDA;
        private Label labelResult_TDA;
        private TextBox textBoxResult_TDA;
        private Button buttonDone_TDA;
        private TextBox textBoxVarStart_TDA;
        private Label labelVarStart_TDA;
        private Button buttonHelp_TDA;
        private TextBox textBoxCondition_TDA;
        private Label labelVarEnd_TDA;
        private TextBox textBoxVarEnd_TDA;
    }
}
