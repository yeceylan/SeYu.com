using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Seyu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Policy;
using System.Threading.Tasks;
namespace Seyu.Controllers
{
    public class AdminController : Controller
    {
        public string emails = "email@gmail.com";
        public string passwords = "password";
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string k)
        {
            string email = Request.Method == "POST" ? Request.Form["email"] : string.Empty;
            string password = Request.Method == "POST" ? Request.Form["password"] : string.Empty;
            if (emails == email && passwords == password)
            {
                return Redirect("../Admin/Edit");


            }
            return Redirect("");
        }
        [HttpGet]
        public IActionResult Edit()
        {


            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");
            var Result = collection.Find(a => true).ToList();

            return View(Result);
        }
        [HttpPost]
        public IActionResult Edit(string k)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string k)
        {
            string marka = Request.Method == "POST" ? Request.Form["marka"] : string.Empty;
            string model = Request.Method == "POST" ? Request.Form["model"] : string.Empty;
            string fiyat = Request.Method == "POST" ? Request.Form["fiyat"] : string.Empty;
            string baslik = Request.Method == "POST" ? Request.Form["baslik"] : string.Empty;
            string url = Request.Method == "POST" ? Request.Form["url"] : string.Empty;
            string islemciMarkasi = Request.Method == "POST" ? Request.Form["islemciMarkasi"] : string.Empty;
            string islemciNesli = Request.Method == "POST" ? Request.Form["islemciNesli"] : string.Empty;
            string islemciTeknolojisi = Request.Method == "POST" ? Request.Form["islemciTeknolojisi"] : string.Empty;
            string ram = Request.Method == "POST" ? Request.Form["ram"] : string.Empty;
            string ekranBoyutu = Request.Method == "POST" ? Request.Form["ekranBoyutu"] : string.Empty;
            string ekranKartı = Request.Method == "POST" ? Request.Form["ekranKartı"] : string.Empty;
            string diskKapasitesi = Request.Method == "POST" ? Request.Form["diskKapasitesi"] : string.Empty;

            Laptop laptop = new Laptop
            {
                Marka = marka,
                Fiyat = fiyat,
                Resim = "",
                Baslik = baslik,
                Url = url,
                islemciMarkası = islemciMarkasi,
                islemciNesli = islemciNesli,
                islemciTeknolojisi = islemciTeknolojisi,
                ram = ram,
                ekranBoyutu = ekranBoyutu,
                ekranKartı = ekranKartı,
                diskKapasitesi = diskKapasitesi,

            };


            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");
            collection.InsertOne(laptop);
            return Redirect("../Admin/Edit");
        }
        [HttpGet]
        public IActionResult Sil(string baslik)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");
            collection.DeleteOne(a => a.Baslik == baslik);

            return Redirect("../Admin/Edit");
        }

        [HttpGet]
        public IActionResult Update(string baslik, string bos)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");
            var Result = collection.Find(a => a.Baslik == baslik).FirstOrDefault();



            return View(Result);
        }

        [HttpPost]
        public IActionResult Update(string buton)
        {
            string marka = Request.Method == "POST" ? Request.Form["marka"] : string.Empty;
            string model = Request.Method == "POST" ? Request.Form["model"] : string.Empty;
            string fiyat = Request.Method == "POST" ? Request.Form["fiyat"] : string.Empty;
            string baslik = Request.Method == "POST" ? Request.Form["baslik"] : string.Empty;
            string url = Request.Method == "POST" ? Request.Form["url"] : string.Empty;
            string islemciMarkasi = Request.Method == "POST" ? Request.Form["islemciMarkasi"] : string.Empty;
            string islemciNesli = Request.Method == "POST" ? Request.Form["islemciNesli"] : string.Empty;
            string islemciTeknolojisi = Request.Method == "POST" ? Request.Form["islemciTeknolojisi"] : string.Empty;
            string ram = Request.Method == "POST" ? Request.Form["ram"] : string.Empty;
            string ekranBoyutu = Request.Method == "POST" ? Request.Form["ekranBoyutu"] : string.Empty;
            string ekranKartı = Request.Method == "POST" ? Request.Form["ekranKartı"] : string.Empty;
            string diskKapasitesi = Request.Method == "POST" ? Request.Form["diskKapasitesi"] : string.Empty;

            Laptop laptop = new Laptop
            {
                Marka = marka,
                Fiyat = fiyat,
                Resim = "",
                Baslik = baslik,
                Url = url,
                islemciMarkası = islemciMarkasi,
                islemciNesli = islemciNesli,
                islemciTeknolojisi = islemciTeknolojisi,
                ram = ram,
                ekranBoyutu = ekranBoyutu,
                ekranKartı = ekranKartı,
                diskKapasitesi = diskKapasitesi,

            };


            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");
            collection.ReplaceOne(a => a.Url == url, laptop);

            return Redirect("../Admin/Edit");
        }

    }


}