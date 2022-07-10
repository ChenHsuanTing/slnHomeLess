using System;
using System.Collections.Generic;

#nullable disable

namespace prjHomeLess.Models
{
    public partial class Vactivity
    {
        public Vactivity()
        {
            Volunteers = new HashSet<Volunteer>();
        }

        public int ActivityId { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ActivityCategoryId { get; set; }
        public int? PeopleInNeed { get; set; }
        public string ActivityPhoto { get; set; }

        public virtual VactivityCategory ActivityCategory { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}
