using System;
using Protozoo.Ui.Presentadores;
using System.Web.UI;

namespace Protozoo.Ui.Web                                
{
    public partial class _Default : System.Web.UI.Page
    {       
        protected ViewModel _viewController = null;

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            _viewController = ControllerLocator.GetController();   
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ctlDo.Click += (sender, ev) => _viewController.ProcessViewRequest();            
        }

        protected void Page_Load(object sender, EventArgs e)
        {            
            _viewController.Filter = int.Parse(ctlDoContext.Text);
            this.msgList.DataSource = _viewController.Messages;
            this.view1.DataSource = _viewController.Match;
        }

        protected override void OnPreRender(EventArgs e)
        {                      
            this.view1.DataBind();
            this.msgList.DataBind();            
            base.OnPreRender(e);
        }
              
        //protected class ViewData
        //{
        //    public ViewData(object data)
        //    {
        //        Context = data;
        //    }

        //    private object Context { get; set; }

        //    public string GetValue(string propName)
        //    {
        //        return Context.GetType().GetProperty(propName).GetValue(Context, null).ToString();
        //    }
        //}
    }
}
