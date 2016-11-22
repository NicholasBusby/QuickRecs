using Microsoft.Practices.Unity;
using ModernHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuickRecs.Service
{
    public class Dependancy
    {
        public static void Initialize()
        {
            App.DependancyContainer = new UnityContainer();
            App.DependancyContainer.RegisterType<HttpMessageHandler>(new InjectionFactory(x => new NativeMessageHandler()));
            App.DependancyContainer.RegisterType<TasteKid>();
        }
    }
}
