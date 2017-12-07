﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace final.Models
{
    public class Casts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Casts()
        {
            Movies = new Movies();
            Actors = new Actors();
        }

        [Key]
        [Required]
        public int CastId { get; set; }

        [Required]
        [Display(Name = "Movie")]
        public int MovieId { get; set; }

        [Required]
        [Display(Name = "Actor")]
        public int ActorId { get; set; }

        public virtual Movies Movies { get; set; }

        public virtual Actors Actors { get; set; }
    }
}