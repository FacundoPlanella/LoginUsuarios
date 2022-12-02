using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL.Usuario.GetInstance().GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (0 != BLL.Usuario.GetInstance().BuscarIntentos(textBox1.Text))
            {
                if (BLL.Usuario.GetInstance().Validara(textBox1.Text, txtPassword.Text) == false)
                {
                    
                }
                else
                {
                    
                    button4.Visible = true;
                    button5.Visible = true;
                    groupBox1.Visible = false;
                    if (BLL.Usuario.GetInstance().ValidaADM(textBox1.Text) == true)
                    {
                        groupBox2.Visible = true;
                    }
                    
                }
            }
            else
            {
                BLL.Usuario.GetInstance().Bloquear(textBox1.Text);
                MessageBox.Show("Se blocko el usuario");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = BLL.Usuario.GetInstance().GetAll();
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            textBox1.Text = "Nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BE.Usuario usr = new BE.Usuario();

            usr.Id = int.Parse(textBox1.Text);
            if (BLL.Usuario.GetInstance().Delete(usr))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = BLL.Usuario.GetInstance().GetAll();
            }
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BE.Usuario usr = new BE.Usuario();

            usr.Id = int.Parse(textBox1.Text);
            BLL.Usuario.GetInstance().DesBloquear(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL.Usuario.GetInstance().GetAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BE.Usuario usr = new BE.Usuario();

            usr.Id = int.Parse(textBox1.Text);
            BLL.Usuario.GetInstance().ADMBloquear(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL.Usuario.GetInstance().GetAll();
        }
    }
}
