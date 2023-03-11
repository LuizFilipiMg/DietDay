﻿using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Middleware
{
    public class ErrorMiddleware
    {
        
            private readonly RequestDelegate next;

            public ErrorMiddleware(RequestDelegate next)
            {
                this.next = next;
            }

            public async Task Invoke(HttpContext context)
            {
                try
                {
                    await next(context);
                }
                catch (Exception ex)
                {
                    await HandleExceptionAsync(context, ex);
                }
            }

            private Task HandleExceptionAsync(HttpContext context, Exception ex)
            {
            //TODO: Gravar log de erro com o trace id

            VielModelErrorResponse vielModelErrorResponse;

                if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ||
                    Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Qa")
                {
                vielModelErrorResponse = new VielModelErrorResponse(HttpStatusCode.InternalServerError.ToString(),
                                                          $"{ex.Message} {ex?.InnerException?.Message}");
                }
                else
                {
                //Homologação, Pre Prod, Produção...

                vielModelErrorResponse = new VielModelErrorResponse(HttpStatusCode.InternalServerError.ToString(),
                                                          "An internal server error has occurred.");
                }

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var result = JsonConvert.SerializeObject(vielModelErrorResponse);
                context.Response.ContentType = "application/json";
                return context.Response.WriteAsync(result);
            }
        }
    
}
