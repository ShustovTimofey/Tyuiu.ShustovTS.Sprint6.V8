using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShustovTS.Sprint6.Task1.V30.Lib;

namespace Tyuiu.ShustovTS.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_sts_Click(object sender, EventArgs e)
        {
            try
            {

                int startStep = Convert.ToInt32(textBoxVarA_sts.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_sts.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxAnswer_sts.Text = "";
                textBoxAnswer_sts.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxAnswer_sts.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxAnswer_sts.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxAnswer_sts.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }

                textBoxAnswer_sts.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonReference_LVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-23-2 Лягин Владимир Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
