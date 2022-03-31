using GroupeIsa.Neos.AspNetCore.Swagger;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace UserVoice.AspNetCore.Swagger
{
    /// <summary>
    /// Represents the Swagger configuration.
    /// </summary>
    public class ConfigureSwaggerOptions : ConfigureSwaggerOptionsBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureSwaggerOptions"/> class.
        /// </summary>
        /// <param name="provider">The <see cref="IApiVersionDescriptionProvider"/> service use to generate the Swagger documents.</param>
        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
            : base(provider)
        {
        }

        /// <inheritdoc/>
        public override string Title
        {
            get { return Properties.Resources.Swagger_Title; }
        }

        /// <inheritdoc/>
        public override string Description
        {
            get { return Properties.Resources.Swagger_Description; }
        }
    }
}