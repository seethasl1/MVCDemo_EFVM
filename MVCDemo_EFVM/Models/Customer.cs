using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo_EFVM.Models
{
    public class Customer
    {
        [Key]
        public string CustId { get; set; }
        public string Custname { get; set; }
    }
}