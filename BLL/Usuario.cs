using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario : BE.ICrud<BE.Usuario>
    {

        private Usuario()
        {

        }


        private static Usuario instance;

        public static Usuario GetInstance()
        {
            if (instance == null)
            {
                instance = new Usuario();
            }

            return instance;
        }

        public bool Create(BE.Usuario objAdd)
        {
            try
            {
                return DAL.Usuario.GetInstance().Create(objAdd);
            }
            catch (Exception)
            {

                throw ;
            }
        }

        public List<BE.Usuario> GetAll()
        {
            try
            {
                return DAL.Usuario.GetInstance().GetAll();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public BE.Usuario GetById(BE.Usuario objId)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.Usuario objUpd)
        {
            try
            {
                return DAL.Usuario.GetInstance().Update(objUpd);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(BE.Usuario objUdp)
        {
            try
            {
                return DAL.Usuario.GetInstance().Delete(objUdp);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// Agregar los metodos necesarios para poder Bloquear un usuario, desbloquear un usuario, validar un usuario ,
        /// Sumar 1  a la cantidad de intentos , verificar si el usuario exsiste, reiniciar los attemps, etc.
        /// 
      

        public bool Validara(string usr, string pass)
        {
            bool varr = false;

            foreach (var i in Usuario.GetInstance().GetAll())
            {
                if (pass == i.Password && usr == i.Username && i.ISLocked == false)
                {
                   varr = true;   
                }
            }

            return varr;
        }

        public string Bloquear(string usr)
        {
            string varr = "";

            foreach (var i in Usuario.GetInstance().GetAll())
            {
                if (usr == i.Username)
                {
                    BE.Usuario usuario = new BE.Usuario();
                    usuario.Username = i.Username;
                    usuario.Id = i.Id;
                    usuario.Password = i.Password;
                    usuario.IsAdmin = i.IsAdmin;
                    usuario.Attempts = i.Attempts;
                    usuario.Email = i.Email;
                    usuario.ISLocked = true;
                    Usuario.GetInstance().Update(usuario);
                    varr = i.Username;
                    return varr;
                }

            }

            return varr;
        }
        public string DesBloquear(string usr)
        {
            string varr = "";

            foreach (var i in Usuario.GetInstance().GetAll())
            {
                if (usr == (i.Id).ToString())
                {
                    BE.Usuario usuario = new BE.Usuario();
                    usuario.Username = i.Username;
                    usuario.Id = i.Id;
                    usuario.Password = i.Password;
                    usuario.IsAdmin = i.IsAdmin;
                    usuario.Attempts = 5;
                    usuario.Email = i.Email;
                    usuario.ISLocked = false;
                    Usuario.GetInstance().Update(usuario);
                    varr = i.Username;
                    return varr;
                }

            }

            return varr;
        }
        public string ADMBloquear(string usr)
        {
            string varr = "";

            foreach (var i in Usuario.GetInstance().GetAll())
            {
                if (usr == (i.Id).ToString())
                {
                    BE.Usuario usuario = new BE.Usuario();
                    usuario.Username = i.Username;
                    usuario.Id = i.Id;
                    usuario.Password = i.Password;
                    usuario.IsAdmin = i.IsAdmin;
                    usuario.Attempts = i.Attempts;
                    usuario.Email = i.Email;
                    usuario.ISLocked = true;
                    Usuario.GetInstance().Update(usuario);
                    varr = i.Username;
                    return varr;
                }

            }

            return varr;
        }


        public bool ValidaADM(string usr)
        {

            bool varr = false;

            foreach (var i in Usuario.GetInstance().GetAll())
            {
                if (usr == i.Username && i.IsAdmin == true)
                {
                    varr = true;
                }
            }

            return varr;
        }
        public int BuscarIntentos(string usr)
        {
            int varr = 0;
            BE.Usuario usuario = new BE.Usuario();
            foreach (var i in Usuario.GetInstance().GetAll())
            {
                if (usr == i.Username)
                {
                    usuario = i;
                    usuario.Attempts = usuario.Attempts - 1;
                    Usuario.GetInstance().Update(usuario);
                    varr = usuario.Attempts;
                }
            }

            return varr;
        }
    }
}
