namespace ContactsCL.IoC
{
    using Contacts.Infra.Data.Repository;
    using ContactsCL.Application.Interfaces;
    using ContactsCL.Application.Services;
    using ContactsCL.Domain.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //repository
            services.AddScoped<IContactRepository, ContactRepository>();


            //services
            services.AddScoped<IContactService, ContactService>();
        }
    }
}
