using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadManage.Models
{
    public class Engineer
    {
        [Key]
        public int EngineerID { get; set; }
        // public string acept { get; set; } Deve ser botao
        // public string refuse { get; set; } Deve ser botao
        public int UsersID { get; set; }
    }
}