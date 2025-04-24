using Avalonia.Logging;
using Microsoft.Extensions.DependencyInjection;
using PetraqTerminal.ViewModels;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PetraqTerminal
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommonServices(this IServiceCollection collection)
        {
            collection.AddSingleton<MainViewModel>();
        }
    }
}
