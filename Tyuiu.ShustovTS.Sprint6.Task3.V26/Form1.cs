using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShustovTS.Sprint6.Task3.V26.Lib;

namespace Tyuiu.ShustovTS.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 16, 19, 17, 2, 8 },
                                       { -17, 8, -17, -8, 1 },
                                       { -7, 17, -2, 1, -3 },
                                       { -12, 0, -17, 15, 6 },
                                       { 17, -6, -17, 18, -19 } };


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_STS.ColumnCount = columns;
            dataGridViewMatrix_STS.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_STS.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_STS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }


            }

        }

        private void buttonReference_LVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-23-2 Шустов Тимофей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_STS_Click(object sender, EventArgs e)
        {

            int[,] resultMatrix = ds.Calculate(mtrx);


            dataGridViewMatrixResult_STS.Rows.Clear();
            dataGridViewMatrixResult_STS.Columns.Clear();


            int rows = resultMatrix.GetUpperBound(0) + 1;
            int columns = resultMatrix.Length / rows;


            dataGridViewMatrixResult_STS.ColumnCount = columns;
            dataGridViewMatrixResult_STS.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_STS.Columns[i].Width = 30;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_STS.Rows[i].Cells[j].Value = resultMatrix[i, j].ToString();
                }
            }
        }
    }
}
