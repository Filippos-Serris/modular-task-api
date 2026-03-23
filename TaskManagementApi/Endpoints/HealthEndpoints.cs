namespace TaskManagementApi.Endpoints
{
    public static class HealthEndpoints
    {
        public static void MapHealthEndpoints(this WebApplication app)
        {
            app.MapGet("/health", () => "Healthy");
        }
    }
}