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
        protected List<Client> ListClients = new List<Client>();
        protected string Json;
        protected string ruta;
        protected string currenPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "List.json";
        
        public void Save(ClientViewModel model)
        {
            //Guarda el cliente que le estas pasando a lista clientes
            if (model == null)
            {
                throw new ArgumentNullException("El modelo está vacio");
            }
            City city = new City()
            {
                CityName = model.City.CityName,
                CountryName = model.City.CountryName,
            };
            Client client = new Client()
            {
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Direccion = model.Direccion,
                DNI = model.DNI,
                City = city
            };
            ListClients.Add(client);

        }

        public List<Client> GetClients()
        {
            return ListClients;
        }

        public Client GetClientByDNI(string dni)
        { 
            return ListClients.FirstOrDefault(x => x.DNI == dni);
        }
        public bool ExistClient(string dni)
        {
            var exist = ListClients.Where(c => c.DNI == dni);
            if (exist.Any())
            {
                return true;
            }
            return false;
        }

        public bool Update(ClientViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("El modelo está vacio");
            }
            var cl = ListClients.FirstOrDefault(c => c.DNI == model.DNI);
            int index = ListClients.IndexOf(cl);
           
           
            if (index == -1)
            {
                return false;
            }
            City city = new City()
            {
                CityName = model.City.CityName,
                CountryName = model.City.CountryName,
            };
            Client client = new Client()
            {
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Direccion = model.Direccion,
                DNI = model.DNI,
                City = city
            };
            ListClients.RemoveAt(index);
            ListClients.Insert(index, client);
            return true;
        }

        public void SaveInfo()
        {
            ruta = currenPath;
            Json = JsonConvert.SerializeObject(ListClients,Formatting.Indented);

            if (!String.IsNullOrEmpty(Json))
            {
                if (File.Exists(ruta))
                {
                    File.Delete(ruta);
                    using (FileStream stream = new FileStream(ruta, FileMode.OpenOrCreate))
                    {
                        using (StreamWriter sw = new StreamWriter(stream))
                        {
                            sw.WriteLine(Json);
                        }

                    }
                }                             
            }
           
        }
        public List<Client> LoadClient()
        {
            string JsonString = String.Empty;
            ruta = currenPath;
            List<Client> ls = null;
            
            try
            {
                if (File.Exists(ruta))
                {
                    using (FileStream stream = new FileStream(ruta, FileMode.OpenOrCreate))
                    {
                        using (StreamReader sw = new StreamReader(stream))
                        {

                            JsonString = sw.ReadToEnd();
                        }
                    }
                }
                ls = JsonConvert.DeserializeObject<List<Client>>(JsonString);
            }
            catch
            {
               
            }
            
            if(ls == null)
            {
                return null;
            }
            ListClients = ls.ToList();
            return ls;
        }
        public bool DeleteClient(ClientViewModel model )
        {
            if (model == null)
            {
                throw new ArgumentNullException("El modelo está vacio");
            }
            var cl = ListClients.FirstOrDefault(c => c.DNI == model.DNI);
            var index = ListClients.IndexOf(cl);

            if (index == -1)
            {
                return false;
            }
            
            ListClients.RemoveAt(index);           
            return true;
        }
    }
}
