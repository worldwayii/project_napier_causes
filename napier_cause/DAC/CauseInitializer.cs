﻿using napier_cause.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace napier_cause.DAC
{
    public class CauseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CauseDBContext>
    {
        protected override void Seed(CauseDBContext context)
        {

            var user = new List<ApplicationUser>
            {
                new ApplicationUser{FirstName="Chuma", RoleID=1, AliasName= "Wayii", LastName="Elui", Email="Chums@gmail.com", PhoneNumber="0904848488484"},
                new ApplicationUser{FirstName="Chuma", RoleID=2, AliasName= "Wayii", LastName="Elui", Email="Chumw@gmail.com", PhoneNumber="0904848488484"},
                new ApplicationUser{FirstName="Chuma", RoleID=1, AliasName= "Wayii", LastName="Elui", Email="Chumg@gmail.com", PhoneNumber="0904848488484"}

            };
                user.ForEach(s => context.Users.Add(s));
                context.SaveChanges();

            var cause = new List<Cause>
           {
                new Cause{Topic="Carson",Description="Alexander",ImgPath= "https://via.placeholder.com/300x250?text=300x250+MPU", CreatedBy = 1, CreatedDate=DateTime.Parse("2005-09-01")},
                new Cause{Topic="Carson",Description="Alexander",ImgPath= "https://via.placeholder.com/300x250?text=300x250+MPU", CreatedBy = 2, CreatedDate=DateTime.Parse("2005-09-01")},
                new Cause{Topic="Carson",Description="Alexander",ImgPath= "https://via.placeholder.com/300x250?text=300x250+MPU", CreatedBy = 3, CreatedDate=DateTime.Parse("2005-09-01")}
           };
                cause.ForEach(s => context.Causes.Add(s));
                context.SaveChanges();

            var signatures = new List<Signature>
           {
           new Signature{CauseID=1, UserID=1, Signed_Date=DateTime.Parse("2005-09-01")},
           new Signature{CauseID=1, UserID=1, Signed_Date=DateTime.Parse("2005-09-01")},
           new Signature{CauseID=1, UserID=2, Signed_Date=DateTime.Parse("2005-09-01")}

           };
                signatures.ForEach(s => context.Signatures.Add(s));
                context.SaveChanges();
            
        }
            
    }
}