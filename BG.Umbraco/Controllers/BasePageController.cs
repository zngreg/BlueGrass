using BG.Umbraco.Extenstions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;

namespace BG.Umbraco.Controllers
{
    public class BasePageController : RenderController
    {
        private readonly ILogger<RenderController> _logger;
        private readonly UmbracoHelper umbracoHelper;

        public BasePageController(
            ILogger<RenderController> logger,
            ICompositeViewEngine viewEngine,
            IUmbracoContextAccessor umbracoContextAccessor,
            UmbracoHelper umbracoHelper)
            : base(logger, viewEngine, umbracoContextAccessor)
        {
            _logger = logger;
            this.umbracoHelper = umbracoHelper;
        }

        public override IActionResult Index()
        {
            var siteSettings = umbracoHelper.GetSiteSettings();
            if (siteSettings == null)
            {
                _logger.LogWarning("Site settings not found.");
            }
            else
            {
                ViewData["SiteSettings"] = siteSettings;
            }

            return base.Index();
        }
    }
}