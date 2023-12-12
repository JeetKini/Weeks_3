using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Views
{
    public static class CustomHelper
    {
        public static IHtmlString Image(string src,string alt)
        {
            return new MvcHtmlString(string.Format("<img Src='{0}' Alt='{1}'></img>",src,alt));
        }
        public static IHtmlString Img(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img Src='{0}' Alt='{1}'></img>", src, alt));
        }
        public static IHtmlString ImgTag(string src, string alt)
        {
            TagBuilder tag=new TagBuilder("img");
            tag.Attributes.Add("src", src);
            tag.Attributes.Add("alt", alt);

            return new MvcHtmlString(tag.ToString());
        }
    }
}