using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Model.ViewModels;
//using View.ViewModels;

namespace Controllers.Controllers
{
    public class ClientController
    {
        protected List<Client> clients = new List<Client>();
        protected string Json;
        protected string ruta;
        protected string currenPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "List.json";
        
        public void Save(ClientViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("El modelo está vacio");
            }
            Client client = new Client()
            {
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Direccion = model.Direccion,
                DNI = model.DNI,
            };
            clients.Add(client);

        }

        public List<Client> GetClients()
        {
            return clients;
        }

        public Client GetClientByDNI(string dni)
        {
            return clients.FirstOrDefault(c => c.DNI == dni);
        }

        public bool Update(ClientViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("El modelo está vacio");
            }
            var cl = clients.FirstOrDefault(c => c.DNI == model.DNI);
            var index = clients.IndexOf(cl);
           
            if (index == -1)
            {
                return false;
            }
            Client client = new Client()
            {
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Direccion = model.Direccion,
                DNI = model.DNI,
            };
            clients.RemoveAt(index);
            clients.Insert(index, client);
            SaveInfo();
            return true;
        }

        public void SaveInfo()
        {
            ruta = currenPath;
            Json = JsonConvert.SerializeObject(clients);

            if (!String.IsNullOrEmpty(Json))
            {
                using (FileStream stream = new FileStream(ruta, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.WriteLine(Json);
                    }

                }
            }
           
        }
        public List<Client> LoadClient()
        {
            string JsonString;
            ruta = currenPath;
            using (FileStream stream = new FileStream(ruta, FileMode.OpenOrCreate))
            {
                using (StreamReader sw = new StreamReader(stream))
                {
                    JsonString = sw.ReadToEnd();
                }

            }
            var ls = JsonConvert.DeserializeObject<List<Client>>(JsonString);
            if(ls == null)
            {
                return null;
            }
            clients = ls.ToList();
            return ls;
        }
    }
}
