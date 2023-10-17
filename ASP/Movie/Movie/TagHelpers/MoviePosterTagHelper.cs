using Microsoft.AspNetCore.Razor.TagHelpers;
using Movie.Models;

namespace Movie.TagHelpers
{
    [HtmlTargetElement("img",Attributes ="poster")]
    public class MoviePosterTagHelper:TagHelper
    {
        public Cinema Poster { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagName = "img";
            output.Attributes.Add("src",Poster.Poster);
            output.Attributes.Add("onerror","event.target.src='/images/placeholder.png'");
            output.Attributes.Add("class","card-img-top");
            output.Attributes.Add("alt", "...");
        }
    }
}
