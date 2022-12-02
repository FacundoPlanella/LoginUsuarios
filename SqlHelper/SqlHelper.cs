using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using BE;

namespace Infractuctura
{
    public class SqlHelper
    {
        #region Stores Procedures
        private string connStr = "Data Source=DESKTOP-K24L8KE;Initial Catalog=Universidad-LUG;Integrated Security=True";
        private string insertSp = "UsuarioInsert";
        private string updateSp = "UsuarioUpdate";
        private string deleteSp = "UsuarioDelete";
        private string selectAllSp = "UsuarioSelectAll";
        private string selectbyIdSP = "UsuarioSelect";
        #endregion

        #region Veriables
        SqlCommand com;
        SqlConnection connection;
        private static SqlHelper instance;
        DataSet dt;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dtData;
        #endregion
        private SqlHelper(string connSTRING)
        {
            this.StringConection = connSTRING;
        }
        internal string StringConection { get; set; }



        public static SqlHelper GetInstance(string connSTRING)
        {
            if (instance == null)
            {
                instance = new SqlHelper(connSTRING);

            }
            return instance;
        }



        public bool ExecuteQuery(string Query)
        {
            bool returnValue = false;
            com = new SqlCommand();
            connection = new SqlConnection(connStr);

            try
            {

                com.Connection = connection;
                com.CommandType = CommandType.Text;
                com.CommandText = Query;



                connection.Open();

                if (com.ExecuteNonQuery() > 0)
                {
                    returnValue = true;

                }


                return returnValue;
            }

            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();

            }
        }

        /*public bool ExecuteQuery(string StoreProcedure, List<SqlParameter> parametros)
        {
            com = new SqlCommand();
            connection = new SqlConnection();

            bool returnValue = false;

            if (parametros.Count > 0)
            {


                foreach (var item in parametros)
                {
                    com.Parameters.Add(item);

                }
                com.Connection = connection;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = StoreProcedure;
                connection.Open();
            }


            if (com.ExecuteNonQuery() > 0)
            {

                returnValue = true;

            }

            return returnValue;
        }*/

        public DataTable ExecuteReader(string Query)
        {
            try
            {

                using (connection = new SqlConnection(connStr))
                {
                    dt = new DataSet();
                    adapter = new SqlDataAdapter();
                    com = new SqlCommand();

                    com.Connection = connection;
                    com.CommandType = CommandType.Text;
                    com.CommandText = Query;

                    adapter.SelectCommand = com;

                    adapter.Fill(dt);


                    return dt.Tables[0];

                }


            }
            catch (Exception)
            {

                throw;
            }


            return new DataTable();

           
        }
        public DataTable ExecuteReader(string StoreProcedure, List<SqlParameter> parametros)
        {

            try
            {

                using (connection = new SqlConnection(connStr))
                {
                    dt = new DataSet();
                    adapter = new SqlDataAdapter();
                    com = new SqlCommand();

                    com.Connection = connection;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = StoreProcedure;


                    adapter.SelectCommand = com;

                    adapter.Fill(dt);


                    return dt.Tables[0];

                }


            }
            catch (Exception)
            {

                throw;
            }


            return new DataTable();
           

        }

        public bool ExecuteQuery(string storedName, params SqlParameter[] arr)
        {
            connection = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(storedName, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parm in arr)
            {
                cmd.Parameters.Add(parm);
             }
            connection.Open();

            
            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;

            }else
            {
                connection.Close();
                return false;
            }

            
            
        }
    }
    
}

