#pragma checksum "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1b96b017996eba61bc79eb4148fe613f5eb15c6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGalaga.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions.Canvas.Canvas2D;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions.Canvas.WebGL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\r\n\r\n    .content {\r\n        padding: 0px !important;\r\n    }\r\n\r\n    div.context.px-4 {\r\n        padding: 0px !important;\r\n    }\r\n\r\n    .main > div {\r\n        padding: 0px !important;\r\n    }\r\n\r\n        #theCanvas canvas {\r\n            display: block;\r\n            width: 100%;\r\n            height: 100%;\r\n            position: absolute;\r\n        }\r\n\r\n    #theCanvas canvas:first-child {\r\n        z-index: 1;\r\n    }\r\n\r\n    #theCanvas canvas:last-child {\r\n        z-index: 1000;\r\n    }\r\n\r\n    .twinkle {\r\n        background: transparent url(\'Assets/twinkling.png\') repeat top center;\r\n        display: block;\r\n        width: 100%;\r\n        height: 100%;\r\n        position: absolute;\r\n        z-index: -50;\r\n        -webkit-animation: move-twink-back 90s linear infinite;\r\n        -moz-animation: move-twink-back 90s linear infinite;\r\n        -o-animation: move-twink-back 90s linear infinite;\r\n        animation: move-twink-back 90s linear infinite;\r\n    }\r\n\r\n    .background {\r\n        display: block;\r\n        width: 100%;\r\n        height: 100%;\r\n        position: absolute;\r\n        background-image: url(\'Assets/Background.png\');\r\n        z-index: -100;\r\n    }\r\n\r\n    .backgroundmoving {\r\n        -webkit-animation: animatedBackground 5s linear infinite;\r\n        -moz-animation: animatedBackground 5s linear infinite;\r\n        -o-animation: animatedBackground 5s linear infinite;\r\n        animation: animatedBackground 5s linear infinite;\r\n    }\r\n\r\n    #divBufferCanvas canvas {\r\n        background-color: black;\r\n        display: block;\r\n    }\r\n\r\n    #divBigBufferCanvas canvas {\r\n        background-color: black;\r\n        display: block;\r\n    }\r\n\r\n    #divBiggerBufferCanvas canvas {\r\n        background-color: black;\r\n        display: block;\r\n    }\r\n\r\n    body {\r\n        overflow-y: hidden; /* Hide vertical scrollbar */\r\n        overflow-x: hidden; /* Hide horizontal scrollbar */\r\n    }\r\n    </style>\r\n\r\n    ");
            __builder.AddMarkupContent(1, @"<div id=""divDebugDash"" style=""position:absolute;left:15px;top:15px;width:300px;height:250px;background-color:lightgray;padding:5px;font-size:10px;font-size:10px"">
        <input type=""checkbox"" id=""PauseAnimation"">
        <label for=""PauseAnimation"">Pause Animation</label>
        <br>
        <input type=""checkbox"" id=""EditCurves"">
        <label for=""EditCurves"">Edit Curves</label>
        <br>
        <button id=""btnKillAllBugs"">Kill Bugs</button>
        <br><br>
        <button id=""btnCaptureShip"">Capture Ship</button>
        <br><br>
        <button id=""btnMorphBug"">Morph Bug</button>
        <br><br>
        <button id=""btnResetAnimation"">Reset Animation</button>
        <br><br>
    </div>

");
            __builder.AddMarkupContent(2, "<div id=\"divDiagnostics\" style=\"position:absolute;left:15px;top:290px;width:300px;height:400px;background-color:lightgray;padding:5px;font-size:10px;font-size:10px;overflow:scroll\">\r\n</div>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "divBufferCanvas");
            __builder.AddAttribute(5, "style", "position:absolute;right:0px;top:15px;opacity:1");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 104 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
     if (BufferCanvases != null && BufferCanvases.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         foreach (var canvas in BufferCanvases)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(8);
            __builder.AddAttribute(9, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 108 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                              canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 108 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                     canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(11, (__value) => {
#nullable restore
#line 108 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                                           canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 109 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "divBigBufferCanvas");
            __builder.AddAttribute(16, "style", "position:absolute;right:50px;top:15px;opacity:1");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 113 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
     if (BigBufferCanvases != null && BigBufferCanvases.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         foreach (var canvas in BigBufferCanvases)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(19);
            __builder.AddAttribute(20, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 117 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                              canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 117 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                     canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(22, (__value) => {
#nullable restore
#line 117 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                                           canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 118 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "id", "divBiggerBufferCanvas");
            __builder.AddAttribute(27, "style", "position:absolute;right:150px;top:15px;opacity:1");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 122 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
     if (BiggerBufferCanvases != null && BiggerBufferCanvases.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         foreach (var canvas in BiggerBufferCanvases)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "            ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(30);
            __builder.AddAttribute(31, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 126 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                              canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 126 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                     canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(33, (__value) => {
#nullable restore
#line 126 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                                           canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 127 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "id", "theCanvas");
            __builder.AddAttribute(38, "style", "position: fixed; opacity: 1; background-color: black; width: 100%; height: 100%;");
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(40);
            __builder.AddAttribute(41, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 131 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                     672

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 131 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                  944

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(43, (__value) => {
#nullable restore
#line 131 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                             DynamicCanvas1 = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(45);
            __builder.AddAttribute(46, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 132 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                     672

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 132 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                  944

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(48, (__value) => {
#nullable restore
#line 132 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                             StaticCanvas = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n    <div class=\"twinkle\"></div>\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", 
#nullable restore
#line 134 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                 BackGroundClass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenElement(54, "img");
            __builder.AddAttribute(55, "id", "imgSpriteSheet");
            __builder.AddAttribute(56, "style", "display:none");
            __builder.AddAttribute(57, "src", "Assets/spritesheet.png");
            __builder.AddElementReferenceCapture(58, (__value) => {
#nullable restore
#line 137 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                    spriteSheet = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.AddMarkupContent(60, "<div style=\"font-family: PressStart2P;\">.</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
