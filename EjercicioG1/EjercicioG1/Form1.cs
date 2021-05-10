using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioG1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<String> datos = new List<string>();

             
            datos.Add(textBox1.Text);

            foreach (string iteracion in datos)
            {
                dataGridView1.Rows.Add(iteracion);
            }

        }
    }
}
