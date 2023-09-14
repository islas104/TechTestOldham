public void ConfigureServices(IServiceCollection services)
{
    // ... other service registrations

    services.AddScoped<IAuditService, AuditService>();
}
