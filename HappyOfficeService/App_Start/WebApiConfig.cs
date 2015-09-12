using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using HappyOfficeService.DataObjects;
using HappyOfficeService.Models;

namespace HappyOfficeService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            
            // Set default and null value handling to "Include" for Json Serializer
            config.Formatters.JsonFormatter.SerializerSettings.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;
            
            Database.SetInitializer(new HappyOfficeInitializer());
        }
    }

    public class HappyOfficeInitializer : ClearDatabaseSchemaIfModelChanges<HappyOfficeContext>
    {
        protected override void Seed(HappyOfficeContext context)
        {
            List<Point> points = new List<Point>
            {
                new Point { Id = Guid.NewGuid().ToString(), Altitude = 0, Desibel = 0, Latitude = 0, Longitude = 0, Lux = 0, Username = "Santeri" },
                new Point { Id = Guid.NewGuid().ToString(), Altitude = 1.0, Desibel = 1.0, Latitude = 1.0, Longitude = 1.0, Lux = 1.0, Username = "Teemu" },
            };

            foreach (Point point in points)
            {
                context.Set<Point>().Add(point);
            }

            base.Seed(context);
        }
    }
}

