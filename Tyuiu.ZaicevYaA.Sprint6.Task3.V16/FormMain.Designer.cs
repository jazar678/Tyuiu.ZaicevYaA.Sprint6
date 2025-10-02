namespace Tyuiu.ZaicevYaA.Sprint6.Task3.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop_ZYA = new Panel();
            labelCondition_ZYA = new Label();
            groupBoxInput_ZYA = new GroupBox();
            dataGridViewInput_ZYA = new DataGridView();
            groupBoxOutput_ZYA = new GroupBox();
            dataGridViewOutput_ZYA = new DataGridView();
            panelBottom_ZYA = new Panel();
            buttonHelp_ZYA = new Button();
            buttonDone_ZYA = new Button();
            panelTop_ZYA.SuspendLayout();
            groupBoxInput_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_ZYA).BeginInit();
            groupBoxOutput_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_ZYA).BeginInit();
            panelBottom_ZYA.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_ZYA
            // 
            panelTop_ZYA.Controls.Add(labelCondition_ZYA);
            panelTop_ZYA.Dock = DockStyle.Top;
            panelTop_ZYA.Location = new Point(0, 0);
            panelTop_ZYA.Name = "panelTop_ZYA";
            panelTop_ZYA.Size = new Size(706, 56);
            panelTop_ZYA.TabIndex = 0;
            // 
            // labelCondition_ZYA
            // 
            labelCondition_ZYA.AutoSize = true;
            labelCondition_ZYA.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_ZYA.Location = new Point(10, 19);
            labelCondition_ZYA.Name = "labelCondition_ZYA";
            labelCondition_ZYA.Size = new Size(548, 17);
            labelCondition_ZYA.TabIndex = 0;
            labelCondition_ZYA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.";
            // 
            // groupBoxInput_ZYA
            // 
            groupBoxInput_ZYA.Controls.Add(dataGridViewInput_ZYA);
            groupBoxInput_ZYA.Location = new Point(10, 75);
            groupBoxInput_ZYA.Name = "groupBoxInput_ZYA";
            groupBoxInput_ZYA.Size = new Size(332, 281);
            groupBoxInput_ZYA.TabIndex = 1;
            groupBoxInput_ZYA.TabStop = false;
            groupBoxInput_ZYA.Text = "Ввод:";
            // 
            // dataGridViewInput_ZYA
            // 
            dataGridViewInput_ZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_ZYA.Location = new Point(5, 20);
            dataGridViewInput_ZYA.Name = "dataGridViewInput_ZYA";
            dataGridViewInput_ZYA.RowHeadersWidth = 51;
            dataGridViewInput_ZYA.RowTemplate.Height = 24;
            dataGridViewInput_ZYA.Size = new Size(322, 256);
            dataGridViewInput_ZYA.TabIndex = 0;
            // 
            // groupBoxOutput_ZYA
            // 
            groupBoxOutput_ZYA.Controls.Add(dataGridViewOutput_ZYA);
            groupBoxOutput_ZYA.Location = new Point(357, 75);
            groupBoxOutput_ZYA.Name = "groupBoxOutput_ZYA";
            groupBoxOutput_ZYA.Size = new Size(332, 281);
            groupBoxOutput_ZYA.TabIndex = 2;
            groupBoxOutput_ZYA.TabStop = false;
            groupBoxOutput_ZYA.Text = "Вывод:";
            // 
            // dataGridViewOutput_ZYA
            // 
            dataGridViewOutput_ZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_ZYA.Location = new Point(5, 20);
            dataGridViewOutput_ZYA.Name = "dataGridViewOutput_ZYA";
            dataGridViewOutput_ZYA.RowHeadersWidth = 51;
            dataGridViewOutput_ZYA.RowTemplate.Height = 24;
            dataGridViewOutput_ZYA.Size = new Size(322, 256);
            dataGridViewOutput_ZYA.TabIndex = 0;
            // 
            // panelBottom_ZYA
            // 
            panelBottom_ZYA.Controls.Add(buttonHelp_ZYA);
            panelBottom_ZYA.Controls.Add(buttonDone_ZYA);
            panelBottom_ZYA.Dock = DockStyle.Bottom;
            panelBottom_ZYA.Location = new Point(0, 366);
            panelBottom_ZYA.Name = "panelBottom_ZYA";
            panelBottom_ZYA.Size = new Size(706, 56);
            panelBottom_ZYA.TabIndex = 3;
            // 
            // buttonHelp_ZYA
            // 
            buttonHelp_ZYA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_ZYA.Location = new Point(620, 14);
            buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            buttonHelp_ZYA.Size = new Size(70, 28);
            buttonHelp_ZYA.TabIndex = 1;
            buttonHelp_ZYA.Text = "Справка";
            buttonHelp_ZYA.UseVisualStyleBackColor = false;
            buttonHelp_ZYA.Click += buttonHelp_ZYA_Click;
            // 
            // buttonDone_ZYA
            // 
            buttonDone_ZYA.BackColor = Color.DarkGreen;
            buttonDone_ZYA.Location = new Point(536, 14);
            buttonDone_ZYA.Name = "buttonDone_ZYA";
            buttonDone_ZYA.Size = new Size(70, 28);
            buttonDone_ZYA.TabIndex = 0;
            buttonDone_ZYA.Text = "Выполнить";
            buttonDone_ZYA.UseVisualStyleBackColor = false;
            buttonDone_ZYA.Click += buttonDone_ZYA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 422);
            Controls.Add(panelBottom_ZYA);
            Controls.Add(groupBoxOutput_ZYA);
            Controls.Add(groupBoxInput_ZYA);
            Controls.Add(panelTop_ZYA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 16 | Зайцев Я.А.";
            Load += FormMain_Load;
            panelTop_ZYA.ResumeLayout(false);
            panelTop_ZYA.PerformLayout();
            groupBoxInput_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_ZYA).EndInit();
            groupBoxOutput_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_ZYA).EndInit();
            panelBottom_ZYA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZYA;
        private System.Windows.Forms.Label labelCondition_ZYA;
        private System.Windows.Forms.GroupBox groupBoxInput_ZYA;
        private System.Windows.Forms.DataGridView dataGridViewInput_ZYA;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZYA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_ZYA;
        private System.Windows.Forms.Panel panelBottom_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
    }
}