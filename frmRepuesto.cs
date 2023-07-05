using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRaoSp1
{
    public partial class frmRepuesto : Form
    {
       List<ClaseRepuesto> ListaRepuesto = new List<ClaseRepuesto>();

        public void LimpiarDatos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbMarca.SelectedIndex = -1;
            optNacional.Checked = true;

        }

        public frmRepuesto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) 
        {
            ClaseRepuesto ObjRepuesto = new ClaseRepuesto();

            ObjRepuesto.nombre = txtNombre.Text;
            ObjRepuesto.codigo = int.Parse(txtCodigo.Text);
            ObjRepuesto.precio = int.Parse(txtPrecio.Text);
            ObjRepuesto.marca = cmbMarca.Text;

            if (optImportado.Checked == true)
            {
                ObjRepuesto.origen = "Importado";
            }
            else
            {
                ObjRepuesto.origen = "Nacional";
            }

            LimpiarDatos();

            MessageBox.Show("Repuesto registrado como: " + ObjRepuesto.MostrarRepuesto());
            ListaRepuesto.Add(ObjRepuesto);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstRepuesto.Items.Clear();
            foreach (ClaseRepuesto repuesto in ListaRepuesto)
            {
                lstRepuesto.Items.Add("Nombre: " + repuesto.nombre + " Codigo: " + repuesto.codigo + " Marca: " + repuesto.marca +
                    " Precio: " + repuesto.precio + " Origen: " + repuesto.origen);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
