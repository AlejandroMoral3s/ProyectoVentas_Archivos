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
    public partial class cambioClave : Form
    {
        public cambioClave()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void checkInfo(string user, string clave, string confirmacion) {
            CambioClaveSql cambioClave = new CambioClaveSql();
            if (cambioClave.buscarUser(user).Equals("Usuario no encontrado"))
            {
                MessageBox.Show(cambioClave.buscarUser(user));
            }
            else if (clave.Equals(confirmacion))
            {
                cambioClave.Actualizar(user, clave, confirmacion);
                MessageBox.Show("Clave actualizada con éxito");
            }
            else 
            {
                MessageBox.Show("Clave y confirmación no coinciden");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkInfo(TXTusuario.Text, TXTnuevaClave.Text, TXTConfirmNuevaClave.Text);

        }
    }
}
