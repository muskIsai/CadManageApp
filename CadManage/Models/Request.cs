using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadManage.Models
{
    public class Request
    {
        [Key]
        public int RequestID { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
        public int UsersID { get; set; }
        public int CadastreObjectsID { get; set; }
    }
}