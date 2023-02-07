using SistemasProgramacionRFC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasProgramacionRFC.Formularios
{
    public partial class GenerarRFC : Form
    {
        public GenerarRFC()
        {
            InitializeComponent();
        }
        
        private void btnGenerarRFC_Click(object sender, EventArgs e)
        {
            //Validar que no se deje el nombre en blanco
            if (txtNombre.Text == "")
            {
                error1.SetError(txtNombre, "No puede dejar el espacio en blanco");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            //Validar que no se deje el apellido paterno en blanco
            if (txtPaterno.Text == "")
            {
                error1.SetError(txtPaterno, "No puede dejar el espacio en blanco");
                txtPaterno.Focus();
                return;
            }
            error1.SetError(txtPaterno, "");

            //Validar que no se deje el apellido materno en blanco
            if (txtMaterno.Text == "")
            {
                error1.SetError(txtMaterno, "No puede dejar el espacio en blanco");
                txtMaterno.Focus();
                return;
            }
            error1.SetError(txtMaterno, "");

            //Validar que sea un teléfono
            long Telefono;
            if(!long.TryParse(txtTelefono.Text, out Telefono))
            {
                error1.SetError(txtTelefono, "Debe ingresar un número telefónico");
                txtTelefono.Focus();
                return;
            }
            error1.SetError(txtTelefono, "");
            
            if (txtTelefono.TextLength < 10)
            {
                error1.SetError(txtTelefono, "El número telefónico debe contener 10 dígitos");
                txtTelefono.Focus();
                return;
            }
            error1.SetError(txtTelefono, "");
          
            string nombre = txtNombre.Text;
            string paterno = this.txtPaterno.Text;
            string materno = this.txtMaterno.Text;
            DateTime fechanacimiento = DateTime.Parse(this.dateTimePickerFNacimiento.Text);
            long telefono = long.Parse(this.txtTelefono.Text);
            string correo = this.txtCorreo.Text;

            Persona objPersona = new Persona(nombre, paterno, materno, fechanacimiento);
            txtRFC.Text = Persona.RFC;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtTelefono.Clear();
            dateTimePickerFNacimiento.ResetText();
            txtCorreo.Clear();
            txtRFC.Clear();
        }
    }
}
