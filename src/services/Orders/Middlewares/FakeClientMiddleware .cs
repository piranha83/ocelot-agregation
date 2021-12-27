using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Orders.Middlewares
{
    ///todo: gateway auth
    public class FakeClientMiddleware 
    {
        public static readonly Guid ClientId = Guid.Parse("94acab2c-e3e0-4fce-aed8-8563dd863d44");
        public static readonly ClaimsPrincipal User = new GenericPrincipal(new GenericIdentity(ClientId.ToString()), new string[0]);
        private readonly RequestDelegate _next; 
        public FakeClientMiddleware(RequestDelegate next)  
        {  
            _next = next; 
        }
        public async Task InvokeAsync(HttpContext context)  
        {
            context.User = User;
            await this._next(context);  
        }
    }
}