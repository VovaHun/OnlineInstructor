using Domain.Abstraction.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Schedule : Entity
    {
        public Schedule() { }
        public Schedule(Guid id) : base(id) { }
    }
}
