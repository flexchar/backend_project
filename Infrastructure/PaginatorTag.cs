using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MandotaryAssignment01.Models.ViewModels;
using System.Collections.Generic;

namespace MandotaryAssignment01.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PaginatorTag : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PaginatorTag(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public Paginator PageModel { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();
        public string PageAction { get; set; }
        public override void Process(TagHelperContext context,
        TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder div = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder link = new TagBuilder("a");

                PageUrlValues["page"] = i;
                link.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);

                link.AddCssClass("py-2 px-4 mx-2 rounded text-lg");

                // Style depending on the current page
                if (this.PageModel.CurrentPage == i)
                {
                    link.AddCssClass("bg-green-500 text-white");
                }
                else
                {
                    link.AddCssClass("bg-white hover:shadow-lg");
                }

                link.InnerHtml.Append(i.ToString());
                div.InnerHtml.AppendHtml(link);
            }
            output.Content.AppendHtml(div.InnerHtml);
        }
    }
}

