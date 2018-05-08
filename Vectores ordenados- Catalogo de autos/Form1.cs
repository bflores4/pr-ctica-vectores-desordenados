using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_ordenados__Catalogo_de_autos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Catalogo catalogoCreado;
        int tamañoCatalogo;
        Auto autoCreado;

        string placa;
        string marca;
        string modelo;
        string telefono;
        string año;

        private void btnCreaCatslogo_Click(object sender, EventArgs e)
        {
            if (txtTamañoCatalogo.Text != "")
            {
                tamañoCatalogo = Convert.ToInt16(txtTamañoCatalogo.Text);
                catalogoCreado = new Catalogo(tamañoCatalogo);
            }
            else
            {
                MessageBox.Show("El tamaño del catalógo no ha sido ingresado.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTamañoCatalogo.Text != "")
            {
                if (catalogoCreado.elementosRegistrados < tamañoCatalogo)
                {
                    placa = txtPlaca.Text;
                    marca = txtMarca.Text;
                    modelo = txtModelo.Text;
                    telefono = txtTelefono.Text;
                    año = txtAño.Text;

                    autoCreado = new Auto(placa, marca, modelo, telefono, año);

                    catalogoCreado.agregar(autoCreado);
                }
                else
                {
                    MessageBox.Show("El catalógo se encuentra lleno, " +
                        "no puede agregar más elemntos por el momento.");
                }
            }
            else
            {
                MessageBox.Show("El catalógo aun no ha sido creado");
            }

            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtTelefono.Text = "";
            txtAño.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)//listar
        {
            txtAutosParaMostrar.Text= catalogoCreado.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(catalogoCreado.buscar(Convert.ToString(txtPlacaBuscar.Text))==null)
                txtAutosParaMostrar.Text = "Auto no encontrado.";
            else
            {
                txtAutosParaMostrar.Text = (catalogoCreado.buscar
                                        (Convert.ToString(txtPlacaBuscar.Text))).ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            catalogoCreado.eliminar(Convert.ToString(txtPlacaBorrar.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (catalogoCreado.PosibleInsertar() != false)
            {
                placa = txtPlaca.Text;
                marca = txtMarca.Text;
                modelo = txtModelo.Text;
                telefono = txtTelefono.Text;
                año = txtAño.Text;

                autoCreado = new Auto(placa, marca, modelo, telefono, año);
                int posicion = Convert.ToInt16(txtPosicionInsertar.Text);
                catalogoCreado.insertar(autoCreado, posicion);
            }
            else
            {
                MessageBox.Show("El catalógo se encuentra lleno, no puede insertar otro elemento.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
