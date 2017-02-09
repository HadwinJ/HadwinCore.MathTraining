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
        public Guid ArticleId { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name ="中文标题")]
        public String ChineseTitle { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "英文标题")]
        public String EnglishTitle { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "连接名称")]
        public String FileNameOfView { get; set; }

        [Required]
        [Display(Name = "创建日期")]
        public DateTime Created { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "简要介绍")]
        public String BriefIntroduction { get; set; }

    }
}
