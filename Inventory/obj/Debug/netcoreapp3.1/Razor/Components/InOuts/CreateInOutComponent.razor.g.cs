#pragma checksum "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e907c9ee6afcf0ce5ff2f8842c6f2447ed0b20c"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.InOuts
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
#line 14 "D:\Platzi\Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateInOutComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                                            OnChangedWarehouse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", true);
            __builder.AddContent(9, "Seleccione una bodega");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 7 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
         foreach (var warehouse in warehouses)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 9 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                            warehouse.WareHouseId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
__builder.AddContent(14, warehouse.WareHouseName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                 oInOutPut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __Blazor.Inventory.Components.InOuts.CreateInOutComponent.TypeInference.CreateInputSelect_0(__builder2, 26, 27, "form-control", 28, 
#nullable restore
#line 18 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                                                       oInOutPut.StorageId

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oInOutPut.StorageId = __value, oInOutPut.StorageId)), 30, () => oInOutPut.StorageId, 31, (__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.AddMarkupContent(33, "<option value>Seleccione una producto</option>\r\n");
#nullable restore
#line 20 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
             foreach (var storage in storages)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(34, "                ");
                    __builder3.OpenElement(35, "option");
                    __builder3.AddAttribute(36, "value", 
#nullable restore
#line 22 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                                storage.StorageId

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 22 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
__builder3.AddContent(37, storage.Product.ProductName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n");
#nullable restore
#line 23 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(39, "        ");
                }
                );
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.AddMarkupContent(45, "<label>Escriba la Cantidad</label>\r\n        ");
                __Blazor.Inventory.Components.InOuts.CreateInOutComponent.TypeInference.CreateInputNumber_1(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 28 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                                                       oInOutPut.Quantity

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oInOutPut.Quantity = __value, oInOutPut.Quantity)), 50, () => oInOutPut.Quantity);
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "label");
#nullable restore
#line 31 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
__builder2.AddContent(57, question);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                                                         oInOutPut.IsInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oInOutPut.IsInput = __value, oInOutPut.IsInput))));
                __builder2.AddAttribute(63, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => oInOutPut.IsInput));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.OpenElement(66, "input");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "type", "button");
                __builder2.AddAttribute(69, "value", 
#nullable restore
#line 34 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                                                      buttonValue

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
                                                                             SaveInOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n\r\n");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "text-center h4");
            __builder.AddMarkupContent(75, "\r\n    ");
#nullable restore
#line 38 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
__builder.AddContent(76, message);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\Platzi\Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
       
    InputOutputEnitity oInOutPut = new InputOutputEnitity();
    List<WareHouseEntity> warehouses = new List<WareHouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();

    ProductEntity oProduct = new ProductEntity();
    StorageEntity oStorage = new StorageEntity();

    string question { get => oInOutPut.IsInput ? "??Es una Entrada?" : "??Es una Salida?"; }
    string buttonValue => oInOutPut.IsInput ? "Registrar Entrada" : "Registrar Salida";

    string message;

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_WareHouse.WareHouseList();
    }

    private void OnChangedWarehouse(ChangeEventArgs e)
    {
        var idWarehouse = e.Value.ToString();
        storages = B_Storage.StorageProductByWarehouse(idWarehouse);
    }

    private void SaveInOut()
    {
        oStorage = storages.LastOrDefault(x => x.StorageId == oInOutPut.StorageId);
        oProduct = oStorage.Product;

        if (oInOutPut.IsInput)
        {
            oStorage.PartialQuantity = oStorage.PartialQuantity + oInOutPut.Quantity;
            B_Storage.UpdateStorage(oStorage);

            oProduct.TotalQuantity = oProduct.TotalQuantity + oInOutPut.Quantity;
            B_Product.Updateroduct(oProduct);

            message = $"El producto {oProduct.ProductName} ha sido actualizado";
        }
        else
        {
            if (IsBiggerThanZero(oInOutPut.Quantity, oStorage.PartialQuantity))
            {
                oStorage.PartialQuantity = oStorage.PartialQuantity - oInOutPut.Quantity;
                B_Storage.UpdateStorage(oStorage);

                oProduct.TotalQuantity = oProduct.TotalQuantity - oInOutPut.Quantity;
                B_Product.Updateroduct(oProduct);

                message = $"El producto {oProduct.ProductName} ha sido actualizado";
            }
            else
            {
                message = $"No existe la cantidad suficiente en bodega para el producto {oProduct.ProductName}, la cantidad actual es {oStorage.PartialQuantity}";
            }
        }
    }

    private bool IsBiggerThanZero(int quantity, int storageQuantiy)
    {
        if (storageQuantiy >= quantity)
        {
            return true;
        }
        return false;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Inventory.Components.InOuts.CreateInOutComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
