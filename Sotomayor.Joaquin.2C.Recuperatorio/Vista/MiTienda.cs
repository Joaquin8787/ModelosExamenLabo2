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
    public partial class MiTienda : Form
    {
        private Tienda tienda;
        public MiTienda()
        {
            InitializeComponent();
            tienda = new Tienda();
        }

        private void MiTienda_Load(object sender, EventArgs e)
        {
            cmbProducto.Items.Add("Jean");
            cmbProducto.Items.Add("Camisa");
            cmbTalle.Items.Add(Talles.Chico);
            cmbTalle.Items.Add(Talles.Grande);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            tienda = tienda + CrearPrenda();
            RefrescarListaProductos();


        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            tienda = tienda - CrearPrenda();
            RefrescarListaProductos();
        }
       private Prenda CrearPrenda()
        {
            Prenda prenda = null;
          if (this.cmbProducto.SelectedText == "Jean")
            {
             prenda = new Jean(txtModelo.Text,(Talles)cmbTalle.SelectedItem,Color.Aqua,Calce.Ajustado);
            }
          else if(this.cmbProducto.SelectedText == "Camisa")
            {
                prenda = new Camisa(txtModelo.Text, (Talles)cmbTalle.SelectedItem, Color.Blue, Color.Gold);
            }
            return prenda;
        }

        private void RefrescarListaProductos()
        {
            foreach(Prenda prenda in tienda.Prendas)
            {
                lstProductos.Text = prenda.Informacion();
            }
            
        }



    }
}
