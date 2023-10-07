using FlexReport.Application.Services.Abstractions;
using FlexReport.Application.Services.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FlexReport.Application.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IDbSchemaGenerator, DbSchemaGenerator>();
        services.AddScoped<ICustomerService, CustomerService>();

        return services;
    }
}