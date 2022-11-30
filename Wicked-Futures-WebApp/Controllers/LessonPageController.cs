using Microsoft.AspNetCore.Mvc;
using Wicked_Futures_WebApp.Data;
using Wicked_Futures_WebApp.Models;

namespace Wicked_Futures_WebApp.Controllers
{
    public class LessonPageController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        public LessonPageController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult LessonPage(int id)
        {
            var returnModel = _db.LessonPages.FirstOrDefault(m => m.LessonPageId == id);
            return View(returnModel);
        }

        public IActionResult GenerateLessonPages()
        {
            var imageModel = new LessonPage
            {
                LessonPageTitle = "Image Test",
                LessonPageDescription = "This is an image slide. Lorem Ipsum dolar sit atem.",
                LessonPageMediaEmbed = "https://placekitten.com/800/600"
            };

            var videoModel = new LessonPage
            {
                LessonPageTitle = "Video Test",
                LessonPageDescription = "This is a video slide. Lorem Ipsum dolar sit atem.",
                LessonPageMediaEmbed = "https://player.vimeo.com/video/662712990?h=aeccd6f6fa&title=0&byline=0&portrait=0"
            };

            var pdfModel = new LessonPage
            {
                LessonPageTitle = "PDF Test",
                LessonPageDescription = "This is a PDF slide. Lorem Ipsum dolar sit atem.",
                LessonPageMediaEmbed = "https://unec.edu.az/application/uploads/2014/12/pdf-sample.pdf"
            };

            _db.LessonPages.AddRange(imageModel, videoModel, pdfModel);
            _db.SaveChanges();

            return Content("Done");
        }

        [HttpGet()]
        public IActionResult LessonPageEditor(int id)
        {
            if(id == 0)
                return View(new LessonPage());

            var returnModel = _db.LessonPages.FirstOrDefault(m => m.LessonPageId == id);
            return View(returnModel);
        }

        [HttpPost()]
        public IActionResult LessonPageEditor(LessonPage model)
        {
            if(model.LessonMediaType == LessonMediaType.Video)
            {
                int vimeoNumber;
                bool isInt = int.TryParse(model.LessonPageMediaEmbed, out vimeoNumber);
                if (!isInt)
                    return Content("Failed to save - Not a video ID");
            }

            _db.LessonPages.Add(model);
            _db.SaveChanges();

            return Content("Saved!");
        }
    }
}
