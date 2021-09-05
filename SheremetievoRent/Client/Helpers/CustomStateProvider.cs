using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using SheremetievoRent.Shared;

namespace SheremetievoRent.Client.Helpers
{
    public class CustomStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient httpClient;
        private readonly NavigationManager navigation;

        public CustomStateProvider(HttpClient httpClient, NavigationManager navigation)
        {
            this.navigation = navigation;
            this.httpClient = httpClient;
        }
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = await httpClient.GetFromJsonAsync<User>("api/users/current");
            if (user?.Email == null)
            {
                navigation.NavigateTo("auth");
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            var claimsIdentity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
            }, "serverAuth");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return new AuthenticationState(claimsPrincipal);
        }
    }
}