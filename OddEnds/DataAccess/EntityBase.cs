using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OddEnds.DataAccess.Abstractions;

namespace OddEnds.DataAccess
{
    public abstract class EntityBase : IEntity
    {
        public int ID { get; set; }
    }
}
