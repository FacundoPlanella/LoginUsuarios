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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            BLL.Usuario.GetInstance().Create(new BE.Usuario()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                IsAdmin = checkIsAdmin.Checked,
                ISLocked = checkIsBlocked.Checked,
                Email = txtEmail.Text,
                Attempts = int.Parse(txtAtempts.Text)
            }) ;


            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = BLL.Usuario.GetInstance().GetAll();


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = BLL.Usuario.GetInstance().GetAll();

        }

        private void BtnCancelarListadoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
