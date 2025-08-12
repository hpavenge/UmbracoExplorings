// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.ViewFeatures;
// using MyUmbracoSite.Models;
// using Umbraco.Cms.Core.Web;
// using Umbraco.Cms.Web.Website.Controllers;

// namespace MyUmbracoSite.Controllers
// {
//     public class ContactPageController : SurfaceController
//     {
//         public ContactPageController(
//             IUmbracoContextAccessor umbracoContextAccessor,
//             ITempDataDictionaryFactory tempDataDictionaryFactory,
//             IServiceProvider serviceProvider,
//             ILogger<SurfaceController> logger)
//             : base(umbracoContextAccessor, tempDataDictionaryFactory, serviceProvider, logger)
//         {
//         }

//         [HttpPost]
//         public IActionResult SubmitForm(ContactFormModel model)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return CurrentUmbracoPage();
//             }

//             // TODO: process form (save, send email, etc.)
//             TempData["Success"] = "Thank you! We'll get back to you.";

//             return RedirectToCurrentUmbracoPage();
//         }
//     }
// }