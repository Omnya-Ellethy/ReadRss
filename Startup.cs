// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
// using System.Net.Http;

// namespace ReadRss
// {
//     public class Startup
//     {
//         public void ConfigureServices(IServiceCollection services)
//         {
//             services.AddRazorPages();
//             services.AddHttpClient();
//         }

//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Error");
//                 app.UseHsts();
//             }

//             app.UseHttpsRedirection();
//             app.UseStaticFiles();

//             app.UseRouting();

//             app.UseEndpoints(endpoints =>
//             {
//                 endpoints.MapRazorPages();
//             });
//         }
//     }
// }
