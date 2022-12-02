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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuForm = new Usuarios();
            usuForm.MdiParent = this;
            usuForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 srForm = new Form1();
            srForm.MdiParent = this;
            srForm.Show();
        }
    }
}
