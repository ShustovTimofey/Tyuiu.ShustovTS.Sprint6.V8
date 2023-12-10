﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShustovTS.Sprint6.Task2.V28.Lib;

namespace Tyuiu.ShustovTS.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_STS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_STS.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_STS.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_STS.Titles.Add("График функции ");
                this.chartFunction_STS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_STS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_STS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_STS.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonReference_STS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-2 Шустов Тиофей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_STS_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_STS.BackColor = Color.Red;
        }

        private void buttonResult_STS_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_STS.BackColor = Color.Green;

        }

        private void buttonResult_STS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_STS.BackColor = Color.Blue;
        }
    }
}
