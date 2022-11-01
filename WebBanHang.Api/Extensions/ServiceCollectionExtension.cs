using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace WebBanHang.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "TCT API",
					Version = "v1",
					Description = "Description for the API goes here.",
					Contact = new OpenApiContact
					{
						Name = "Ankush Jain",
						Email = string.Empty,
						Url = new Uri("https://coderjony.com/"),
					},
				});
			});
		}
    }
}
