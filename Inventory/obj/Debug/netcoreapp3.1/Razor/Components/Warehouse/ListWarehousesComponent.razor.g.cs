#pragma checksum "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e2633f85d7574857c064a85497cdb758b1156aa"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Warehouse
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListWarehousesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"warehouse/create\">Agregar Nueva Bodega</a>\r\n<hr>\r\n\r\n");
#nullable restore
#line 8 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
 if (warehouses == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Cargando...</em></p>\r\n");
#nullable restore
#line 11 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "display table table-bordered table-hover");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Referencia</th>\r\n                <th>Bodega</th>\r\n                <th>Dirección</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 24 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
             foreach (var warehouse in warehouses)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 27 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
__builder.AddContent(15, warehouse.WareHouseId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 28 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
__builder.AddContent(18, warehouse.WareHouseName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 29 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
__builder.AddContent(21, warehouse.WareHouseAddress);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "product/update/" + (
#nullable restore
#line 30 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
                                                 warehouse.WareHouseId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Actualizar Bodega");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 32 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 35 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Platzi\Blazor\Inventory\Inventory\Components\Warehouse\ListWarehousesComponent.razor"
      
    [Parameter]
    public string ToPage { get; set; }

    List<WareHouseEntity> warehouses = new List<WareHouseEntity>();

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_WareHouse.WareHouseList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
