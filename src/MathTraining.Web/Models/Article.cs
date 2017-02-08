using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathTraining.Web.Models
{
    public class Article
    {
        [Required]
        [MaxLength(50)]
        public Guid ArticleId { get; set; }

        [Required]
        [MaxLength(50)]
        public String ChineseTitle { get; set; }

        [Required]
        [MaxLength(50)]
        public String EnglishTitle { get; set; }

        [Required]
        [MaxLength(50)]
        public String FileNameOfView { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        [MaxLength(256)]
        public String BriefIntroduction { get; set; }

    }
}
