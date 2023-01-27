using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Misc;
using MongoDB.Driver.Linq;
using Seyu;
using Seyu.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.Intrinsics.Arm;
using System.Security.Policy;
using System.Threading.Tasks;
using PagedList;
using X.PagedList.Mvc;
using X.PagedList.Mvc.Core;

namespace SeYu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        [HttpGet]
        public IActionResult Index(int p=1)
        {
            DatabaseConnection.ClearData();
            WebScraping();

            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");
           
            var Result = collection.Find(a => true).ToList().ToPagedList(p,10);

            
            return View(Result);
        }
        [HttpPost]
        public IActionResult Index(string submitButton)
        {
            switch (submitButton)
            {
                case "Search":
                    // delegate sending to another controller action
                    return (Search());
                case "Submit":
                    // call another action to perform the cancellation
                    return (Submit());
                default:
                    // If they've submitted the form without a submitButton, 
                    // just return the view again.
                    return (View());
            }




        }

        private ActionResult Search()
        {
            string search = Request.Method == "POST" ? Request.Form["search"] : string.Empty;
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");
            var Result = collection.Find(a => a.Baslik.Contains(search) || a.ekranBoyutu.Contains(search) || a.Marka.Contains(search) || a.ekranKartı.Contains(search) || a.diskKapasitesi.Contains(search) || a.islemciMarkası.Contains(search) || a.islemciNesli.Contains(search) || a.islemciTeknolojisi.Contains(search) || a.ram.Contains(search) || a.Url.Contains(search)).ToList();

            return View(Result);
        }
        private ActionResult Submit()
        {



            //MARKA
            string Asus = Request.Method == "POST" ? Request.Form["Asus"] : string.Empty;
            string Lenovo = Request.Method == "POST" ? Request.Form["Lenovo"] : string.Empty;
            string Monster = Request.Method == "POST" ? Request.Form["Monster"] : string.Empty;
            string Msi = Request.Method == "POST" ? Request.Form["Msi"] : string.Empty;
            string Apple = Request.Method == "POST" ? Request.Form["Apple"] : string.Empty;
            string Hp = Request.Method == "POST" ? Request.Form["Hp"] : string.Empty;



            //FİYAT
            string Price1 = Request.Method == "POST" ? Request.Form["Price1"] : string.Empty;
            string Price2 = Request.Method == "POST" ? Request.Form["Price2"] : string.Empty;
            string Price3 = Request.Method == "POST" ? Request.Form["Price3"] : string.Empty;
            string[] Price1Range;
            string[] Price2Range;
            string[] Price3Range;
            if (Price1 != null)
                Price1Range = Price1.Split("-");
            if (Price2 != null)
                Price2Range = Price2.Split("-");
            if (Price3 != null)
                Price3Range = Price3.Split("-");

            //RAM
            string Ram4 = Request.Method == "POST" ? Request.Form["Ram4"] : string.Empty;
            string Ram8 = Request.Method == "POST" ? Request.Form["Ram8"] : string.Empty;
            string Ram16 = Request.Method == "POST" ? Request.Form["Ram16"] : string.Empty;


            //İŞLEMCİ
            string Amd = Request.Method == "POST" ? Request.Form["Amd"] : string.Empty;
            string Intel = Request.Method == "POST" ? Request.Form["Intel"] : string.Empty;


            //İŞLEMCİ MARKASI
            string Amd3 = Request.Method == "POST" ? Request.Form["Amd3"] : string.Empty;
            string Amd5 = Request.Method == "POST" ? Request.Form["Amd5"] : string.Empty;
            string Amd7 = Request.Method == "POST" ? Request.Form["Amd7"] : string.Empty;
            string IntelC = Request.Method == "POST" ? Request.Form["IntelC"] : string.Empty;
            string Intel3 = Request.Method == "POST" ? Request.Form["Intel3"] : string.Empty;
            string Intel5 = Request.Method == "POST" ? Request.Form["Intel5"] : string.Empty;
            string Intel7 = Request.Method == "POST" ? Request.Form["Intel7"] : string.Empty;
            string Intel9 = Request.Method == "POST" ? Request.Form["Intel9"] : string.Empty;

            //DİSK KAPASİTESİ
            string Disk0 = Request.Method == "POST" ? Request.Form["Disk0"] : string.Empty;
            string Disk1 = Request.Method == "POST" ? Request.Form["Disk1"] : string.Empty;
            string Disk2 = Request.Method == "POST" ? Request.Form["Disk2"] : string.Empty;

            //EKRAN BOYUTU
            string E13 = Request.Method == "POST" ? Request.Form["E13"] : string.Empty;
            string E15 = Request.Method == "POST" ? Request.Form["E15"] : string.Empty;
            string E17 = Request.Method == "POST" ? Request.Form["E17"] : string.Empty;


            //EKRAN KARTI
            string AmdS = Request.Method == "POST" ? Request.Form["AmdS"] : string.Empty;
            string IntelS = Request.Method == "POST" ? Request.Form["IntelS"] : string.Empty;
            string NvidiaS = Request.Method == "POST" ? Request.Form["NvidiaS"] : string.Empty;




            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://dbSeyu:q123q123q@cluster0.vaizm.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("seyuDb");
            var collection = database.GetCollection<Laptop>("computer");


            /*     
                 var filter1 = Builders<Laptop>.Filter.Where(a => a.Marka == Asus || a.Marka == Lenovo || a.Marka == Monster || a.Marka == Msi || a.Marka == Apple || a.Marka == Hp);
                 var filter2 = Builders<Laptop>.Filter.Where(a => a.ram == Ram4 || a.ram == Ram8 || a.ram == Ram16);

                 FilterDefinition<Laptop> filter = filter1 & filter2 ;
             var Result = collection.Find(filter).ToList();*/

            var result1 = collection.Find(a => (a.Marka == Asus || a.Marka == Lenovo || a.Marka == Monster || a.Marka == Msi || a.Marka == Apple || a.Marka == Hp)
            || (a.ram == Ram4 || a.ram == Ram8 || a.ram == Ram16)


            )
                    .ToList();

            //  (Int32.Parse(a.Fiyat.Replace("TL", "")) > Int32.Parse(Price1Range[0]) && Int32.Parse(a.Fiyat.Replace("TL", "")) < Int32.Parse(Price1Range[1]))
            /*    || (a.islemciMarkası.Contains(Amd3) || a.islemciMarkası.Contains(Amd5) || a.islemciMarkası.Contains(Amd7) || a.islemciMarkası.Contains(IntelC) || a.islemciMarkası.Contains(Intel3) || a.islemciMarkası.Contains(Intel5)
               || a.islemciMarkası.Contains(Intel7) || a.islemciMarkası.Contains(Intel9))*/


            return View(result1);
        }
        public void WebScraping()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);

            //Start with a list of URLs
            var urls = new string[]
                {
        "https://www.trendyol.com/laptop-x-c103108?pi=2",
        "https://www.vatanbilgisayar.com/notebook/",
        "https://www.n11.com/bilgisayar/dizustu-bilgisayar"
                };

            //Start requests for all of them
            var requests = urls.Select
                (
                    url => client.GetStringAsync(url)
                ).ToList();

            //Wait for all the requests to finish
            //  await Task.WhenAll(requests);

            //Get the responses
            var responses = requests.Select
                (
                    task => task.Result
                );
            //  await Task.WhenAll((Task)responses);
            var index = 0;
            foreach (var response in responses)
            {
                if (index == 0)
                {
                    ParseHtmlTrendyol(response);
                }
                if (index == 1)
                {
                    ParseHtmlVatan(response);
                }
                /*  if (index == 2)
                   {
                      ParseHtmln11(response);
                   }*/
                index++;

            }
        }
        private void ParseHtmlVatan(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var programmerLinks = htmlDoc.QuerySelectorAll("div")
                  .Where(e => e.GetAttributeValue("class", "") == "product-list product-list--list-page")

    .Take(30)
    .ToList();

            var data = programmerLinks.Select((node) =>
            {
                return new
                {
                    baslik = node.QuerySelectorAll("div")
                  .Where(e => e.GetAttributeValue("class", "") == "product-list__product-name"),

                    marka = node.QuerySelectorAll("div")
                  .Where(e => e.GetAttributeValue("class", "") == "product-list__product-name"),

                    fiyat = node.QuerySelectorAll("span")
                  .Where(e => e.GetAttributeValue("class", "") == "product-list__price"),

                    resim = node.QuerySelectorAll("img")
                  .Where(e => e.GetAttributeValue("class", "") == "lazyimg"),

                    url = node.QuerySelectorAll("a")
                  .Where(e => e.GetAttributeValue("class", "") == "product-list__image-safe-link sld")


                };
            }
                );
            // Marka , fiyat , resim , başlık , derece,url

            List<string> baslikListe = new List<string>();
            List<string> markaListe = new List<string>();
            List<string> fiyatListe = new List<string>();
            List<string> resimListe = new List<string>();
            List<string> urlListe = new List<string>();

            foreach (var link in data)
            {

                foreach (var baslik in link.baslik)
                {

                    baslikListe.Add(baslik.InnerText);
                }

                foreach (var marka in link.marka)
                {
                    markaListe.Add(marka.InnerText.Split(" ")[0]);
                }
                foreach (var fiyat in link.fiyat)
                {
                    fiyatListe.Add(fiyat.InnerText);
                }

                foreach (var resim in link.resim)
                {
                    resimListe.Add(resim.GetAttributeValue("data-src", ""));
                }

                foreach (var url in link.url)
                {
                    urlListe.Add(url.GetAttributeValue("href", ""));
                }

            }
            for (int i = 0; i < baslikListe.Count; i++)
            {
                Laptop laptop = new Laptop
                {
                    Marka = markaListe[i],
                    Fiyat = fiyatListe[i],
                    Resim = resimListe[i],
                    Baslik = baslikListe[i],
                    Url = "https://www.vatanbilgisayar.com" + urlListe[i],
                    islemciMarkası = "  ",
                    islemciNesli = "  ",
                    islemciTeknolojisi = " ",
                    ram = " ",
                    ekranBoyutu = " ",
                    ekranKartı = "  ",
                    diskKapasitesi = "  ",

                };
                DatabaseConnection.vatanLaptops.Add(laptop);


            }
            DetailVatan();


        }
        private void ParseHtmln11(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var programmerLinks = htmlDoc.QuerySelectorAll("li")
                  .Where(e => e.GetAttributeValue("class", "") == "column ")


    .Take(30)
        .ToList();

            var data = programmerLinks.Select((node) =>
            {
                return new
                {
                    baslik = node.QuerySelectorAll("h3")
                  .Where(e => e.GetAttributeValue("class", "") == "productName"),

                    marka = node.QuerySelectorAll("h3")
                  .Where(e => e.GetAttributeValue("class", "") == "productName"),

                    fiyat = node.QuerySelectorAll("span")
                  .Where(e => e.GetAttributeValue("class", "") == "newPrice cPoint priceEventClick"),

                    resim = node.QuerySelectorAll("img")
                  .Where(e => e.GetAttributeValue("class", "") == "lazy cardImage"),

                    url = node.QuerySelectorAll("a")



                };
            }
                );
            // Marka , fiyat , resim , başlık , derece,url

            List<string> baslikListe = new List<string>();
            List<string> markaListe = new List<string>();
            List<string> fiyatListe = new List<string>();
            List<string> resimListe = new List<string>();
            List<string> urlListe = new List<string>();

            foreach (var link in data)
            {

                foreach (var baslik in link.baslik)
                {

                    baslikListe.Add(baslik.InnerText);
                }

                foreach (var marka in link.marka)
                {
                    markaListe.Add(marka.InnerText.Split(" ")[0]);
                }
                foreach (var fiyat in link.fiyat)
                {
                    fiyatListe.Add(fiyat.InnerText);
                }

                foreach (var resim in link.resim)
                {
                    resimListe.Add(resim.GetAttributeValue("data-src", ""));
                }

                foreach (var url in link.url)
                {
                    urlListe.Add(url.GetAttributeValue("href", ""));
                }

            }
            for (int i = 0; i < baslikListe.Count; i++)
            {
                Laptop laptop = new Laptop()
                {
                    Marka = markaListe[i],
                    Fiyat = fiyatListe[i],
                    Resim = resimListe[i],
                    Baslik = baslikListe[i],
                    Url = urlListe[i],
                    islemciMarkası = "  ",
                    islemciNesli = "  ",
                    islemciTeknolojisi = " ",
                    ram = " ",
                    ekranBoyutu = " ",
                    ekranKartı = "  ",
                    diskKapasitesi = "  ",

                };
                DatabaseConnection.n11Laptops.Add(laptop);


            }
            Detailn11();

        }
        public void DetailTrendyol()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            var computerLinks = new List<List<HtmlNode>>();
            HttpClient client = new HttpClient(clientHandler);

            var requests = DatabaseConnection.trendyolLaptops.Select
               (
                   url => client.GetStringAsync(url.Url)
               ).ToList();

            //Wait for all the requests to finish
            // await Task.WhenAll(requests);

            //Get the responses
            var responses = requests.Select
                (
                    task => task.Result
                );
            //  await Task.WhenAll((Task)responses);
            foreach (var response in responses)
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(response);

                var programmerLinks = htmlDoc.QuerySelectorAll("li")
                      .Where(e => e.GetAttributeValue("class", "") == "detail-attr-item")

        .Take(30)
        .ToList();
                computerLinks.Add(programmerLinks);


            }
            var index = 0;
            foreach (var item in computerLinks)
            {
                foreach (var feature in item)
                {
                    if (feature.InnerText.Contains("İşlemci Tipi"))
                    {
                        DatabaseConnection.trendyolLaptops[index].islemciMarkası = feature.InnerText.Replace("İşlemci Tipi", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("İşlemci Nesli"))
                    {
                        DatabaseConnection.trendyolLaptops[index].islemciNesli = feature.InnerText.Replace("İşlemci Nesli", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("Ram (Sistem Belleği)") && !feature.InnerText.Contains("Tipi "))
                    {
                        DatabaseConnection.trendyolLaptops[index].ram = feature.InnerText.Replace("Ram (Sistem Belleği)", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("Ekran Boyutu"))
                    {
                        DatabaseConnection.trendyolLaptops[index].ekranBoyutu = feature.InnerText.Replace("Ekran Boyutu", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("Ekran Kartı") && !feature.InnerText.Contains("Tipi") && !feature.InnerText.Contains("Hafızası"))
                    {
                        DatabaseConnection.trendyolLaptops[index].ekranKartı = feature.InnerText.Replace("Ekran Kartı", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("SSD Kapasitesi"))
                    {
                        DatabaseConnection.trendyolLaptops[index].diskKapasitesi = feature.InnerText.Replace("SSD Kapasitesi", "").Replace("\n", "");
                    }


                }

                index++;

            }

            DatabaseConnection.TrendyolConnect();


        }
        public void DetailVatan()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            var computerLinks = new List<List<HtmlNode>>();
            HttpClient client = new HttpClient(clientHandler);

            var requests = DatabaseConnection.vatanLaptops.Select
               (
                   url => client.GetStringAsync(url.Url)
               ).ToList();

            //Wait for all the requests to finish
            //  await Task.WhenAll(requests);

            //Get the responses
            var responses = requests.Select
                (
                    task => task.Result
                );
            //  await Task.WhenAll((Task)responses);
            foreach (var response in responses)
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(response);

                /* var programmerLinks = htmlDoc.QuerySelectorAll("ul")
                       .Where(e => e.GetAttributeValue("class", "") == "pdetail-property-list").QuerySelectorAll("li")*/

                var programmerLinks = htmlDoc.QuerySelectorAll("table")
                .Where(e => e.GetAttributeValue("class", "") == "product-table").QuerySelectorAll("tr")


  .Take(30)
  .ToList();
                computerLinks.Add(programmerLinks);
            }
            var index = 0;
            foreach (var item in computerLinks)
            {
                foreach (var feature in item)
                {
                    if (feature.InnerText.Contains("İşlemci Markası"))
                    {
                        DatabaseConnection.vatanLaptops[index].islemciMarkası = feature.InnerText.Replace("İşlemci Markası", "").Replace("&nbsp; İzle", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("İşlemci Nesli"))
                    {
                        DatabaseConnection.vatanLaptops[index].islemciNesli = feature.InnerText.Replace("İşlemci Nesli", "").Replace("\n", "").Replace("&nbsp; İzle", "");
                    }
                    if (feature.InnerText.Contains("İşlemci Teknolojisi"))
                    {
                        DatabaseConnection.vatanLaptops[index].islemciTeknolojisi = feature.InnerText.Replace("İşlemci Teknolojisi", "").Replace("\n", "").Replace("&nbsp; İzle", "");
                    }
                    if (feature.InnerText.Contains("Ram (Sistem Belleği)"))
                    {
                        DatabaseConnection.vatanLaptops[index].ram = feature.InnerText.Replace("Ram (Sistem Belleği)", "").Replace("\n", "").Replace("&nbsp; İzle", "");
                    }
                    if (feature.InnerText.Contains("Ekran Boyutu"))
                    {
                        DatabaseConnection.vatanLaptops[index].ekranBoyutu = feature.InnerText.Replace("Ekran Boyutu", "").Replace("\n", "").Replace("&nbsp; İzle", "");
                    }
                    if (feature.InnerText.Contains("Ekran Kartı"))
                    {
                        DatabaseConnection.vatanLaptops[index].ekranKartı = feature.InnerText.Replace("Ekran Kartı Tipi", "").Replace("Ekran Kartı Chipset Marka", "").Replace("\n", "").Replace("&nbsp; İzle", "");
                    }
                    if (feature.InnerText.Contains("Disk Kapasitesi"))
                    {
                        DatabaseConnection.vatanLaptops[index].diskKapasitesi = feature.InnerText.Replace("Disk Kapasitesi", "").Replace("&nbsp; İzle", "").Replace("\n", "");
                    }


                }

                index++;

            }

            DatabaseConnection.VatanConnect();

        }
        public void Detailn11()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            var computerLinks = new List<List<HtmlNode>>();
            HttpClient client = new HttpClient(clientHandler);

            var requests = DatabaseConnection.n11Laptops.Select
               (
                   url => client.GetStringAsync(url.Url)
               ).ToList();

            //Wait for all the requests to finish
            //  await Task.WhenAll(requests);

            //Get the responses
            var responses = requests.Select
                (
                    task => task.Result
                );
            // await Task.WhenAll((Task)responses);
            foreach (var response in responses)
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(response);

                /* var programmerLinks = htmlDoc.QuerySelectorAll("ul")
                       .Where(e => e.GetAttributeValue("class", "") == "pdetail-property-list").QuerySelectorAll("li")*/

                var programmerLinks = htmlDoc.QuerySelectorAll("li")
                .Where(e => e.GetAttributeValue("class", "") == "unf-prop-list-item")


  .Take(30)
  .ToList();
                computerLinks.Add(programmerLinks);
            }
            var index = 0;
            foreach (var item in computerLinks)
            {
                foreach (var feature in item)
                {
                    if (feature.InnerText.Contains("İşlemci") && !feature.InnerText.Contains("İşlemci Çekirdek Sayısı") && !feature.InnerText.Contains("İşlemci Modeli") && !feature.InnerText.Contains("İşlemci Hızı"))
                    {
                        DatabaseConnection.n11Laptops[index].islemciMarkası = feature.InnerText.Replace("İşlemci", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("İşlemci Nesli"))
                    {
                        DatabaseConnection.n11Laptops[index].islemciNesli = feature.InnerText.Replace("İşlemci Nesli", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("İşlemci Teknolojisi"))
                    {
                        DatabaseConnection.n11Laptops[index].islemciTeknolojisi = feature.InnerText.Replace("İşlemci Teknolojisi", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("Bellek Kapasitesi"))
                    {
                        DatabaseConnection.n11Laptops[index].ram = feature.InnerText.Replace("Bellek Kapasitesi", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("Ekran Boyutu"))
                    {
                        DatabaseConnection.n11Laptops[index].ekranBoyutu = feature.InnerText.Replace("Ekran Boyutu", "").Replace("\n", "").Replace("&quot", "").Replace(";", "");
                    }
                    if (feature.InnerText.Contains("Ekran Kartı Modeli"))
                    {
                        DatabaseConnection.n11Laptops[index].ekranKartı = feature.InnerText.Replace("Ekran Kartı Modeli", "").Replace("\n", "");
                    }
                    if (feature.InnerText.Contains("Disk Kapasitesi"))
                    {
                        DatabaseConnection.n11Laptops[index].diskKapasitesi = feature.InnerText.Replace("Disk Kapasitesi", "").Replace("\n", "");
                    }


                }

                index++;

            }

            DatabaseConnection.n11Connect();

        }
        private void ParseHtmlTrendyol(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var programmerLinks = htmlDoc.QuerySelectorAll("div")
                  .Where(e => e.GetAttributeValue("class", "") == "p-card-wrppr with-campaign-view")

    .Take(30)
    .ToList();

            var data = programmerLinks.Select((node) =>
            {
                return new
                {
                    baslik = node.QuerySelectorAll("div")
                  .Where(e => e.GetAttributeValue("class", "") == "prdct-desc-cntnr-ttl-w two-line-text"),

                    marka = node.QuerySelectorAll("span")
                  .Where(e => e.GetAttributeValue("class", "") == "prdct-desc-cntnr-ttl"),

                    fiyat = node.QuerySelectorAll("div")
                  .Where(e => e.GetAttributeValue("class", "") == "prc-box-dscntd"),

                    resim = node.QuerySelectorAll("img")
                  .Where(e => e.GetAttributeValue("class", "") == "p-card-img"),

                    url = node.QuerySelectorAll("div")
                  .Where(e => e.GetAttributeValue("class", "") == "p-card-chldrn-cntnr card-border")


                };
            }
                );
            // Marka , fiyat , resim , başlık , derece,url

            List<string> baslikListe = new List<string>();
            List<string> markaListe = new List<string>();
            List<string> fiyatListe = new List<string>();
            List<string> resimListe = new List<string>();
            List<string> urlListe = new List<string>();
            foreach (var link in data)
            {

                foreach (var baslik in link.baslik)
                {

                    baslikListe.Add(baslik.InnerText);
                }

                foreach (var marka in link.marka)
                {
                    markaListe.Add(marka.InnerText);
                }
                foreach (var fiyat in link.fiyat)
                {
                    fiyatListe.Add(fiyat.InnerText);
                }

                foreach (var resim in link.resim)
                {
                    resimListe.Add(resim.GetAttributeValue("src", ""));
                }

                foreach (var url in link.url)
                {
                    urlListe.Add(url.FirstChild.GetAttributeValue("href", ""));
                }

            }
            for (int i = 0; i < baslikListe.Count; i++)
            {
                Laptop laptop = new Laptop
                {
                    Marka = markaListe[i],
                    Fiyat = fiyatListe[i],
                    Resim = resimListe[i],
                    Baslik = baslikListe[i],
                    Url = "https://www.trendyol.com" + urlListe[i],
                    islemciMarkası = "  ",
                    islemciNesli = "  ",
                    islemciTeknolojisi = " ",
                    ram = " ",
                    ekranBoyutu = " ",
                    ekranKartı = "  ",
                    diskKapasitesi = "  ",
                };
                DatabaseConnection.trendyolLaptops.Add(laptop);


            }
            DetailTrendyol();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
