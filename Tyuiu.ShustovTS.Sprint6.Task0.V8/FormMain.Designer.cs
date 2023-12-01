using Tyuiu.ShustovTS.Sprint6.Task0.V8.Lib;
namespace Tyuiu.ShustovTS.Sprint6.Task0.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCondition_sts = new System.Windows.Forms.GroupBox();
            this.textBoxTask_sts = new System.Windows.Forms.TextBox();
            this.buttonDone_sts = new System.Windows.Forms.Button();
            this.buttonClic_sts = new System.Windows.Forms.Button();
            this.groupBoxInput_sts = new System.Windows.Forms.GroupBox();
            this.groupBoxVariableZ_sts = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxVariableY_sts = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxVariable_sts = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBoxConcludion_sts = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_sts = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCondition_sts.SuspendLayout();
            this.groupBoxInput_sts.SuspendLayout();
            this.groupBoxVariableZ_sts.SuspendLayout();
            this.groupBoxVariableY_sts.SuspendLayout();
            this.groupBoxVariable_sts.SuspendLayout();
            this.groupBoxConcludion_sts.SuspendLayout();
            this.groupBoxResult_sts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxCondition_sts
            // 
            this.groupBoxCondition_sts.Controls.Add(this.textBoxTask_sts);
            this.groupBoxCondition_sts.Controls.Add(this.pictureBox1);
            this.groupBoxCondition_sts.Location = new System.Drawing.Point(13, 12);
            this.groupBoxCondition_sts.Name = "groupBoxCondition_sts";
            this.groupBoxCondition_sts.Size = new System.Drawing.Size(776, 215);
            this.groupBoxCondition_sts.TabIndex = 1;
            this.groupBoxCondition_sts.TabStop = false;
            this.groupBoxCondition_sts.Text = "Условие";
            // 
            // textBoxTask_sts
            // 
            this.textBoxTask_sts.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_sts.Multiline = true;
            this.textBoxTask_sts.Name = "textBoxTask_sts";
            this.textBoxTask_sts.Size = new System.Drawing.Size(585, 166);
            this.textBoxTask_sts.TabIndex = 0;
            this.textBoxTask_sts.Text = "Вычислить выражение по формуле";
            // 
            // buttonDone_sts
            // 
            this.buttonDone_sts.Location = new System.Drawing.Point(673, 390);
            this.buttonDone_sts.Name = "buttonDone_sts";
            this.buttonDone_sts.Size = new System.Drawing.Size(101, 41);
            this.buttonDone_sts.TabIndex = 2;
            this.buttonDone_sts.Text = "Выполнить";
            this.buttonDone_sts.UseVisualStyleBackColor = true;
            // 
            // buttonClic_sts
            // 
            this.buttonClic_sts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClic_sts.Location = new System.Drawing.Point(610, 399);
            this.buttonClic_sts.Name = "buttonClic_sts";
            this.buttonClic_sts.Size = new System.Drawing.Size(30, 23);
            this.buttonClic_sts.TabIndex = 3;
            this.buttonClic_sts.Text = "?";
            this.buttonClic_sts.UseVisualStyleBackColor = true;
            // 
            // groupBoxInput_sts
            // 
            this.groupBoxInput_sts.Controls.Add(this.groupBoxVariableZ_sts);
            this.groupBoxInput_sts.Controls.Add(this.groupBoxVariableY_sts);
            this.groupBoxInput_sts.Controls.Add(this.groupBoxVariable_sts);
            this.groupBoxInput_sts.Location = new System.Drawing.Point(13, 318);
            this.groupBoxInput_sts.Name = "groupBoxInput_sts";
            this.groupBoxInput_sts.Size = new System.Drawing.Size(535, 120);
            this.groupBoxInput_sts.TabIndex = 4;
            this.groupBoxInput_sts.TabStop = false;
            this.groupBoxInput_sts.Text = "Ввод данных";
            // 
            // groupBoxVariableZ_sts
            // 
            this.groupBoxVariableZ_sts.Controls.Add(this.textBox3);
            this.groupBoxVariableZ_sts.Location = new System.Drawing.Point(374, 40);
            this.groupBoxVariableZ_sts.Name = "groupBoxVariableZ_sts";
            this.groupBoxVariableZ_sts.Size = new System.Drawing.Size(138, 52);
            this.groupBoxVariableZ_sts.TabIndex = 5;
            this.groupBoxVariableZ_sts.TabStop = false;
            this.groupBoxVariableZ_sts.Tag = "";
            this.groupBoxVariableZ_sts.Text = "Переменная Z:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 1;
            // 
            // groupBoxVariableY_sts
            // 
            this.groupBoxVariableY_sts.Controls.Add(this.textBox2);
            this.groupBoxVariableY_sts.Location = new System.Drawing.Point(205, 40);
            this.groupBoxVariableY_sts.Name = "groupBoxVariableY_sts";
            this.groupBoxVariableY_sts.Size = new System.Drawing.Size(124, 52);
            this.groupBoxVariableY_sts.TabIndex = 4;
            this.groupBoxVariableY_sts.TabStop = false;
            this.groupBoxVariableY_sts.Text = "Переменная Y:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 0;
            // 
            // groupBoxVariable_sts
            // 
            this.groupBoxVariable_sts.Controls.Add(this.textBox4);
            this.groupBoxVariable_sts.Location = new System.Drawing.Point(26, 40);
            this.groupBoxVariable_sts.Name = "groupBoxVariable_sts";
            this.groupBoxVariable_sts.Size = new System.Drawing.Size(125, 52);
            this.groupBoxVariable_sts.TabIndex = 3;
            this.groupBoxVariable_sts.TabStop = false;
            this.groupBoxVariable_sts.Text = "Переменная x:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 24);
            this.textBox4.TabIndex = 2;
            // 
            // groupBoxConcludion_sts
            // 
            this.groupBoxConcludion_sts.Controls.Add(this.groupBoxResult_sts);
            this.groupBoxConcludion_sts.Location = new System.Drawing.Point(574, 263);
            this.groupBoxConcludion_sts.Name = "groupBoxConcludion_sts";
            this.groupBoxConcludion_sts.Size = new System.Drawing.Size(200, 121);
            this.groupBoxConcludion_sts.TabIndex = 5;
            this.groupBoxConcludion_sts.TabStop = false;
            this.groupBoxConcludion_sts.Text = "Вывод данных ";
            // 
            // groupBoxResult_sts
            // 
            this.groupBoxResult_sts.Controls.Add(this.textBoxResult);
            this.groupBoxResult_sts.Location = new System.Drawing.Point(0, 55);
            this.groupBoxResult_sts.Name = "groupBoxResult_sts";
            this.groupBoxResult_sts.Size = new System.Drawing.Size(200, 60);
            this.groupBoxResult_sts.TabIndex = 1;
            this.groupBoxResult_sts.TabStop = false;
            this.groupBoxResult_sts.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxConcludion_sts);
            this.Controls.Add(this.groupBoxInput_sts);
            this.Controls.Add(this.buttonClic_sts);
            this.Controls.Add(this.buttonDone_sts);
            this.Controls.Add(this.groupBoxCondition_sts);
            this.Name = "FormMain";
            this.Text = "Спринт 6 |Таск 0  | Вариант 8  |Шустов ТС";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCondition_sts.ResumeLayout(false);
            this.groupBoxCondition_sts.PerformLayout();
            this.groupBoxInput_sts.ResumeLayout(false);
            this.groupBoxVariableZ_sts.ResumeLayout(false);
            this.groupBoxVariableZ_sts.PerformLayout();
            this.groupBoxVariableY_sts.ResumeLayout(false);
            this.groupBoxVariableY_sts.PerformLayout();
            this.groupBoxVariable_sts.ResumeLayout(false);
            this.groupBoxVariable_sts.PerformLayout();
            this.groupBoxConcludion_sts.ResumeLayout(false);
            this.groupBoxResult_sts.ResumeLayout(false);
            this.groupBoxResult_sts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxCondition_sts;
        private System.Windows.Forms.TextBox textBoxTask_sts;
        private System.Windows.Forms.Button buttonDone_sts;
        private System.Windows.Forms.Button buttonClic_sts;
        private System.Windows.Forms.GroupBox groupBoxInput_sts;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxConcludion_sts;
        private System.Windows.Forms.GroupBox groupBoxResult_sts;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxVariableZ_sts;
        private System.Windows.Forms.GroupBox groupBoxVariableY_sts;
        private System.Windows.Forms.GroupBox groupBoxVariable_sts;
    }
}

