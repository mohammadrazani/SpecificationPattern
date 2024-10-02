namespace API.Extensions
{
    public static class WebApplicationExtension
    {
        public static void ConfigureApiApplication(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
