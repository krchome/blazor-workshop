#pragma checksum "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eb3057f4dc9a94e12960688f590ba849c0d5e23"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
    public class ConfiguredPizzaItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cart-item");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                  OnRemoved

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "class", "delete-item");
            __builder.AddContent(6, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "title");
            __builder.AddContent(10, 
#line 4 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                         Pizza.Size

#line default
#line hidden
            );
            __builder.AddContent(11, "\"");
            __builder.AddContent(12, 
#line 4 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                                      Pizza.Special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddMarkupContent(15, "\r\n");
#line 6 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
         foreach (var topping in Pizza.Toppings)
        {

#line default
#line hidden
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "li");
            __builder.AddContent(18, "+ ");
            __builder.AddContent(19, 
#line 8 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                   topping.Topping.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#line 9 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
        }

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "item-price");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddContent(26, 
#line 12 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
         Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 16 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
       
    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnRemoved { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
