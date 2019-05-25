using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TADKP
{
    public partial class Form1 : Form
    {
        string Nama;//tipe data
        int Pendidikan, jam, nik, GajiPokok, Tunjangan, TotalGaji, Lembur;
        public Form1()
        {
            InitializeComponent();
        }
        public void tidakLembur()
        {
            TotalGaji = GajiPokok + (Tunjangan * 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            comboBox1.SelectedIndex = 6;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out nik);
            Nama = textBox1.Text;
            Pendidikan = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)//pengkondisian
            {
                classSet SD = new classSet(1500000, 500000);
                GajiPokok = SD.getGajiPokok();
                Tunjangan = SD.getTunjangan();
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                classSet SMP = new classSet(1750000, 750000);
                GajiPokok = SMP.getGajiPokok();
                Tunjangan = SMP.getTunjangan();
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                classSet SMA = new classSet(2000000, 1000000);
                GajiPokok = SMA.getGajiPokok();
                Tunjangan = SMA.getTunjangan();
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                classSet S1 = new classSet(2250000, 1250000);
                GajiPokok = S1.getGajiPokok();
                Tunjangan = S1.getTunjangan();
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                classSet S2 = new classSet(2500000, 1500000);
                GajiPokok = S2.getGajiPokok();
                Tunjangan = S2.getTunjangan();
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                classSet S3 = new classSet(3000000, 2000000);
                GajiPokok = S3.getGajiPokok();
                Tunjangan = S3.getTunjangan();
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else if (comboBox1.SelectedIndex == 6)
            {
                classSet S3 = new classSet(0, 0);
                GajiPokok = S3.getGajiPokok();
                Tunjangan = S3.getTunjangan();
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else
            {
                GajiPokok = 500000;
                Tunjangan = 0;
            }


            if (radioButton1.Checked == true)

            {
                int.TryParse(textBox3.Text, out jam);
                Lembur = jam * 100000;
                TotalGaji = GajiPokok + Tunjangan + Lembur;

            }
            else if (radioButton2.Checked == true)

            {
                tidakLembur();

            }
            textBox4.Text = "Karyawan yang bernama " + Nama + " dengan NIK " + nik + ". Total gaji yang Anda terima berjumlah Rp. " + TotalGaji;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
