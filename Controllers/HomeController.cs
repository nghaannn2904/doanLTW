﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using online_coffee.Models;

namespace online_coffee.Controllers
{
    public class HomeViewModel
    {
     
        public List<Product> listProduct1 { get; set; }
    }

    public class HomeController : Controller
    {
        OnlineCoffeeEntities3 database = new OnlineCoffeeEntities3();
        public ActionResult Index()
        {

            //var listBestSell = database.Products.ToList();

            //HomeViewModel viewmodel = new HomeViewModel
            //{
            //    listProduct1 = listBestSell
            //};


            return View("Home");
            //List<BlogEntity> listBlogs = new List<BlogEntity>();

            //var dbCon = DBConnection.Instance();
            //dbCon.Server = "localhost";
            //dbCon.DatabaseName = "coffee";
            //dbCon.UserName = "admin";
            //dbCon.Password = "admin";
            //if (dbCon.IsConnect())
            //{
            //    //suppose col0 and col1 are defined as VARCHAR in the DB
            //    string query = "SELECT * FROM Blog";
            //    var cmd = new MySqlCommand(query, dbCon.Connection);
            //    var reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        listBlogs.Add(new BlogEntity(reader));
            //    }
            //    reader.Close();
            //    //dbCon.Close();
            //    Console.WriteLine("Connected");
            //}

            //HomeViewModel viewModel = new HomeViewModel();
            //viewModel.listBlog1 = listBlogs;
            //viewModel.listBlog2 = listBlogs;
            //return View("Home", viewModel);
        }

    }
}