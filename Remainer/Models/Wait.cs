using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Remainer.Models
{
    public class Wait
    {
       public int Id { get; set; }

        [Required]
       
        [StringLength(3)]
        [Column (TypeName= "varChar")]

        public string CurrentCount { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

    }
}