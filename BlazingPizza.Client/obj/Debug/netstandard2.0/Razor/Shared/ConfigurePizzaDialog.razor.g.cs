#pragma checksum "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6733c7b112cbcfa31a97741edfb46d2efe76dab"
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
    public class ConfigurePizzaDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialog-container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "dialog");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "dialog-title");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h2");
            __builder.AddContent(10, 
#line 5 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 Pizza.Special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n             ");
            __builder.AddContent(12, 
#line 6 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
              Pizza.Special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "form");
            __builder.AddAttribute(16, "class", "dialog-body");
            __builder.AddMarkupContent(17, "\r\n         ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n             ");
            __builder.AddMarkupContent(20, "<label>Size:</label>\r\n             ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "range");
            __builder.AddAttribute(23, "min", 
#line 11 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                       Pizza.MinimumSize

#line default
#line hidden
            );
            __builder.AddAttribute(24, "max", 
#line 11 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                Pizza.MaximumSize

#line default
#line hidden
            );
            __builder.AddAttribute(25, "step", "1");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 11 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                                    Pizza.Size

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pizza.Size = __value, Pizza.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n             ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "size-label");
            __builder.AddMarkupContent(31, "\r\n                 ");
            __builder.AddContent(32, 
#line 13 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                   Pizza.Size

#line default
#line hidden
            );
            __builder.AddMarkupContent(33, "\"(£");
            __builder.AddContent(34, 
#line 13 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                   Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(35, ")\r\n             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<label>Extra Toppings:</label>\r\n");
#line 18 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
             if(toppings==null)
            {

#line default
#line hidden
            __builder.AddContent(41, "                ");
            __builder.OpenElement(42, "select");
            __builder.AddAttribute(43, "class", "custom-select");
            __builder.AddAttribute(44, "disabled", true);
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "option");
            __builder.AddContent(47, "loading....");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#line 23 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
            }
            else if(Pizza.Toppings.Count >=6)
            {

#line default
#line hidden
            __builder.AddContent(50, "                ");
            __builder.AddMarkupContent(51, "<div>(maximum reached)</div>\r\n");
#line 27 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(52, "                ");
            __builder.OpenElement(53, "select");
            __builder.AddAttribute(54, "class", "custom-select");
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 30 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                          ToppingSelected

#line default
#line hidden
            ));
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "-1");
            __builder.AddAttribute(59, "disabled", true);
            __builder.AddAttribute(60, "selected", true);
            __builder.AddContent(61, "(select)");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#line 32 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                     for (var i = 0; i < toppings.Count; i++)
                    {

#line default
#line hidden
            __builder.AddContent(63, "                        ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", 
#line 34 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                        i

#line default
#line hidden
            );
            __builder.AddContent(66, 
#line 34 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                            toppings[i].Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(67, " - (£");
            __builder.AddContent(68, 
#line 34 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                   toppings[i].GetFormattedPrice()

#line default
#line hidden
            );
            __builder.AddContent(69, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#line 35 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                    }

#line default
#line hidden
            __builder.AddContent(71, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#line 37 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
            }

#line default
#line hidden
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "toppings");
            __builder.AddMarkupContent(77, "\r\n");
#line 41 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
             foreach (var topping in Pizza.Toppings)
            {

#line default
#line hidden
            __builder.AddContent(78, "                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "topping");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.AddContent(82, 
#line 44 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                     topping.Topping.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "span");
            __builder.AddAttribute(85, "class", "topping-price");
            __builder.AddContent(86, 
#line 45 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                 topping.Topping.GetFormattedPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "type", "button");
            __builder.AddAttribute(90, "class", "delete-topping");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 46 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                             ()=>RemoveTopping(topping.Topping)

#line default
#line hidden
            ));
            __builder.AddContent(92, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#line 48 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
            }

#line default
#line hidden
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "dialog-buttons");
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "class", "btn btn-secondary mr-auto");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 53 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                 OnCancel

#line default
#line hidden
            ));
            __builder.AddContent(104, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.OpenElement(106, "span");
            __builder.AddAttribute(107, "class", "mr-center");
            __builder.AddMarkupContent(108, "\r\n                Price: ");
            __builder.OpenElement(109, "span");
            __builder.AddAttribute(110, "class", "price");
            __builder.AddContent(111, 
#line 55 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                             Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddContent(112, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.OpenElement(115, "button");
            __builder.AddAttribute(116, "class", "btn btn-success ml-auto");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 57 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                               OnConfirm

#line default
#line hidden
            ));
            __builder.AddContent(118, "Order >");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 62 "G:\Dropbox\Dropbox\Development-2019\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
       
    List<Topping> toppings;

    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }
    protected async override Task OnInitializedAsync()
    {
        toppings = await HttpClient.GetJsonAsync<List<Topping>>("toppings");
    }
    void ToppingSelected(ChangeEventArgs e)
    {
        if(int.TryParse((string)e.Value, out var index) && index >=0)
        {
            AddTopping(toppings[index]);
        }
    }
    void AddTopping(Topping topping)
    {
        if(Pizza.Toppings.Find(pt=>pt.Topping == topping)==null)
        {
            Pizza.Toppings.Add(new PizzaTopping() {Topping = topping });
        }
    }
    void RemoveTopping(Topping topping)
    {
        Pizza.Toppings.RemoveAll(pt => pt.Topping == topping);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
