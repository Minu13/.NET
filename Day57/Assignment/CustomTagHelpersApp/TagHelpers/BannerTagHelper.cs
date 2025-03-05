using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelpersApp.TagHelpers
{
    public class BannerTagHelper : TagHelper
    {
        public string Message { get; set; }
        public string Color { get; set; } = "blue"; 

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; 
            output.Attributes.SetAttribute("style", $"color: white; background-color: {Color}; padding: 10px; border-radius: 5px;");
            output.Content.SetContent(Message);
        }
    }
}

