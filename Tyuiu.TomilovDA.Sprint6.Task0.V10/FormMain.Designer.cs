namespace Tyuiu.TomilovDA.Sprint6.Task0.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxMain_TDA = new GroupBox();
            textBoxCondition_TDA = new TextBox();
            pictureBoxTask_TDA = new PictureBox();
            groupBoxInput_TDA = new GroupBox();
            labelVarX_TDA = new Label();
            textBoxVarX_TDA = new TextBox();
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
            groupBoxMain_TDA.Size = new Size(661, 255);
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
            textBoxCondition_TDA.Size = new Size(320, 229);
            textBoxCondition_TDA.TabIndex = 1;
            textBoxCondition_TDA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxTask_TDA
            // 
            pictureBoxTask_TDA.BackgroundImageLayout = ImageLayout.None;
            pictureBoxTask_TDA.Image = (Image)resources.GetObject("pictureBoxTask_TDA.Image");
            pictureBoxTask_TDA.Location = new Point(325, 22);
            pictureBoxTask_TDA.Name = "pictureBoxTask_TDA";
            pictureBoxTask_TDA.Size = new Size(330, 34);
            pictureBoxTask_TDA.TabIndex = 0;
            pictureBoxTask_TDA.TabStop = false;
            // 
            // groupBoxInput_TDA
            // 
            groupBoxInput_TDA.Controls.Add(labelVarX_TDA);
            groupBoxInput_TDA.Controls.Add(textBoxVarX_TDA);
            groupBoxInput_TDA.Location = new Point(18, 273);
            groupBoxInput_TDA.Name = "groupBoxInput_TDA";
            groupBoxInput_TDA.Size = new Size(214, 85);
            groupBoxInput_TDA.TabIndex = 1;
            groupBoxInput_TDA.TabStop = false;
            groupBoxInput_TDA.Text = "Ввод данных";
            // 
            // labelVarX_TDA
            // 
            labelVarX_TDA.AutoSize = true;
            labelVarX_TDA.Location = new Point(6, 26);
            labelVarX_TDA.Name = "labelVarX_TDA";
            labelVarX_TDA.Size = new Size(150, 15);
            labelVarX_TDA.TabIndex = 1;
            labelVarX_TDA.Text = "Введите целое значение X";
            // 
            // textBoxVarX_TDA
            // 
            textBoxVarX_TDA.Location = new Point(6, 44);
            textBoxVarX_TDA.Name = "textBoxVarX_TDA";
            textBoxVarX_TDA.Size = new Size(202, 23);
            textBoxVarX_TDA.TabIndex = 0;
            textBoxVarX_TDA.KeyPress += textBoxVarX_TDA_KeyPress;
            // 
            // groupBoxOutput_TDA
            // 
            groupBoxOutput_TDA.Controls.Add(labelResult_TDA);
            groupBoxOutput_TDA.Controls.Add(textBoxResult_TDA);
            groupBoxOutput_TDA.Location = new Point(503, 273);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(164, 85);
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
            textBoxResult_TDA.BackColor = SystemColors.Control;
            textBoxResult_TDA.Location = new Point(6, 44);
            textBoxResult_TDA.Name = "textBoxResult_TDA";
            textBoxResult_TDA.ReadOnly = true;
            textBoxResult_TDA.Size = new Size(152, 23);
            textBoxResult_TDA.TabIndex = 0;
            textBoxResult_TDA.TextChanged += textBoxResult_TDA_TextChanged;
            // 
            // buttonDone_TDA
            // 
            buttonDone_TDA.Location = new Point(509, 364);
            buttonDone_TDA.Name = "buttonDone_TDA";
            buttonDone_TDA.Size = new Size(152, 35);
            buttonDone_TDA.TabIndex = 3;
            buttonDone_TDA.Text = "Выполнить";
            buttonDone_TDA.UseVisualStyleBackColor = true;
            buttonDone_TDA.Click += buttonDone_TDA_Click;
            // 
            // buttonHelp_TDA
            // 
            buttonHelp_TDA.FlatStyle = FlatStyle.Flat;
            buttonHelp_TDA.Location = new Point(467, 364);
            buttonHelp_TDA.Name = "buttonHelp_TDA";
            buttonHelp_TDA.Size = new Size(36, 35);
            buttonHelp_TDA.TabIndex = 4;
            buttonHelp_TDA.Text = "?";
            buttonHelp_TDA.UseVisualStyleBackColor = true;
            buttonHelp_TDA.Click += buttonHelp_TDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 411);
            Controls.Add(buttonHelp_TDA);
            Controls.Add(buttonDone_TDA);
            Controls.Add(groupBoxOutput_TDA);
            Controls.Add(groupBoxInput_TDA);
            Controls.Add(groupBoxMain_TDA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 10 | Томилов Д.А.";
            Load += FormMain_Load;
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
        private TextBox textBoxVarX_TDA;
        private Label labelVarX_TDA;
        private Button buttonHelp_TDA;
        private TextBox textBoxCondition_TDA;
    }
}
