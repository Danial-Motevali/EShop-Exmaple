using App.Domain.AppService.Shop;
using App.Domain.Core.Shop.Contacts.AppService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IProductAppService, ProductAppService>();
            service.AddScoped<ICategoryAppService, CategoryAppService>();

            return service;
        }
    }
}
