using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Web.UmbracoProject.Infrastructure.Components.Serveses;
using Web.UmbracoProject.Infrastructure.Components.Serveses.Contract;

namespace Web.UmbracoProject.Infrastructure.Utility
{
    public class ClassInitialiseUmbraco : IUserComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddScoped<IUmbracoHelperServeses, UmbracoHelperServeses>();
        }
    }
}
