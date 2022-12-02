using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infractuctura;

namespace DAL.DAOs
{
    public class Usuario
    {

        /// Singleton .
        /// 

        private Usuario()

        #region Singleton
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
        #endregion


        /// <summary>
        ///  Seguimos la siguiente regla : listados con ADO Desconectado, todo lo demas con ADO conectado. 
        /// </summary>
        #region Stores Procedures
        private string connStr = "Data Source=DESKTOP-K24L8KE;Initial Catalog=Universidad-LUG;Integrated Security=True";
        private string insertSp = "UsuarioInsert";
        private string updateSp = "UsuarioUpdate";
        private string deleteSp = "UsuarioDelete";
        private string selectAllSp = "UsuarioSelectAll";
        private string selectbyIdSP = "UsuarioSelect";
        #endregion

        #region Variables Comunes a todos los metodos
        SqlConnection conn;
        SqlCommand comm;
        DataSet dt;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        List<SqlParameter> param;
        
        #endregion

        public bool Insert(BE.Usuario usuario)
        {

            bool returnValue = false;

            try
            {
                return Infractuctura.SqlHelper.GetInstance(connStr).ExecuteQuery(string.Format(" insert into Usuario (varUsername, varPassword, isBlocked, isAdmin, intAttempts, varEmail) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                                                                usuario.Username,
                                                                                                usuario.Password,
                                                                                                usuario.ISLocked,
                                                                                                usuario.IsAdmin,
                                                                                                usuario.Attempts,
                                                                                                usuario.Email));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return returnValue;

            /*
            using (conn = new SqlConnection(connStr))
            {

                comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = insertSp;

                comm.Parameters.Add("@varUsername", SqlDbType.NVarChar, 50).Value = usuario.Username;
                comm.Parameters.Add("@varPassword", SqlDbType.NVarChar, 50).Value = usuario.Password;
                comm.Parameters.Add("@isBlocked", SqlDbType.Bit).Value = usuario.ISLocked;
                comm.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = usuario.IsAdmin;
                comm.Parameters.Add("@varEmail", SqlDbType.NVarChar, 50).Value = usuario.Email;
                comm.Parameters.Add("@intAttempts", SqlDbType.Int).Value = usuario.Attempts;

                conn.Open();

                if (comm.ExecuteNonQuery() > 0)
                {

                    returnValue = true;

                }


            }



            return returnValue;*/

        }
        public bool Update(BE.Usuario usuario)
        {


            param = new List<SqlParameter>();
            param.Add(new SqlParameter("@intId", usuario.Id));
            param.Add(new SqlParameter("@varUsername", usuario.Username));
            param.Add(new SqlParameter("@varPassword", usuario.Password));
            param.Add(new SqlParameter("@isBlocked", usuario.ISLocked));
            param.Add(new SqlParameter("@isAdmin", usuario.IsAdmin));
            param.Add(new SqlParameter("@varEmail", usuario.Email));
            param.Add(new SqlParameter("@intAttempts", usuario.Attempts));




            return Infractuctura.SqlHelper.GetInstance(connStr).ExecuteQuery("UsuarioUpdate", param.ToArray());
            
            

            /*bool returnValue = false;

            using (conn = new SqlConnection(connStr))
            {

                comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = updateSp;

                comm.Parameters.Add("@intId", SqlDbType.Int).Value = usuario.Id;
                comm.Parameters.Add("@varUsername", SqlDbType.NVarChar, 50).Value = usuario.Username;
                comm.Parameters.Add("@varPassword", SqlDbType.NVarChar, 50).Value = usuario.Password;
                comm.Parameters.Add("@isBlocked", SqlDbType.Bit).Value = usuario.ISLocked;
                comm.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = usuario.IsAdmin;
                comm.Parameters.Add("@varEmail", SqlDbType.NVarChar, 50).Value = usuario.Email;
                comm.Parameters.Add("@intAttempts", SqlDbType.Int).Value = usuario.Attempts;

                conn.Open();

                if (comm.ExecuteNonQuery() > 0)
                {

                    returnValue = true;

                }*/


        }

        public DataTable SelectAll()
        {

            try
            {
               return Infractuctura.SqlHelper.GetInstance(connStr).ExecuteReader("select * from Usuario");   
            }
            catch (Exception ex)
            {
                 
                throw ex;
            }
            return new DataTable();


           
        } 

        public bool Delete(BE.Usuario usr)
        {
            param = new List<SqlParameter>();
            param.Add(new SqlParameter("@intId", usr.Id));
            try
            {
                return Infractuctura.SqlHelper.GetInstance(connStr).ExecuteQuery("UsuarioDelete", param.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

            /*bool returnValue = false;

            using (conn = new SqlConnection(connStr))
            {

                comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = deleteSp;

                comm.Parameters.Add("@intId", SqlDbType.Int).Value = usr.Id;


                conn.Open();

                if (comm.ExecuteNonQuery() > 0)
                {

                    returnValue = true;

                }


            }



            return returnValue;*/
        }

    }
}
