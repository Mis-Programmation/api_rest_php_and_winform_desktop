using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_donet_and_php.service
{
    public interface Iservice
    {

        Object add(Object o);
        Object update(Object o);
        bool delete(int id);
        List<Object> getAll();
        
    }
}
