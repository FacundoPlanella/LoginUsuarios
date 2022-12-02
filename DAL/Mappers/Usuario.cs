using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public class Usuario
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


        public List<BE.Usuario> Map(DataTable table)
        {

            List<BE.Usuario> usuarios = new List<BE.Usuario>();


            foreach (DataRow item in table.Rows)
            {
                usuarios.Add(new BE.Usuario()
                {
                    Id = int.Parse(item["intId"].ToString()),
                    Username = item["varUsername"].ToString(),
                    Password = item["varPassword"].ToString(),
                    Email = item["varEmail"].ToString(),
                    IsAdmin = bool.Parse(item["isAdmin"].ToString()),
                    ISLocked = bool.Parse(item["IsBlocked"].ToString()),
                    Attempts = int.Parse(item["intAttempts"].ToString())



                });

            }


            return usuarios;


        }
    }
}
