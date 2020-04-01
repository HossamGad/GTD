using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Yes.Do.IT.Models;

namespace Yes.Do.IT
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>(options =>
							options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();

			services.AddScoped<IMinListaRepository, MinListaRepository>();
			services.AddScoped<IUppgifterRepository, UppgifterRepository>();
			services.AddScoped<INyUppgiftRepository, NyUppgiftRepository>();


			services.AddHttpContextAccessor();
			services.AddSession();

			services.AddControllersWithViews();//services.AddMvc(); would also work still
			services.AddRazorPages();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSession();

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");

				endpoints.MapRazorPages();
			});
		}
	}
}
