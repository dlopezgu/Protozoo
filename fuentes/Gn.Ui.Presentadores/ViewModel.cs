using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Protozoo.Core;
using Protozoo.Core.Entities;

namespace Protozoo.Ui.Presentadores
{
    public class ViewModel
    {
        private IBusiness Model;
        public ViewModel(): this(new Protozoo.Bll.Tier1.BusinessFront())
        {
            
        }

        public ViewModel (IBusiness model)
	    {
            Match = new ObservableCollection<Entity>();
            Messages = new ObservableCollection<string>();
            Filter = 1234;
            Model = model;            
            Model.SomethingIsHappening += msg => this.AddMessage(msg);
	    }

        public int Filter { get; set; }

        public IEnumerable<string> Messages { get; private set; }

        public IEnumerable<Entity> Match { get; private set; }

        public void ProcessViewRequest()
        {
            ((IList)Match).Clear();
            ((IList)Messages).Clear();
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
            ((IList)Messages).Add(String.Format("[{0:hh:mm:ss}] {1}", DateTime.Now, msg));
        }
    }
}
