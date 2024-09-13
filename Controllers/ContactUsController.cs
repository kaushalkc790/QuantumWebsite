using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using QuantumWebsite.Models.ViewModels;

namespace QuantumWebsite.Controllers
{
    public class ContactUsController : SurfaceController
    {
        public ContactUsController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        // Handle the form POST
        [HttpPost]
        public IActionResult SubmitContactForm(ContactFormViewModel model)
        {
            var contentService = Services.ContentService;

            // Replace with the actual ID of the parent node where you want to save the form submissions
            var parentId = new Guid("9cf6c2ea-a568-403a-bcfa-4c5b01a8b82d");

            // Create a new content item of type "contactFormStore"
            var formSubmission = contentService.Create(model.Name, parentId, "ContactPage");

            // Set the values of the properties
            formSubmission.SetValue("formName", model.Name);
            formSubmission.SetValue("formEmail", model.Email);
            formSubmission.SetValue("formAddress", model.Address);
            formSubmission.SetValue("formPhoneNumber", model.Number);
            formSubmission.SetValue("formMessage", model.Message);

            // Save and publish the content
            var result = contentService.SendToPublication(formSubmission);





            TempData["SuccessMessage"] = "Thank you for your message. We will get back to you soon!";
            

            return RedirectToCurrentUmbracoPage();
        }
    }
}
