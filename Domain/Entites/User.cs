using Domain.Abstraction.Base;

namespace Domain.Entites
{
    public class User : Entity
    {
        public User() { }
        public User(Guid id) : base(id) { }
        
    }
}
