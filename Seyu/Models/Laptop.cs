﻿
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Seyu.Models
{
  

   
        public class Laptop
        {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string Id { get; set; }


        // Marka , fiyat , resim , başlık , derece,url

        public string Marka { get; set; }
            public string Fiyat { get; set; }
            public string Resim { get; set; }
            public string Baslik { get; set; }
            public string Url { get; set; }
            public string Derece { get; set; }


        public string islemciMarkası { get; set; }
        public string islemciNesli { get; set; }
        public string islemciTeknolojisi { get; set; }
        public string ram { get; set; }
        public string ekranBoyutu { get; set; }
        public string ekranKartı { get; set; }
        public string diskKapasitesi { get; set; }

    }
    
}