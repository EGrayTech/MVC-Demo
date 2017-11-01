using System;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamRoster.Models
{
    public class Team
    {
        [Key]
        public int Team_Id { get; set; }

        [Required(ErrorMessage = "Team Name is required.")]
        [StringLength(50, ErrorMessage = "Team Name may not be longer than 50 charaters.")]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}