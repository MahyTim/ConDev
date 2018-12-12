using System;
using Autofac.Multitenant;
using Microsoft.AspNetCore.Http;

namespace ConDev.WebAPI
{
    public class RequestParameterTenantStrategy : ITenantIdentificationStrategy
    {
        private Func<IHttpContextAccessor> _httpContext;

        public RequestParameterTenantStrategy(Func<IHttpContextAccessor> httpContext)
        {
            _httpContext = httpContext;
        }

        public bool TryIdentifyTenant(out object tenantId)
        {
            var context = _httpContext();
            if (context != null && context.HttpContext != null && context.HttpContext.Request.Query.ContainsKey("Tenant"))
            {
                tenantId = context.HttpContext.Request.Query["Tenant"];
                return true;
            }
            tenantId = null;
            return false;
        }
    }
}