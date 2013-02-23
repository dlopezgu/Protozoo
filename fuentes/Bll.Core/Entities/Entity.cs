namespace Protozoo.Core.Entities
{
    public enum EntityStatus
    { 
        Clean = 0,
        Changed = 1,
        Deleted = 2
    }

    public class Entity 
    {
        public Entity() { }

        /// <summary>
        /// Indica si ha habido modificaciones sobre la entidad:
        /// Borrada, modificada, sin modificaciones.
        /// </summary>
        public EntityStatus Status { get; set; }

        #region Elementos de una entidad concreta
        public Entity(string name, string account)
        {
            this.Name = name;
            this.Account = account;
        }

        public string Name { get; set; }
        
        public string Account { get; set; }
        #endregion
    }
}


