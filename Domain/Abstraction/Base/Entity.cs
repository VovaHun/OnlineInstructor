using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction.Base
{
    public abstract class Entity
    {
        protected Entity() { }

        protected Entity(Guid id) => Id = id;

        public Guid Id { get; init; }
    }
}
