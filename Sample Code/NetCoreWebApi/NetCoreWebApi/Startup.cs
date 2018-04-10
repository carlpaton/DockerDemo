using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;

namespace NetCoreWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //DI Repository
            //services.AddTransient<IStaffMasterRepository, Repository.Implementation.PostgreSQL.EmployeeRepository>();
            //services.AddTransient<IStaffMasterRepository, Repository.Implementation.MySQL.EmployeeRepository>();

            //DI for appsettings ~ https://blog.elmah.io/appsettings-in-aspnetcore/
            //Cant use DI when more than one db uses the same interface, so I moved the connection strings for 'ConnMySQL' & 'ConnPgSQL' to appsettings
            var appSettings = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettings);

            //https://cmatskas.com/net-core-dependency-injection-with-constructor-parameters-2/
            var connMsSQL = Configuration.GetConnectionString("ConnMsSQL");
            services.AddTransient<IStaffMasterRepository> (s => new Repository.Implementation.MsSQL.StaffMasterRepository(connMsSQL));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
