using Microsoft.Practices.Unity;
using Protozoo.Core;
using Protozoo.Core.Tier1;
using Protozoo.Core.Tier2;
using Protozoo.Ui.Presentadores.Views;

namespace Protozoo.Ui.Presentadores
{
    public class PresenterLocator
    {
        private static IUnityContainer _container = new UnityContainer();

        private const string _RESOLVE_IMPLEMENTATION_ = "Remote-duplex";

        static PresenterLocator()
        {
            _container.RegisterType<IBusiness, BusinessFront>("Remote");
            _container.RegisterType<IBusiness, BusinessFrontDuplex>("Remote-duplex");
            _container.RegisterType<IBusiness, BusinessLayer2>("Local");
            _container.RegisterType<Presenter>();
        }

        public static Presenter Resolve(IView view)
        {
            Presenter instance = _container.Resolve<Presenter>(new ParameterOverride("model",new ResolvedParameter<IBusiness>(_RESOLVE_IMPLEMENTATION_)));
            instance.View = view;
            return instance;
        }
    }
}
