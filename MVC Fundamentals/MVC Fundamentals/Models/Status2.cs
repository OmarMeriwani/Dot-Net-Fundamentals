using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC_Fundamentals.Models
{
    public class Status2
    {
        [Display(Name = "ID")]
        public int ST_ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter service Status Name")]
        public string ST_NAME { get; set; }
        [Display(Name = "Auother")]
        [Required(ErrorMessage = "Please enter service Status Author")]
        public string ST_AUTHOR { get; set; }
        [Display(Name = "Data Entery Date")]
        [Required(ErrorMessage = "Please enter service Status Entery Date")]
        public DateTime ST_ENTRYDATE { get; set; }
        [Display(Name = "Enable For Providers")]
        public int PROVIDERENABLED { get; set; }
        [Display(Name = "Enable For Requeset")]
        public int FORREQUESTS { get; set; }
        [Display(Name = "Send Email Notification")]
        public int EMAIL_ENABLED { get; set; }
        [Display(Name = "Reject Status")]
        public int ST_REJECT { get; set; }

    }
}
