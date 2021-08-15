using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealsourceMVC.Models
{
    public class CustomerModel
    {
        [Required]
        public int id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        //TODO - Create more fields

    }
}