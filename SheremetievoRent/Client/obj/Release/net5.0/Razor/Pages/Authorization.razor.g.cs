#pragma checksum "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aa9cbf9241ca371966efc8232a23c8f403f909a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth")]
    public partial class Authorization : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<image src=\"/Images/лого SVO 2017.png\" asp-append-version=\"true\" width=\"300\" style=\"margin-bottom: 30px\"></image>\r\n");
            __Blazor.SheremetievoRent.Client.Pages.Authorization.TypeInference.CreateRadioGroup_0(__builder, 1, 2, "small", 3, 
#nullable restore
#line 4 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
                         authType

#line default
#line hidden
#nullable disable
            , 4, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => authType = __value, authType)), 5, () => authType, 6, (__builder2) => {
                __Blazor.SheremetievoRent.Client.Pages.Authorization.TypeInference.CreateRadio_1(__builder2, 7, 8, true, 9, 
#nullable restore
#line 5 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
                                AuthType.Login

#line default
#line hidden
#nullable disable
                , 10, (__builder3) => {
                    __builder3.AddMarkupContent(11, "Авторизация");
                }
                );
                __builder2.AddMarkupContent(12, "\r\n    ");
                __Blazor.SheremetievoRent.Client.Pages.Authorization.TypeInference.CreateRadio_2(__builder2, 13, 14, true, 15, 
#nullable restore
#line 6 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
                                AuthType.Registration

#line default
#line hidden
#nullable disable
                , 16, (__builder3) => {
                    __builder3.AddMarkupContent(17, "Регистрация");
                }
                );
            }
            );
#nullable restore
#line 8 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
 switch (authType)
{
    case AuthType.Login:
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SheremetievoRent.Client.Shared.LoginForm>(18);
            __builder.CloseComponent();
#nullable restore
#line 13 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
        break;
    }
    case AuthType.Registration:
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SheremetievoRent.Client.Shared.RegistrationForm>(19);
            __builder.CloseComponent();
#nullable restore
#line 18 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
        break;
    }
    default:
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SheremetievoRent.Client.Shared.LoginForm>(20);
            __builder.CloseComponent();
#nullable restore
#line 23 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
        break;
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Pages\Authorization.razor"
 
    AuthType authType = AuthType.Login;

    private enum AuthType
    {
        Login,
        Registration,
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SheremetievoRent.Client.Pages.Authorization
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
