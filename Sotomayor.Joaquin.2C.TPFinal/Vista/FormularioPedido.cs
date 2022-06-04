using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FormularioPedido : Form
    {
        public List<Pedido> listaPedidos;
        public FormularioPedido()
        {
            InitializeComponent();
            listaPedidos = new List<Pedido>();
        }

        private void rtbPedidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioPedido_Load(object sender, EventArgs e)
        {
            cmbTipo.Enabled = false;
        }
        public Pedido CrearPedido(Producto producto)
        {
                if(cmbTipo.SelectedItem is not null && cmbCantidad.SelectedItem is not null)
                {
                    
                    return pedidoNuevo + producto;
                }
            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pedido pedidoNuevo = new Pedido(txtNombre.Text, txtDireccion.Text, txtTelefono.Text);
            do
            {
             Producto producto = new Sushi((string)cmbProducto.SelectedItem, Sushi.GeneradorPrecio((Roll)cmbTipo.SelectedItem), (Roll)cmbTipo.SelectedItem, int.Parse(cmbCantidad.Text));
             CrearPedido(producto);
            } while(MessageBox.Show("Desea agregar otro producto al pedido?", "Crear Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo.Enabled = true;
            if(cmbProducto.Text == "Sushi")
            {
                cmbTipo.Items.Add(Roll.Furai);
                cmbTipo.Items.Add(Roll.Parma);
                cmbTipo.Items.Add(Roll.Ibiza);
                cmbTipo.Items.Add(Roll.RollKina);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (listaPedidos + CrearPedido())
            {

                MessageBox.Show("Pedido generado con exito", "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo algun problema para generar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
