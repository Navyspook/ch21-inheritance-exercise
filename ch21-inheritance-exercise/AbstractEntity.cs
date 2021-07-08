using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public int UniqueID { get; set; }

        //public int CreateUniqueID(int uniqueID)
        //{
        //    UniqueID = 0;
        //    return UniqueID + 1;
        //}

        public AbstractEntity() { }

    }
}
