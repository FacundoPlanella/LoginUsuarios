using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario : BE.ICrud<BE.Usuario>
    {

        /// Singleton .
        /// 

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
                return DAOs.Usuario.GetInstance().Insert(objAdd);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<BE.Usuario> GetAll()
        {
            try
            {

                return Mappers.Usuario.GetInstance().Map(DAOs.Usuario.GetInstance().SelectAll());

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
                return DAOs.Usuario.GetInstance().Update(objUpd);

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
                return DAOs.Usuario.GetInstance().Delete(objUdp);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
