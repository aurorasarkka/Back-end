﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Middleware
{
    public class ApiKeyMiddleware
    {
        private RequestDelegate _next;
        private const string APIKEYNAME = "ApiKey";
        public ApiKeyMiddleware(RequestDelegate next)
        {

            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if(!context.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Api key missing");
                return;
            }

            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSettings.GetValue<string>(APIKEYNAME);
            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Unauthorized client");
                return;

            }
            await _next(context);
        }
            
    }
}
