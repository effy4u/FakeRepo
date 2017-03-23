﻿using ClaimsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaimsWeb.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login collection)
        {

            ViewBag.ErrorMessage = collection.username + " <br> " + collection.password;
            Login login = LoginModel.AuthenticateUser(collection.username.Trim(), collection.password);
            if (login == null)
            {
                ViewBag.ErrorMessage = "Incorrect User Credential";
            }
            else
            {
                ViewBag.ErrorMessage = "Correct user";
                Session["loggedUser"] = login;
                //Response.Redirect("Info");
                return RedirectToAction("Info");
            }
            return View();
        }

        public ActionResult Info()
        {
            Login login = (Login)Session["loggedUser"];
            return View(login);
        }
        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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

