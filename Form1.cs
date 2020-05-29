using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Massiv
{
    public partial class Form1 : Form
    {
        int[] mas = new int[25];
        public Form1()
        {

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // переход на вторую форму
        {
            Form1.ActiveForm.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void bt1_Click(object sender, EventArgs e) // файловый ввод
        {
            try
            {
                StreamReader f = new StreamReader(@"C:\\file.txt");

                string[] a = f.ReadToEnd().Split('\n');
                for (int i = 0; i < 25; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = a[i];
                    mas[i] = Convert.ToInt32(a[i]);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // очистка
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Rows[0].Cells[i].Value = "";
            label2.Text = "";




        }

        private void button2_Click(object sender, EventArgs e) // сортировка массива
        {
            Array.Sort(mas);
            for (int i = 0; i < mas.Length; i++)
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
        }

        private void button2_Click_1(object sender, EventArgs e) // график
        {
            int[] x = mas;
            int[] y = new int[25];
            for (int i = 0; i < 25; i++)
            {
                y[i] = mas[i];
                x[i] = i;
                diagramma.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
                diagramma.ChartAreas[0].AxisX.MajorGrid.Interval = 2;
                diagramma.Series[0].Points.DataBindXY(x, y);
            }
        }

        private void off_Click(object sender, EventArgs e) // завершение работы
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void rand_Click(object sender, EventArgs e) // рандомное заполнение массива
        {
            dataGridView1.ColumnCount = 25;
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-100, 100);
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
            } // заполнение ячеек 
        }

        private void ar_Click(object sender, EventArgs e) // задание
        {
            int summ = 0;
            for (int i = 0; i < mas.Length; i++)
                summ += mas[i];
            int mid = summ / mas.Length;
            label2.Text = "Среднее арифметическое :" + summ.ToString();
        }
    }
}

