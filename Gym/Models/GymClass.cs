using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gym.Models
{
    public class GymClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public TimeSpan Duration { get; set; }

        [Display(Name = "End Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get { return StartTime + Duration; } }        [Required]        public String Description { get; set; }        [Display(Name = "Attending Members")]        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }
    }
}