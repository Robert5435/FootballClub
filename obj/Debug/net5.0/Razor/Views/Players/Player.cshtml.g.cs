#pragma checksum "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a989b38e5d078c1d959ed602fdf7199602ba2ccb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_Player), @"mvc.1.0.view", @"/Views/Players/Player.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\bloo\source\repos\Football\Football\Views\_ViewImports.cshtml"
using Football;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bloo\source\repos\Football\Football\Views\_ViewImports.cshtml"
using Football.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a989b38e5d078c1d959ed602fdf7199602ba2ccb", @"/Views/Players/Player.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390cebe156358e6bcac9e654035a36fde16d049a", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_Player : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Football.Models.Player>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-polaroid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Christopher Herrera"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Christopher Herrera"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
  
    ViewData["Title"] = "Player";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""tm-isblog tt-players-page"">
    <div class=""over-wrap"">

        <div class=""tm-top-a-box tm-full-width tm-box-bg-1 "">
            <div class=""uk-container uk-container-center"">
                <section id=""tm-top-a"" class=""tm-top-a uk-grid uk-grid-collapse"" data-uk-grid-match=""{target:'> div > .uk-panel'}"" data-uk-grid-margin="""">

                    <div class=""uk-width-1-1 uk-row-first"">
                        <div class=""uk-panel"">
                            <div class=""uk-cover-background uk-position-relative head-wrap"" style=""height: 290px; background-image: url('../../images/head-bg.jpg');"">
                                <img class=""uk-invisible"" src=""../../images/head-bg.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 797, "\"", 803, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""290"" width=""1920"">
                                <div class=""uk-position-cover uk-flex uk-flex-center head-title"">
                                    <h1>Players</h1>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>


        <div class=""uk-container uk-container-center"">
            <div id=""tm-middle"" class=""tm-middle uk-grid"" data-uk-grid-match="""" data-uk-grid-margin="""">
                <div class=""tm-main uk-width-medium-1-1 uk-row-first"">
                    <div id=""tm-content"" class=""tm-content"">
                        <div id=""system-message-container""></div>
                        <div class=""contentpaneopen"">
                            <article class=""player-single tt-players-page"">
                                <div class=""uk-container uk-container-center alt"">
                                    <div class=""uk-gfid"">
 ");
            WriteLiteral(@"                                   </div>
                                </div>
                                <div class=""player-top"">
                                    <div class=""uk-container uk-container-center alt"">
                                        <div class=""uk-grid"">
                                            <div class=""uk-width-5-12"">
                                                <div class=""avatar"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a989b38e5d078c1d959ed602fdf7199602ba2ccb6855", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2325, "~/images/", 2325, 9, true);
#nullable restore
#line 46 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
AddHtmlAttributeValue("", 2334, Model.Photo, 2334, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""uk-width-1-12"">
                                                <div class=""number"">
                                                    ");
#nullable restore
#line 51 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                               Write(Html.DisplayFor(model => model.PlayerNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""uk-width-6-12"">
                                                <div class=""name"">
                                                    <h2>
                                                        ");
#nullable restore
#line 57 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </h2>
                                                </div>
                                                <div class=""wrap"">
                                                    <ul class=""info"">
                                                        <li><span>POSITION</span><span>");
#nullable restore
#line 62 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        <li><span>APPEARANCES</span><span>");
#nullable restore
#line 63 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                                     Write(Html.DisplayFor(model => model.Apperances));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        <li><span>GOALs</span><span>");
#nullable restore
#line 64 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                               Write(Html.DisplayFor(model => model.Goals));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        <li><span>YELLOW CARDS</span><span>");
#nullable restore
#line 65 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.YellowCards));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        <li><span>RED CARDS</span><span>");
#nullable restore
#line 66 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.RedCards));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        <li><span>D.O.B</span><span>");
#nullable restore
#line 67 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                               Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        <li><span>NATIONALITY</span><span>");
#nullable restore
#line 68 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                                     Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        <li><span>HEIGHT</span><span>");
#nullable restore
#line 69 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                                Write(Html.DisplayFor(model => model.HeightInMeters));

#line default
#line hidden
#nullable disable
            WriteLiteral(".0M</span></li>\r\n                                                        <li><span>WEIGHT</span><span>");
#nullable restore
#line 70 "C:\Users\bloo\source\repos\Football\Football\Views\Players\Player.cshtml"
                                                                                Write(Html.DisplayFor(model => model.WeihtInKilograms));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" KG</span></li>
                                                    </ul>
                                                    <ul class=""socials"">
                                                        <li class=""twitter"">
                                                            <a href=""http://twitter.com/"" target=""_blank"" rel=""nofollow"">
                                                            </a>
                                                        </li>
                                                        <li class=""facebook"">
                                                            <a href=""http://facebook.com/"" target=""_blank"" rel=""nofollow"">
                                                            </a>
                                                        </li>
                                                        <li class=""google-plus"">
                                                            <a href=""https://plus.google.com/"" target=""_blank"" rel=""nofollow"">
  ");
            WriteLiteral(@"                                                          </a>
                                                        </li>
                                                        <li class=""pinterest"">
                                                            <a href=""https://www.pinterest.com"" target=""_blank"" rel=""nofollow"">
                                                            </a>
                                                        </li>
                                                        <li class=""linkedin"">
                                                            <a href=""https://www.linkedin.com"" target=""_blank"" rel=""nofollow"">
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
        ");
            WriteLiteral(@"                            </div>
                                </div>
                                <div class=""uk-container uk-container-center alt"">
                                    <div class=""uk-grid"">
                                        <div class=""uk-width-1-1"">
                                            <div class=""line""></div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""uk-container uk-container-center alt"">
                                    <div class=""uk-grid"">
                                        <div class=""uk-width-9-10 uk-push-1-10"">
                                            <div class=""player-total-info"">
                                                <p><strong>Aenean lobortis eu nibh eu euismod. In ullamcorper, velit sed tincidunt tempor, ante elit euismod magna, vel scelerisque odio velit nec arcu. Nulla dolor sapien, vehicula sit");
            WriteLiteral(@" amet augue nec, consequat aliquet velit. Donec euismod interdum mauris id dapibus.</strong></p>
                                                <p>Fusce mollis ante dolor, in tincidunt justo vehicula id. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nam nec tortor sit amet metus vestibulum sagittis. Donec sed dignissim nisi. Pellentesque ac dolor vestibulum, sollicitudin leo ac, pretium nulla. Mauris sit amet mattis turpis, eu molestie lectus. Donec semper sem ac dolor euismod vulputate. Quisque massa elit, viverra et euismod nec, porta eget elit. Aliquam molestie tempus ex, ut iaculis tortor eleifend ac. Aliquam id massa facilisis, iaculis orci et, ornare augue. Fusce eget sollicitudin est. Fusce ultrices enim ut aliquam sollicitudin.</p>
                                                <ul>
                                                    <li>Maecenas a nisl in turpis fermentum imperdiet;</li>
   ");
            WriteLiteral(@"                                                 <li>Nullam at diam et odio consectetur fermentum;</li>
                                                    <li>Maecenas volutpat lacus quis sem congue egestas;</li>
                                                    <li>Quisque sit amet nunc quis quam tincidunt scelerisque;</li>
                                                    <li>Maecenas vestibulum ligula sed augue dictum, quis tincidunt nulla pellentesque;</li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </article>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>











");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Football.Models.Player> Html { get; private set; }
    }
}
#pragma warning restore 1591
