#pragma checksum "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9815e00717cb99c5cedb95cf8f040f073227f07"
// <auto-generated/>
#pragma warning disable 1591
namespace SheremetievoRent.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 11 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\_Imports.razor"
using AntDesign;

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
#line 2 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
using SheremetievoRent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.Button>(2);
                __builder2.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
                          FetchTestInfo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "Проверить");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "a");
                __builder2.AddContent(8, 
#nullable restore
#line 10 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
            id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<image src=\"/Images/лого SVO 2017.png\" asp-append-version=\"true\" width=\"300\" style=\"margin-bottom: 30px\"></image>\r\n        ");
                __Blazor.SheremetievoRent.Client.Pages.Index.TypeInference.CreateRadioGroup_0(__builder2, 11, 12, "small", 13, 
#nullable restore
#line 14 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
                                 authType

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => authType = __value, authType)), 15, () => authType, 16, (__builder3) => {
                    __Blazor.SheremetievoRent.Client.Pages.Index.TypeInference.CreateRadio_1(__builder3, 17, 18, true, 19, 
#nullable restore
#line 15 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
                                        AuthType.Login

#line default
#line hidden
#nullable disable
                    , 20, (__builder4) => {
                        __builder4.AddMarkupContent(21, "Авторизация");
                    }
                    );
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __Blazor.SheremetievoRent.Client.Pages.Index.TypeInference.CreateRadio_2(__builder3, 23, 24, true, 25, 
#nullable restore
#line 16 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
                                        AuthType.Registration

#line default
#line hidden
#nullable disable
                    , 26, (__builder4) => {
                        __builder4.AddMarkupContent(27, "Регистрация");
                    }
                    );
                }
                );
#nullable restore
#line 18 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
         switch (authType)
        {
            case AuthType.Login:
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<SheremetievoRent.Client.Shared.LoginForm>(28);
                __builder2.CloseComponent();
#nullable restore
#line 23 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
                break;
            }
            case AuthType.Registration:
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<SheremetievoRent.Client.Shared.RegistrationForm>(29);
                __builder2.CloseComponent();
#nullable restore
#line 28 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
                break;
            }
            default:
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<SheremetievoRent.Client.Shared.LoginForm>(30);
                __builder2.CloseComponent();
#nullable restore
#line 33 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
                break;
            }
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Index.razor"
 
    AuthType authType = AuthType.Login;

    private enum AuthType
    {
        Login,
        Registration,
    }

    private PassportInfo testInfo = new();
    private int id = 0;

    private async Task FetchTestInfo()
    {
        var auth = await authProvider.GetAuthenticationStateAsync();
        if (auth.User.Identity.IsAuthenticated)
        {
            var claim = auth.User.FindFirst(c => c.Type == ClaimTypes.Sid);
            id = Convert.ToInt32(claim?.Value);
            testInfo = await httpClient.GetFromJsonAsync<PassportInfo>("api/users/passportinfo/" + id);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.SheremetievoRent.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadioGroup_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::AntDesign.RadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Size", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadio_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Radio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "RadioButton", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateRadio_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Radio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "RadioButton", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
