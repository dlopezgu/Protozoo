using System;
using System.Collections;
using System.Collections.Generic;
using Protozoo.Core;
using Protozoo.Core.Entities;

namespace Protozoo.Ui.Presentadores
{
    public class ViewModel
    {
        private IBusiness Model;

        public ViewModel (IBusiness model)
	    {
            Match = new List<Entity>();
            Messages = new List<string>();
            Filter = 1;
            Model = model;            
            Model.SomethingIsHappening += msg => this.AddMessage(msg);
	    }

        public int Filter { get; set; }

        public IEnumerable<string> Messages { get; private set; }

        public IEnumerable<Entity> Match { get; private set; }

        public void ProcessViewRequest()
        {
            ((IList)Match).Clear();
            Entity match = null;
            try
            {
                match = Model.DoSomething(this.Filter);
            }
            catch (Exception ex)
            {
                this.AddMessage(ex.Message);
            }
            ((IList)Match).Add(match == null ? new Entity(string.Empty, string.Empty) : match);
        }

        private void AddMessage(string msg)
        {
            ((List<string>)Messages).Add(String.Format("[{0:hh:mm:ss}] {1}", DateTime.Now, msg));
        }
    }
}
