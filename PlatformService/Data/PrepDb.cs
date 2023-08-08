using Microsoft.Identity.Client;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {

            }
        }

        public static void SeedData(ApplicationDbContext db)
        {

        }
    }
}