#pragma checksum "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a102f6a0402ed7e7d78ee9fde341d2470fcedeb6"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAppBrazor01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using WebAppBrazor01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\_Imports.razor"
using WebAppBrazor01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddMarkupContent(6, " tong l?? : ");
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
               Tong

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n\r\n\r\n    so a: ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "number");
            __builder.AddAttribute(11, "id", "soa");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
                                       soA

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => soA = __value, soA, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "<br> <br>\r\n    so b: ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "number");
            __builder.AddAttribute(17, "id", "sob");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
                                       soB

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => soB = __value, soB, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "<br> <br>\r\n    tong : ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "number");
            __builder.AddAttribute(23, "id", "tong");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 12 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
                                                  Tong

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "<br> <br>\r\n    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "id", "btnTong");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
                                   lamToan2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, " t??nh t???ng");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, " \r\n\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\SpringProjects\canhchimMartAPI\SuperMart_Shop_Winform\superMart_Shop\superMart_Shop\WebAppBrazor01\Pages\Counter.razor"
       
    private int currentCount = 0;
    private int soA =0;
    private int soB = 0;
    private int Tong;

    private void IncrementCount()
    {
        currentCount++;
    }

    private void lamToan(int a, int b)
    {
        //return a + b;
    }
    private void lamToan2()
    {
      
        Tong = soA + soB;

        Tang();
    }
    public void Tang()
    {
        Tong++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
