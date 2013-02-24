namespace Protozoo.Core.Entities
{
    public interface IEntity
    { 
        string Name { get; set; }
        
        string Account { get; set; }        
    }

    public class Entity: IEntity
    {
        public Entity() { }

        public Entity(string name, string account)
        {
            this.Name = name;
            this.Account = account;
        }

        public string Name { get; set; }
        
        public string Account { get; set; }        
    }
}


