using ProyectoP6App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP6App.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {


       // public UserPost MyUserToPost { get; set; }

        public UsuarioRol MyUserRole { get; set; }
        public UsuarioViewModel()
        {
           // MyUserToPost = new UserPost();
           MyUserRole = new UsuarioRol();
        }

        //carga de roles de usuarios
        public async Task<List<UsuarioRol>?> GetAllUserRolesAsync()
        {
            try
            {
                List<UsuarioRol> roles = new List<UsuarioRol>();

                roles = await MyUserRole.GetAllUserRolesAsync();

                if (roles == null)
                {
                    return null;
                }
                return roles;
            }
            catch (Exception)
            {
                throw;
            }


        }


    }


}

