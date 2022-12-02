using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICrud <T>
    {
        bool Create(T objAdd);
        List<T> GetAll();
        T GetById(T objId);
        bool Update(T objUpd);
        bool Delete(T objUdp);


    
    }
}
