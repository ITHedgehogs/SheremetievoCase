#pragma checksum "F:\Хакатоны\SheremetievoCase\SheremetievoRent\Client\Shared\Cabinet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f493e8dcc79f2b447c94a41d8ff43d225dc7d1"
// <auto-generated/>
#pragma warning disable 1591
namespace SheremetievoRent.Client.Shared
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
    public partial class Cabinet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Tabs>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.TabPane>(2);
                __builder2.AddAttribute(3, "Key", "1");
                __builder2.AddAttribute(4, "Tab", "Профиль");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            Content of Tab Pane 1\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<AntDesign.TabPane>(8);
                __builder2.AddAttribute(9, "Key", "2");
                __builder2.AddAttribute(10, "Tab", "Помещения");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n            Content of Tab Pane 2\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<AntDesign.TabPane>(14);
                __builder2.AddAttribute(15, "Key", "3");
                __builder2.AddAttribute(16, "Tab", "Транзакции");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n            Content of Tab Pane 3\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<AntDesign.TabPane>(20);
                __builder2.AddAttribute(21, "Key", "4");
                __builder2.AddAttribute(22, "Tab", "Календарь");
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n            Content of Tab Pane 4\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<AntDesign.TabPane>(26);
                __builder2.AddAttribute(27, "Key", "5");
                __builder2.AddAttribute(28, "Tab", "Настройки");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n            Content of Tab Pane 5\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenComponent<AntDesign.TabPane>(32);
                __builder2.AddAttribute(33, "Key", "6");
                __builder2.AddAttribute(34, "Tab", "Документы");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "\r\n            Content of Tab Pane 6\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591