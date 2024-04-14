using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tienda
{
    public partial class Caja : Form
    {
        int var = 0;
        public Caja()
        {
            InitializeComponent();
            MostrarFecha();
            MostrarHora();
            LlenarProductos();
            label10.Text = "0";
            label12.Text = "0";
        }

        static string[] producto = { "Teclado Razer", "Mouse ergonomico","RX 7600","MSI B550M","Ryzen 7 5700G", "Ryzen 7 5700X", "Ryzen 5 5600X", "Ryzen 5 5600G", "Intel Core i9", "RX 6650" , "GTX 4080" };

        ArrayList produc = new ArrayList(producto);
        Lógica Obj = new Lógica();

        private void LlenarProductos()
        {
            foreach (var p in produc)
            {
                comboBox1.Items.Add(p);
            }
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            comboBox1.Text = "Seleccione un producto";
            textBox3.Clear();
            label10.Text = "0";
            label12.Text = "0";
            listView1.Items.Clear();
            textBox1.Focus();
        }
        private void MostrarFecha()
        {
            label5.Text = DateTime.Now.ToShortDateString();
        }
        private void MostrarHora()
        {
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obj.Producto = comboBox1.Text;
            Obj.Cantidad = int.Parse(textBox3.Text);
            label10.Text = Obj.CalcularSubtotal().ToString();

            ListViewItem fila = new ListViewItem(Obj.Producto);
            fila.SubItems.Add(Obj.Cantidad.ToString());
            fila.SubItems.Add(Obj.AsignarPrecios().ToString());
            fila.SubItems.Add(Obj.CalcularSubtotal().ToString());
            fila.SubItems.Add(Obj.CalcularDescuento().ToString());
            fila.SubItems.Add(Obj.CalcularNeto().ToString());
            listView1.Items.Add(fila);
            var = var + ((int)Obj.CalcularNeto());
            label12.Text = var.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        
        public void button3_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
