using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = tbApellido.Text;
            string nombre = tbNombre.Text;
            string edad = tbEdad.Text;
            string direccion = tbDireccion.Text;

            if(tbApellido.Text == "")
            {
                tbApellido.BackColor = Color.Red;
            }
            if(tbNombre.Text == "")
            {
                tbNombre.BackColor = Color.Red;
            }
            if(tbEdad.Text == "")
            {
                tbEdad.BackColor = Color.Red;
            }
            if(tbDireccion.Text == "")
            {
                tbDireccion.BackColor = Color.Red;
            }

            if (tbApellido.BackColor != Color.Red && tbNombre.BackColor != Color.Red && tbEdad.BackColor != Color.Red && tbDireccion.BackColor != Color.Red) { 
                lvResultado.Items.Add("APELLIDO : " + apellido);
                lvResultado.Items.Add("");
                lvResultado.Items.Add("NOMBRE : " + nombre);
                lvResultado.Items.Add("");
                lvResultado.Items.Add("EDAD : " + edad);
                lvResultado.Items.Add("");
                lvResultado.Items.Add("DIRECCIÓN : " + direccion);    
            } 
        }

        private void tbApellido_Click(object sender, EventArgs e)
        {
            tbApellido.BackColor = Color.White;
        }

        private void tbNombre_Click(object sender, EventArgs e)
        {
            tbNombre.BackColor = Color.White;
        }

        private void tbEdad_Click(object sender, EventArgs e)
        {
            tbEdad.BackColor = Color.White;
        }

        private void tbDireccion_Click(object sender, EventArgs e)
        {
            tbDireccion.BackColor = Color.White;
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
