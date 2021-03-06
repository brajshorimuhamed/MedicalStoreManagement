using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.Categories;
using MedicalStoreManagement.Application.CustomerPivots;
using MedicalStoreManagement.Application.Customers;
using MedicalStoreManagement.Application.Furnitors;
using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Application.Inventories;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Application.Purchases;
using MedicalStoreManagement.Application.SalePivots;
using MedicalStoreManagement.Application.Sales;
using MedicalStoreManagement.Application.Users;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalStoreManagement.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            string connectionString = Configuration.GetConnectionString("MedicalStoreDatabase");

            services.AddDbContext<MedicalStoreDbContext>(options => options.UseSqlServer(connectionString));

            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<MedicalStoreDbContext>().AddDefaultTokenProviders();

            services.Configure<PasswordHasherOptions>(options =>
            {
                options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2;
            });

            services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;

                // Password Settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;

                // Lockout Settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User Settings.
                //options.User.AllowedUserNameCharacters =
                //"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                //options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options => {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = $"/Account/Login";

                options.SlidingExpiration = true;
            });

            services.AddTransient<IMedicalStoreDbContext, MedicalStoreDbContext>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<ISalePivotService, SalePivotService>();
            services.AddScoped<IPurchaseService, PurchaseService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IFurnitorService, FurnitorService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerPivotService, CustomerPivotService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            HttpContextHelper.Configure(app.ApplicationServices.GetRequiredService<IHttpContextAccessor>());

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=MedicalStore}/{action=Index}/{id?}");
            });
        }
    }
}
