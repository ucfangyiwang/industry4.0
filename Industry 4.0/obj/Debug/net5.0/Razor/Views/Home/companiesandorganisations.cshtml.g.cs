#pragma checksum "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a08106ebd1eb64ac8d3baab581396cd69ba735e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_companiesandorganisations), @"mvc.1.0.view", @"/Views/Home/companiesandorganisations.cshtml")]
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
#line 1 "F:\dowload\Industry 4.0\Industry 4.0\Views\_ViewImports.cshtml"
using Industry_4._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\dowload\Industry 4.0\Industry 4.0\Views\_ViewImports.cshtml"
using Industry_4._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a08106ebd1eb64ac8d3baab581396cd69ba735e", @"/Views/Home/companiesandorganisations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18137127a79108327e3ec7d46971e615b314e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_companiesandorganisations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Industry_4._0.Models.Feedback>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/feedbacks/Create/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Identity/Account/Login?returnUrl=~/Home/companiesandorganisations"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Identity/Account/Register?returnUrl=~/Home/companiesandorganisations"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReviewsForums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncreaseAgree", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncreaseDisagree", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "feedbacks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
        ViewData["Tittle"] = "Companies&Organisations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <article>

        <section id=""bg3"" style=""padding-left: 0px; padding-right: 0px;"" class=""col-md-12 col-sm-12 col-12"">
            <header id=""ind"">Companies and Organisations</header>
            <p id=""intro"">
                The Industry 4.0 market is forecasted to reach $1 trillion by 2030, dominated by global technology<br />
                giants including Alphabet-Google, HP, Samsung, IBM, NEC, Microsoft, and more. According to the new <br />
                4-volume report by HSRC: Global Industry 4.0 Market & Technologies 2018-2023, the Industry 4.0 market<br />
                will reach $214B by 2023 (https://www.prnewswire.com/news-releases/global-tech-giants-to-lead-the-industry-40-revolution-300585640.html)
            </p>
        </section>
        <section class=""row"">
            <figure class=""col-md-6 col-sm-6 col-12"" style=""padding:0px; margin:0px;"" onmouseover=""displayInfo('div1')"" onmouseout=""removeInfo('div1')"">
                <img src");
            WriteLiteral(@"=""../images/Companies/ibm.jpg"" />

                <figcaption id=""div1"">
                    <p>IBM</p>
                    <p class=""stitle"">

                        <a class=""btn btn-info"" href=""https://www.ibm.com/industries/manufacturing?S_PKG=ov60479&cm_mmc=Search_Google-_-Industrial_Industrial+-+Discrete+Manufacturing-_-WW_NA-_-industry+4.0_Exact_ov60479&cm_mmca1=000020DR&cm_mmca2=10005255&cm_mmca7=9071954&cm_mmca8=kwd-297031802574&cm_mmca9=9a244c0e-4e2f-4a0c-879b-abaf5cee4a64&cm_mmca10=280798821827&cm_mmca11=e&mkwid=9a244c0e-4e2f-4a0c-879b-abaf5cee4a64|1082|36760&cvosrc=ppc.google.industry%204.0&cvo_campaign=000020DR&cvo_crid=280798821827&Matchtype=e"">
                            Learn More
                        </a>
                </figcaption>

            </figure>
            <figure class=""col-md-6 col-sm-6 col-12"" style=""padding:0px; margin:0px;"" onmouseover=""displayInfo('div2')"" onmouseout=""removeInfo('div2')"">
                <img src=""../images/Companies/amazon.jpg"" />


 ");
            WriteLiteral(@"               <figcaption id=""div2"">
                    <p>Amazon</p>
                    <p class=""stitle"">

                        <a class=""btn btn-info"" href=""https://aws.amazon.com/ai/"">
                            Learn More
                        </a>
                </figcaption>
            </figure>
            <figure class=""col-md-12 col-sm-12 col-12"" style=""padding:0px; margin:0px;"" onmouseover=""displayInfo('div3')"" onmouseout=""removeInfo('div3')"">
                <img src=""../images/Companies/google.jpg"" />

                <figcaption id=""div3"">
                    <p>Google</p>
                    <p class=""stitle"">

                        <a class=""btn btn-info"" href=""https://ai.google/"">
                            Learn More
                        </a>
                </figcaption>
            </figure>
            <figure class=""col-md-6 col-sm-6 col-12"" style=""padding:0px; margin:0px;"" onmouseover=""displayInfo('div4')"" onmouseout=""removeInfo('div4')"">
         ");
            WriteLiteral(@"       <img src=""../images/Companies/CSIRO.jpg"" />

                <figcaption id=""div4"">
                    <p>CSIRO</p>
                    <p class=""stitle"">

                        <a class=""btn btn-info"" href=""https://www.microsoft.com/en-us/ai?activetab=pivot1:primaryr6"">
                            Learn More
                        </a>
                </figcaption>
            </figure>
            <figure class=""col-md-6 col-sm-6 col-12"" style=""padding:0px; margin:0px;"" onmouseover=""displayInfo('div5')"" onmouseout=""removeInfo('div5')"">
                <img src=""../images/Companies/microsoft.jpg"" />

                <figcaption id=""div5"">
                    <p>Microsoft</p>
                    <p class=""stitle"">

                        <a class=""btn btn-info"" href=""https://www.csiro.au/"">
                            Learn More
                        </a>
                </figcaption>
            </figure>
            <figure class=""col-md-12 col-sm-12 col-12"" style=""paddi");
            WriteLiteral(@"ng:0px; margin:0px;"" onmouseover=""displayInfo('div6')"" onmouseout=""removeInfo('div6')"">
                <img src=""../images/Companies/department.jpg"" />

                <figcaption id=""div6"">
                    <p>Department of Industry, Science, Energy and Resources</p>
                    <p class=""stitle"">

                        <a class=""btn btn-info"" href=""https://www.industry.gov.au/"">
                            Learn More
                        </a>
                </figcaption>
            </figure>
        </section>
        <hr />



        <div class=""post"">
            <div class=""submit-btn"">
");
#nullable restore
#line 98 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"text-align:center;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e13601", async() => {
                WriteLiteral("Submit your feedback");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 101 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"text-align:center\">\r\n                        Please ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e15123", async() => {
                WriteLiteral(" login ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" or ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e16200", async() => {
                WriteLiteral(" create an account");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" to post your discussion on this page\r\n                    </div>\r\n");
#nullable restore
#line 107 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 110 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
            if(Model != null ) {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>");
#nullable restore
#line 113 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Heading));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <h2>");
            WriteLiteral("@");
#nullable restore
#line 114 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                 Write(Html.DisplayFor(modelItem => item.CompanyOrganisationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>\r\n");
#nullable restore
#line 116 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                       for (int i = 0; i < item.StarRating; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: #f8bd08; \">&#x2605;</span> ");
#nullable restore
#line 118 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                           }
                        for (int i = 0; i < 5 - item.StarRating; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>&#x2606;</span> ");
#nullable restore
#line 121 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                  } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <p>");
#nullable restore
#line 123 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
              Write(Html.DisplayFor(modelItem => item.FEEdback));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Posted by <b>");
#nullable restore
#line 124 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> on ");
#nullable restore
#line 124 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e20709", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e23201", async() => {
                WriteLiteral("Agree(");
#nullable restore
#line 126 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                                                                              Write(Html.DisplayFor(modelItem => item.Agree));

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e26073", async() => {
                WriteLiteral("Disagree(");
#nullable restore
#line 127 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                                                                                   Write(Html.DisplayFor(modelItem => item.Disagree));

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 128 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    if (User.IsInRole("Manager"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e29308", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a08106ebd1eb64ac8d3baab581396cd69ba735e31810", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 133 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                                                                                                                                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "F:\dowload\Industry 4.0\Industry 4.0\Views\Home\companiesandorganisations.cshtml"
             
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n</article>    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Industry_4._0.Models.Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
