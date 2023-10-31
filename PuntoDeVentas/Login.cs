using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class Login : Form
    {
        menuPrincipal menu = new menuPrincipal();
        private bool inicio, admin,primeraVez=true;
        public Login()
        {
            InitializeComponent();
        }

        public void setInicio(bool inicio)
        {
            this.inicio = inicio;   
        }

        public bool getInicio()
        {
            return inicio;
        }
        public void setAdmin(bool admin)
        {
            this.admin = admin;
        }

        public bool getAdmin()
        {
            return admin;
        }
        public void setPrimeraVez(bool primeraVez)
        {
            this.primeraVez = primeraVez;
        }

        public bool getPrimeraVez()
        {
            return primeraVez;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            LoginSql ps = new LoginSql();

            string indiceVolatil = ps.checklogin(txtUser.Text, txtClave.Text);
            if (indiceVolatil.Equals("1"))
            {
                this.Close();
                setInicio(true);
                setAdmin(true);
                setPrimeraVez(false);
            }
            else if (indiceVolatil.Equals("2"))
            {
                this.Close();
                setInicio(true);
                setAdmin(false);    
                setPrimeraVez(false);
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrectos", "Error de inicio de sesión");
                setInicio(false);
                setAdmin(false);
            }
        }
    }
}
