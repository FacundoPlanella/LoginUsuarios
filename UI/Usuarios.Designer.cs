
namespace UI
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.checkIsBlocked = new System.Windows.Forms.CheckBox();
            this.checkIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.BtnCancelarListadoUsuario = new System.Windows.Forms.Button();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAtempts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(136, 112);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // checkIsBlocked
            // 
            this.checkIsBlocked.AutoSize = true;
            this.checkIsBlocked.Location = new System.Drawing.Point(136, 241);
            this.checkIsBlocked.Name = "checkIsBlocked";
            this.checkIsBlocked.Size = new System.Drawing.Size(73, 17);
            this.checkIsBlocked.TabIndex = 5;
            this.checkIsBlocked.Text = "IsBlocked";
            this.checkIsBlocked.UseVisualStyleBackColor = true;
            // 
            // checkIsAdmin
            // 
            this.checkIsAdmin.AutoSize = true;
            this.checkIsAdmin.Location = new System.Drawing.Point(136, 264);
            this.checkIsAdmin.Name = "checkIsAdmin";
            this.checkIsAdmin.Size = new System.Drawing.Size(63, 17);
            this.checkIsAdmin.TabIndex = 6;
            this.checkIsAdmin.Text = "IsAdmin";
            this.checkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(111, 287);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Crear Usuario";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(437, 383);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // BtnCancelarListadoUsuario
            // 
            this.BtnCancelarListadoUsuario.Location = new System.Drawing.Point(533, 383);
            this.BtnCancelarListadoUsuario.Name = "BtnCancelarListadoUsuario";
            this.BtnCancelarListadoUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarListadoUsuario.TabIndex = 10;
            this.BtnCancelarListadoUsuario.Text = "Cancelar";
            this.BtnCancelarListadoUsuario.UseVisualStyleBackColor = true;
            this.BtnCancelarListadoUsuario.Click += new System.EventHandler(this.BtnCancelarListadoUsuario_Click);
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(292, 30);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.Size = new System.Drawing.Size(475, 337);
            this.dgUsuarios.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Attemps";
            // 
            // txtAtempts
            // 
            this.txtAtempts.Location = new System.Drawing.Point(136, 199);
            this.txtAtempts.Name = "txtAtempts";
            this.txtAtempts.Size = new System.Drawing.Size(100, 20);
            this.txtAtempts.TabIndex = 4;
            this.txtAtempts.Text = "0";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.BtnCancelarListadoUsuario);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.checkIsAdmin);
            this.Controls.Add(this.checkIsBlocked);
            this.Controls.Add(this.txtAtempts);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox checkIsBlocked;
        private System.Windows.Forms.CheckBox checkIsAdmin;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button BtnCancelarListadoUsuario;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAtempts;
    }
}