using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo_EFVM.Models;


namespace MVCDemo_EFVM.ViewModel
{
    public class CustViewModel
    {
        //customer
        public Customer customer { get; set; }
        //List of customers
        public List<Customer> Lcustomers { get; set; }   
    }
}