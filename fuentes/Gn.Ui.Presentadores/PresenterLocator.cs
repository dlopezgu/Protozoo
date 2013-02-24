using Microsoft.Practices.Unity;
using Protozoo.Bll.Tier1;
using Protozoo.Bll.Tier2;
using Protozoo.Core;

namespace Protozoo.Ui.Presentadores
{
    public class ControllerLocator
    {
        private static IUnityContainer _container = new UnityContainer();

        private const string _RESOLVE_IMPLEMENTATION_ = "Remote-duplex";

        static ControllerLocator()
        {            
            _container.RegisterType<IBusiness, BusinessFront>("Remote");
            _container.RegisterType<IBusiness, BusinessFrontDuplex>("Remote-duplex");
            _container.RegisterType<IBusiness, BusinessLayer2>("Local");
            _container.RegisterType<ViewModel>();
        }

        public static ViewModel GetController()
        {
            ViewModel instance = _container.Resolve<ViewModel>
                (
                    new ResolverOverride[]{
                    new ParameterOverride("model",new ResolvedParameter<IBusiness>(_RESOLVE_IMPLEMENTATION_))                    
                    }                 
                );            
            return instance;
        }
    }
}
