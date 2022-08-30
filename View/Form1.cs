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
            
            CityViewModel city = new CityViewModel()
            {
                CityName = txtCity.Text,
                CountryName = txtEstado.Text,
            };
            ClientViewModel client = new ClientViewModel()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
                Direccion = txtDireccion.Text,
                City = city  
            };
           var exist = controller.ExistClient(client.DNI);
            if (exist == true)
            {
                MessageBox.Show("Este registro ya existe");
            }
            else
            {
                controller.Save(client);
                RefreshList();
                Clean();
            }           
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
                    item.SubItems.Add(client.City.CityName);
                    item.SubItems.Add(client.City.CountryName);
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
            txtCity.Clear();
            txtEstado.Clear();
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
                btDelete.Enabled = true;
                btUpdate.Enabled = true;

                txtNombre.Text = client.Nombre;
                txtApellido.Text = client.Apellido;
                txtDNI.Text = client.DNI;
                txtDireccion.Text = client.Direccion;
                txtEstado.Text = client.City.CountryName;
                txtCity.Text = client.City.CityName;
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            CityViewModel city = new CityViewModel()
            {
                CityName = txtCity.Text,
                CountryName = txtEstado.Text,
            };
            ClientViewModel client = new ClientViewModel()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
                Direccion = txtDireccion.Text,
                City = city,
            };

            var info = controller.Update(client);

            if (info == false)
            {
                MessageBox.Show("¡No pudo actualizarse!", "No actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshList();
                Clean();
                MessageBox.Show("¡Actualizado correctamente!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btDelete.Enabled = false;
            btUpdate.Enabled = false;

            var ls = controller.LoadClient();
            if (ls != null)
            {
                foreach (var client in ls)
                {
                    ListViewItem item = new ListViewItem(client.Nombre);
                    item.SubItems.Add(client.Apellido);
                    item.SubItems.Add(client.DNI);
                    item.SubItems.Add(client.Direccion);
                    item.SubItems.Add(client.City.CityName);
                    item.SubItems.Add(client.City.CountryName);
                    listView1.Items.Add(item);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            ClientViewModel client = new ClientViewModel()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
                Direccion = txtDireccion.Text,
            };

            var info = controller.DeleteClient(client);

            if (info == false)
            {
                MessageBox.Show("¡No pudo eliminarse!", "No eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshList();
                Clean();
                MessageBox.Show("¡Eliminado correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }
    }
}
