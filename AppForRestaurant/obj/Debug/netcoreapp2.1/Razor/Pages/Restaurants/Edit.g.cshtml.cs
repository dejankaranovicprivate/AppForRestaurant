#pragma checksum "F:\Projekti DOT Net Core trening\AppForRestaurant\AppForRestaurant\Pages\Restaurants\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f22966d9142c470242053ddae9dccaba149c41aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AppForRestaurant.Pages.Restaurants.Pages_Restaurants_Edit), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/Edit.cshtml", typeof(AppForRestaurant.Pages.Restaurants.Pages_Restaurants_Edit), @"{restaurantId:int}")]
namespace AppForRestaurant.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Projekti DOT Net Core trening\AppForRestaurant\AppForRestaurant\Pages\_ViewImports.cshtml"
using AppForRestaurant;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f22966d9142c470242053ddae9dccaba149c41aa", @"/Pages/Restaurants/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680ced8842606966ae768b5ce43c7e270144228f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Projekti DOT Net Core trening\AppForRestaurant\AppForRestaurant\Pages\Restaurants\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(121, 14, true);
            WriteLiteral("\r\n<h2>Editing ");
            EndContext();
            BeginContext(136, 21, false);
#line 7 "F:\Projekti DOT Net Core trening\AppForRestaurant\AppForRestaurant\Pages\Restaurants\Edit.cshtml"
       Write(Model.Restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(157, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppForRestaurant.Pages.Restaurants.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AppForRestaurant.Pages.Restaurants.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AppForRestaurant.Pages.Restaurants.EditModel>)PageContext?.ViewData;
        public AppForRestaurant.Pages.Restaurants.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
