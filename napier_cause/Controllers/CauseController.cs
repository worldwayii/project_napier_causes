using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using napier_cause.Models;
using napier_cause.DAC;


namespace napier_cause.Controllers
{
    public class CauseController : Controller
    {
       
        private CauseDBContext _cDAC;
       

        // GET: Cause
        public ActionResult Index()
        {
            
                return View();
            
        }

        // GET: Cause/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cause/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: Cause/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                

                    return RedirectToAction("Index");

                
                
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Cause/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cause/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cause/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cause/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
