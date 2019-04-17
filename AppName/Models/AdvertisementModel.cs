﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppName.Models
{
    public class AdvertisementModel : BaseModel
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float Yardage { get; set; } //metraż
        public string PhoneNumber { get; set; }
       // public DateTime CreationDate { get; set; }

        public string username { get; set; }

        // one to many relation with Category
        public virtual CategoryModel Category { get; set; }
       // public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // one to many relation with Province
        public virtual ProvinceModel Province { get; set; } // województwo
<<<<<<< HEAD
        public int? ProvinceId { get; set; }
        public string ProvinceName { get; set; }
=======
        //public int? ProvinceId { get; set; }
        public string ProvinceName{ get; set; }
>>>>>>> 598e5090ac9e40d78977bd5ca2db1511f456118b

        // one to many relation with City
        public virtual CityModel City { get; set; }
        //public int? CityId { get; set; }
        public string CityName { get; set; }

        /*
        public AdvertisementModel(Guid id, string title, string nameAdvert, string description, string type)
        {
            Id = Guid.NewGuid();
            Title = title;
            NameAdvert = nameAdvert;
            Type = type;
        }
        */

    }
}
