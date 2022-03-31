using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using GroupeIsa.Neos.AspNetCore;
using GroupeIsa.Neos.Shared.Localization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserVoice.Application;
using UserVoice.AspNetCore.Swagger;
using UserVoice.Persistence;

namespace UserVoice.AspNetCore
{
    /// <summary>
    /// Represents the start-up process of the application.
    /// </summary>
    public class Startup : StartupBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The current configuration.</param>
        public Startup(IConfiguration configuration)
            : base(configuration)
        {
        }

        /// <inheritdoc/>
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            // Strongly typed settings objects configuration
            services.Configure<PersistenceSettings>(PersistenceSettingsSection);
            PersistenceServices.Configure(services);
            DomainServices.Configure(services);
            ApplicationServices.Configure(services);

            string xmlCommentsFilePath = Path.Combine(
                AppContext.BaseDirectory,
                $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");
            AddSwagger<ConfigureSwaggerOptions>(services, xmlCommentsFilePath);

            LocalizationSettings.Instance.SetLanguages(new[] { "en" });
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new CultureInfo[] { new("en") };
                options.DefaultRequestCulture = new RequestCulture(culture: "en", uiCulture: "en");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
        }
    }
}