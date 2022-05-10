using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_y_Descriptor_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eSIMEDataSet1.GRUPO8CM11' Puede moverla o quitarla según sea necesario.
            this.gRUPO8CM11TableAdapter.Fill(this.eSIMEDataSet1.GRUPO8CM11);
            



        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFFirma.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.gRUPO8CM11TableAdapter.agregarelemento(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                this.gRUPO8CM11TableAdapter.Fill(this.eSIMEDataSet1.GRUPO8CM11);
            }
            catch
            {
            
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gRUPO8CM11TableAdapter.actualizaralumno(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,textBox5.Text,textBox1.Text);
            this.gRUPO8CM11TableAdapter.Fill(this.eSIMEDataSet1.GRUPO8CM11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.gRUPO8CM11TableAdapter.eliminaralumno(textBox1.Text);
            this.gRUPO8CM11TableAdapter.Fill(this.eSIMEDataSet1.GRUPO8CM11);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.gRUPO8CM11TableAdapter.buscaralumno(eSIMEDataSet1.GRUPO8CM11,textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.gRUPO8CM11TableAdapter.Fill(this.eSIMEDataSet1.GRUPO8CM11);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
