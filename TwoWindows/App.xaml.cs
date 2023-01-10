using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TwoWindows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IServiceProvider? _services;

        public static IServiceProvider? Services => _services ??= InitializeService().BuildServiceProvider();

        private static IServiceCollection InitializeService()
        {
            var services = new ServiceCollection();


            return services;
        }
    }
}
