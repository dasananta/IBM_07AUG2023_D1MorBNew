namespace IBM_07AUG2023_D1MorBNew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<Models.IBM7AUG2023MorBatNGDbContext>();  

         builder.Services.AddScoped( typeof( Models.IProductLocalContext),typeof(Models.ProductLocalContext)  );

            
 builder.Services.AddSingleton(  typeof( Models.IProductLocalContext) ,(sp) => {
     
     
     return new Models.ProductLocalContext();   }  );


            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Course}/{action=Index}/{id?}");

            app.Run();
        }
    }
}