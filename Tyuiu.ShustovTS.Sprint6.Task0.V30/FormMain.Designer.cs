
namespace Tyuiu.ShustovTS.Sprint6.Task1.V30
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCondition_ыеы = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_ыеы = new System.Windows.Forms.GroupBox();
            this.textBox_sts = new System.Windows.Forms.TextBox();
            this.textBoxVarA_sts = new System.Windows.Forms.TextBox();
            this.textBoxAnswer_STS = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_ыеы = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_sts = new System.Windows.Forms.GroupBox();
            this.textBoxStart_sts = new System.Windows.Forms.GroupBox();
            this.buttonReference_sts = new System.Windows.Forms.Button();
            this.buttonResult_sts = new System.Windows.Forms.Button();
            this.pictureBoxFormula_sts = new System.Windows.Forms.PictureBox();
            this.pictureBoxFo_sts = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_ыеы.SuspendLayout();
            this.groupBoxInputData_ыеы.SuspendLayout();
            this.textBoxEnd_sts.SuspendLayout();
            this.textBoxStart_sts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_sts)).BeginInit();
            this.pictureBoxFo_sts.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_ыеы
            // 
            this.groupBoxCondition_ыеы.Location = new System.Drawing.Point(12, 33);
            this.groupBoxCondition_ыеы.Name = "groupBoxCondition_ыеы";
            this.groupBoxCondition_ыеы.Size = new System.Drawing.Size(524, 244);
            this.groupBoxCondition_ыеы.TabIndex = 1;
            this.groupBoxCondition_ыеы.TabStop = false;
            this.groupBoxCondition_ыеы.Text = "Условие";
            // 
            // groupBoxOutputData_ыеы
            // 
            this.groupBoxOutputData_ыеы.Controls.Add(this.pictureBoxFo_sts);
            this.groupBoxOutputData_ыеы.Location = new System.Drawing.Point(588, 42);
            this.groupBoxOutputData_ыеы.Name = "groupBoxOutputData_ыеы";
            this.groupBoxOutputData_ыеы.Size = new System.Drawing.Size(200, 356);
            this.groupBoxOutputData_ыеы.TabIndex = 2;
            this.groupBoxOutputData_ыеы.TabStop = false;
            this.groupBoxOutputData_ыеы.Text = "Вывод данных";
            // 
            // textBox_sts
            // 
            this.textBox_sts.Location = new System.Drawing.Point(0, 18);
            this.textBox_sts.Name = "textBox_sts";
            this.textBox_sts.Size = new System.Drawing.Size(100, 20);
            this.textBox_sts.TabIndex = 4;
            // 
            // textBoxVarA_sts
            // 
            this.textBoxVarA_sts.Location = new System.Drawing.Point(6, 17);
            this.textBoxVarA_sts.Name = "textBoxVarA_sts";
            this.textBoxVarA_sts.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarA_sts.TabIndex = 5;
            // 
            // textBoxAnswer_STS
            // 
            this.textBoxAnswer_STS.Location = new System.Drawing.Point(12, 63);
            this.textBoxAnswer_STS.Name = "textBoxAnswer_STS";
            this.textBoxAnswer_STS.Size = new System.Drawing.Size(524, 214);
            this.textBoxAnswer_STS.TabIndex = 0;
            this.textBoxAnswer_STS.TabStop = false;
            this.textBoxAnswer_STS.Text = "Результат вывести в виде таблицы";
            // 
            // groupBoxInputData_ыеы
            // 
            this.groupBoxInputData_ыеы.Controls.Add(this.textBoxEnd_sts);
            this.groupBoxInputData_ыеы.Controls.Add(this.textBoxStart_sts);
            this.groupBoxInputData_ыеы.Location = new System.Drawing.Point(12, 350);
            this.groupBoxInputData_ыеы.Name = "groupBoxInputData_ыеы";
            this.groupBoxInputData_ыеы.Size = new System.Drawing.Size(279, 88);
            this.groupBoxInputData_ыеы.TabIndex = 6;
            this.groupBoxInputData_ыеы.TabStop = false;
            this.groupBoxInputData_ыеы.Text = "Ввод данных";
            // 
            // textBoxEnd_sts
            // 
            this.textBoxEnd_sts.Controls.Add(this.textBox_sts);
            this.textBoxEnd_sts.Location = new System.Drawing.Point(146, 44);
            this.textBoxEnd_sts.Name = "textBoxEnd_sts";
            this.textBoxEnd_sts.Size = new System.Drawing.Size(100, 44);
            this.textBoxEnd_sts.TabIndex = 0;
            this.textBoxEnd_sts.TabStop = false;
            this.textBoxEnd_sts.Text = "Конец шага:";
            // 
            // textBoxStart_sts
            // 
            this.textBoxStart_sts.Controls.Add(this.textBoxVarA_sts);
            this.textBoxStart_sts.Location = new System.Drawing.Point(0, 41);
            this.textBoxStart_sts.Name = "textBoxStart_sts";
            this.textBoxStart_sts.Size = new System.Drawing.Size(112, 47);
            this.textBoxStart_sts.TabIndex = 0;
            this.textBoxStart_sts.TabStop = false;
            this.textBoxStart_sts.Text = "Старт шага:";
            // 
            // buttonReference_sts
            // 
            this.buttonReference_sts.Location = new System.Drawing.Point(344, 391);
            this.buttonReference_sts.Name = "buttonReference_sts";
            this.buttonReference_sts.Size = new System.Drawing.Size(75, 37);
            this.buttonReference_sts.TabIndex = 0;
            this.buttonReference_sts.Text = "Справка";
            this.buttonReference_sts.UseVisualStyleBackColor = true;
            // 
            // buttonResult_sts
            // 
            this.buttonResult_sts.Location = new System.Drawing.Point(452, 394);
            this.buttonResult_sts.Name = "buttonResult_sts";
            this.buttonResult_sts.Size = new System.Drawing.Size(75, 34);
            this.buttonResult_sts.TabIndex = 7;
            this.buttonResult_sts.Text = "Выполнить";
            this.buttonResult_sts.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFormula_sts
            // 
            this.pictureBoxFormula_sts.Location = new System.Drawing.Point(0, 19);
            this.pictureBoxFormula_sts.Name = "pictureBoxFormula_sts";
            this.pictureBoxFormula_sts.Size = new System.Drawing.Size(187, 274);
            this.pictureBoxFormula_sts.TabIndex = 0;
            this.pictureBoxFormula_sts.TabStop = false;
            // 
            // pictureBoxFo_sts
            // 
            this.pictureBoxFo_sts.Controls.Add(this.pictureBoxFormula_sts);
            this.pictureBoxFo_sts.Location = new System.Drawing.Point(7, 51);
            this.pictureBoxFo_sts.Name = "pictureBoxFo_sts";
            this.pictureBoxFo_sts.Size = new System.Drawing.Size(200, 299);
            this.pictureBoxFo_sts.TabIndex = 0;
            this.pictureBoxFo_sts.TabStop = false;
            this.pictureBoxFo_sts.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResult_sts);
            this.Controls.Add(this.buttonReference_sts);
            this.Controls.Add(this.groupBoxInputData_ыеы);
            this.Controls.Add(this.textBoxAnswer_STS);
            this.Controls.Add(this.groupBoxOutputData_ыеы);
            this.Controls.Add(this.groupBoxCondition_ыеы);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxOutputData_ыеы.ResumeLayout(false);
            this.groupBoxInputData_ыеы.ResumeLayout(false);
            this.textBoxEnd_sts.ResumeLayout(false);
            this.textBoxEnd_sts.PerformLayout();
            this.textBoxStart_sts.ResumeLayout(false);
            this.textBoxStart_sts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_sts)).EndInit();
            this.pictureBoxFo_sts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCondition_ыеы;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ыеы;
        private System.Windows.Forms.TextBox textBox_sts;
        private System.Windows.Forms.TextBox textBoxVarA_sts;
        private System.Windows.Forms.GroupBox textBoxAnswer_STS;
        private System.Windows.Forms.GroupBox groupBoxInputData_ыеы;
        private System.Windows.Forms.GroupBox textBoxEnd_sts;
        private System.Windows.Forms.GroupBox textBoxStart_sts;
        private System.Windows.Forms.Button buttonReference_sts;
        private System.Windows.Forms.Button buttonResult_sts;
        private System.Windows.Forms.GroupBox pictureBoxFo_sts;
        private System.Windows.Forms.PictureBox pictureBoxFormula_sts;
    }
}

