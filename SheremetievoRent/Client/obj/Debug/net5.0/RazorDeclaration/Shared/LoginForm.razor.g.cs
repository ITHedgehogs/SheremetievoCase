// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SheremetievoRent.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using SheremetievoRent.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using SheremetievoRent.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\LoginForm.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\LoginForm.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\LoginForm.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\LoginForm.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\LoginForm.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\LoginForm.razor"
using SheremetievoRent.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginForm : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\LoginForm.razor"
 
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }

    private LoginModel loginModel = new LoginModel();

    protected async Task LoginAsync()
    {
        await httpClient.PostAsJsonAsync("api/users/login",
            new User() {Email = loginModel.Email, Password = loginModel.Password});
        navigation.NavigateTo("/", true);
    }

    private void OnFinishFailed(EditContext editContext)
    {
        Console.WriteLine($"Failed:{JsonSerializer.Serialize(loginModel)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
