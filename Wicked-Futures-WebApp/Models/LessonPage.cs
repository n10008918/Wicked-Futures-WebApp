using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wicked_Futures_WebApp.Models
{
    public class LessonPage
    {
        [Required]
        public int LessonPageId { get; set; }

        [Required]
        public string LessonPageTitle { get; set; }

        [Required]
        public string LessonPageMediaEmbed { get; set; }

        [Required]
        public LessonMediaType LessonMediaType { get; set; }

        [Required]
        public string LessonPageDescription { get; set; }

        public static SelectList GetLessonMediaTypesList()
        {
            var values = from LessonMediaType e in Enum.GetValues(typeof(LessonMediaType))
                         select new { Id = e, Name = e.ToString() };
            return new SelectList(values, "Id", "Name");
        }
    }

    public enum LessonMediaType
    {
        Video,
        Image,
        PDF,
        MultiChoiceQuiz,
        TextOnly,
    }
}
