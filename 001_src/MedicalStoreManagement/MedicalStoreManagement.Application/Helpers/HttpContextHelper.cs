using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Application.Helpers
{
    public static class HttpContextHelper
    {
        public static IHttpContextAccessor _httpContextAccessor;
        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public static HttpContext Context => _httpContextAccessor.HttpContext;
    }
}
