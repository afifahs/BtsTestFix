using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BtsTest.Models;
using Bts.Models;
using BtsTest.Controllers;
using static BtsTest.Models.BtsAttributeViewModel;


namespace BtsTest.DataAccess_repo_
{
    public class BtsAttributeRepo : BaseController
    {
        BtsDbContext db = new BtsDbContext();
        public string AddUser (UserAttribute model)
        {
            User usr = new User();
            usr.Id = model.Id;
            usr.Name = model.Name;
            usr.Username = model.Username;
            usr.Password = model.Password;
            usr.Phone = model.Phone;
            usr.Email = model.Email;
            usr.Postcode = model.Postcode;
            usr.Address = model.Address;
            return usr.Id.ToString();
        }

        public string AddShopping(UserAttribute model)
        {
            User usr = new User();
            usr.Id = model.Id;
            usr.Name = model.Name;
            usr.Username = model.Username;
            usr.Password = model.Password;
            usr.Phone = model.Phone;
            usr.Email = model.Email;
            usr.Postcode = model.Postcode;
            usr.Address = model.Address;
            return usr.Id.ToString();
        }
    }
}



    