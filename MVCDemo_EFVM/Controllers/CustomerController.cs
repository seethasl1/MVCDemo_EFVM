using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo_EFVM.Models;
using MVCDemo_EFVM.DAL;
using MVCDemo_EFVM.ViewModel;

namespace MVCDemo_EFVM.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustEnter()
        {
            //View Model Object
            CustViewModel vmobj=new CustViewModel();
            vmobj.customer=new Customer();
            //using dal fill the customers collection
            //CustDAL dalobj = new CustDAL();
            //List<Customer> custcoll = dalobj.Customers.ToList<Customer>();
            //vmobj.Lcustomers = custcoll;
            return View(vmobj);
        }
        public ActionResult Submit(Customer cutobj)
        {
            CustViewModel vmobj = new CustViewModel();
            Customer custobj=new Customer();
            custobj.CustId = Request.Form["Customer.CustId"];
            custobj.Custname = Request.Form["Customer.Custname"];
         
            if(ModelState.IsValid)
            {
                CustDAL dalobj=new CustDAL();
                dalobj.Customers.Add(custobj);
                dalobj.SaveChanges();
                return View("Display",custobj);
               // vmobj.customer=new Customer();
            }
            else
            {
                vmobj.customer=custobj;
            }
            CustDAL Dalobj = new CustDAL();
            List<Customer> custcoll = Dalobj.Customers.ToList();
            vmobj.Lcustomers = custcoll;
            return View("CustEnter",vmobj);
            
        }
        public ActionResult Display()
        {
            Customer custobj=new Customer();
            return View(custobj);
        }
    }
}