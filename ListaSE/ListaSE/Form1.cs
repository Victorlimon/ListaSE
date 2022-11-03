using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSE
{
    public partial class Form1 : Form
    {
        TLisAsig Lista1;
        public Form1()
        {
            InitializeComponent();
            Lista1 = new TLisAsig();
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtHoras.Text == "")
            {
                MessageBox.Show("Escribe los datos");
                return;
            }
            else
            {
                Lista1.crearLista(txtNombre.Text, int.Parse(txtHoras.Text));
                txtNombre.Text = "Escribir aqui";
                txtHoras.Text = "";
                txtNombre.Focus();
                txtNombre.Text = null;
                txtHoras.Text = null;
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            //TNodoAsig elim;
            if (Lista1.BuscarAsig(txtNombre.Text))
            {
                //elim = (TNodoAsig)Lista1.eliminar();
                Lista1.eliminarLista(txtNombre.Text);
                txtNombre.Text = "";
                txtHoras.Text = "";
            }
            else
                MessageBox.Show("Lista vacia");
        }

        private void button_Ultimo_Click(object sender, EventArgs e)
        {
            TNodoAsig nodoUltimo;
            nodoUltimo = (TNodoAsig)Lista1.getUltimo();
            if (nodoUltimo == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }
            else
            {
                txtNombre.Text = nodoUltimo.dameAsig();
                txtHoras.Text = (nodoUltimo.dameHoras()).ToString();
            }
        }

        private void button_primero_Click(object sender, EventArgs e)
        {
            TNodoAsig nodoPrimero;
            nodoPrimero = (TNodoAsig)Lista1.getPrimero();
            if (nodoPrimero == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }
            else
            {
                txtNombre.Text = nodoPrimero.dameAsig();
                txtHoras.Text = (nodoPrimero.dameHoras()).ToString();
            }
        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            TNodoAsig nodoSucesor;
            if (Lista1.BuscarAsig(txtNombre.Text) == true && (TNodoAsig)Lista1.getProxCursor() != null)
            {
                nodoSucesor = (TNodoAsig)Lista1.getProxCursor();
                txtNombre.Text = nodoSucesor.dameAsig();
                txtHoras.Text = (nodoSucesor.dameHoras()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene Sucesor");
            }
        }

        private void button_anterior_Click(object sender, EventArgs e)
        {
            if (Lista1.BuscarAsig(txtNombre.Text) == true && (TNodoAsig)Lista1.getAntCursor() != null)
            {
                TNodoAsig nodoAnterior = (TNodoAsig)Lista1.getAntCursor();
                txtNombre.Text = nodoAnterior.dameAsig();
                txtHoras.Text = (nodoAnterior.dameHoras()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene Antecesor");
            }
        }
    }
}
