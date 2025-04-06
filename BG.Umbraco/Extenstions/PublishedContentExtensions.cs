using global::Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Common;

namespace BG.Umbraco.Extenstions
{
    public static class PublishedContentExtensions
    {
        public static Site? GetSiteSettings(this UmbracoHelper umbracoHelper)
        {
            var siteSettings = umbracoHelper?.ContentAtRoot().SingleOrDefault(x => x.ContentType.Alias == Site.ModelTypeAlias) as Site;
            if (siteSettings == null) return null;
            return siteSettings;
        }
    }
}