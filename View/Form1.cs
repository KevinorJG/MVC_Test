using Controllers.Controllers;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        protected ClientController controller = new ClientController();

        public Form1()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {

            ClientViewModel client = new ClientViewModel()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
                Direccion = txtDireccion.Text,
            };
            controller.Save(client);
            RefreshList();
            Clean();
        }
        protected void RefreshList()
        {
            listView1.Items.Clear();
            var ls = controller.GetClients();
            if (ls != null)
            {
                foreach (var client in ls)
                {
                    ListViewItem item = new ListViewItem(client.Nombre);
                    item.SubItems.Add(client.Apellido);
                    item.SubItems.Add(client.DNI);
                    item.SubItems.Add(client.Direccion);
                    listView1.Items.Add(item);
                }
            }

        }
        protected void Clean()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            controller.SaveInfo();
            Application.Exit();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var client = controller.GetClientByDNI(txtSearch.Text);
            if (client == null)
            {
                MessageBox.Show($"El Cliente con cédula: {txtSearch.Text} !No existe¡", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtNombre.Text = client.Nombre;
                txtApellido.Text = client.Apellido;
                txtDNI.Text = client.DNI;
                txtDireccion.Text = client.Direccion;
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            controller.SaveInfo();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ClientViewModel client = new ClientViewModel()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
                Direccion = txtDireccion.Text,
            };

            var info = controller.Update(client);

            if (info == false)
            {
                MessageBox.Show("¡No pudo actualizarse!", "No actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshList();
                MessageBox.Show("¡Actualizado correctamente!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ls = controller.LoadClient();
            if (ls != null)
            {
                foreach (var client in ls)
                {
                    ListViewItem item = new ListViewItem(client.Nombre);
                    item.SubItems.Add(client.Apellido);
                    item.SubItems.Add(client.DNI);
                    item.SubItems.Add(client.Direccion);
                    listView1.Items.Add(item);
                }
            }


        }
    }
}
