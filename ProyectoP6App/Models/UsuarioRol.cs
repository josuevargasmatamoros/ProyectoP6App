using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP6App.Models
{
    public class UsuarioRol
    {

        public RestRequest? Request { get; set; }

        public int UsuarioRolId { get; set; }

        public string? Descripcion { get; set; } = null!;

        //FUNCIONES

        //cargar todos los roles de usuario

        public async Task<List<UsuarioRol>?> GetAllUserRolesAsync()
        {
            try
            {
                //tenemos que armar la ruta completa de consuma del API
                //para eso tenemos en WEBAPIConnection la ruta de base del API
                // y aca la completamos
                string RouterSufix = string.Format("UserRoles");

                //armamos la ruta completa de consumo del API
                string URL = Services.WebAPIConnections.ProductionURLPrefix + RouterSufix;
                //ahora tenemos la ruta completa lista

                //configuramos el request 
                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                //agregamos el metodo de seguridad, en este caso tenemos apikey
                Request.AddHeader(Services.WebAPIConnections.Apikeyname, Services.WebAPIConnections.ApikeyValue);

                // y ahora ejectumas la llamada al API
                RestResponse response = await client.ExecuteAsync(Request);

                //validamos que todo haya salido bien
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    //si obtuvimos  respuesta positiva desde el API
                    var list = JsonConvert.DeserializeObject<List<UsuarioRol>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string ErrorMsg = ex.Message;
                throw;
            }
        }

    }


}

