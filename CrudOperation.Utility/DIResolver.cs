using CrudOperation.Core.IRepository;
using CrudOperation.Core.IService;
using CrudOperation.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudOperation.Repository.Repository;
using static CrudOperation.Service.Service.StudentService;

namespace CrudOperation.Utility
{
    public class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //for accessing the http context by interface in view level
            #region Http context
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
            //for service accesssing
            #region Service

            services.AddScoped<IService, StudentServices>();
            #endregion
            //for database accessing 
            #region Repository

            services.AddScoped<IRepository, StudentRepository>();

            #endregion


        }
    }
}
