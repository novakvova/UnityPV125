using Microsoft.EntityFrameworkCore;
using ProjectManagement.Infrastructure;
using System;

namespace ServiceOne.API.Infrastructure
{
    public static class SeederDB
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices
                    .GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDataContext>();
                context.Database.Migrate();
            }
        }
    }
}
