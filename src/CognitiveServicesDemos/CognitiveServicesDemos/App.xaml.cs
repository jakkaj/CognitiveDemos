using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;

namespace CognitiveServicesDemos
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var c = new ContainerBuilder();
            c.RegisterAssemblyTypes(typeof(App).Assembly)
                .Where(_ => _.FullName.EndsWith("View") || _.FullName.EndsWith("ViewModel"))
                .AsSelf();

            Container = c.Build();
        }
    }
}
