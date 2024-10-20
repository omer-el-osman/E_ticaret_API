using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface Ihelper<Table> where Table : class
    {
        List<Table> GetAll();
        Table GetById(int id);
    }
}
