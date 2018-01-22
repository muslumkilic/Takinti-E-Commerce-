﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Takinti.Models
{
    public class Cart
    {

        Cart()
        {

            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            CartItems = new HashSet<CartItem>();


        }

        public int Id { get; set; }
        public string UserName { get; set; }


        //public Guid? UserId { get; set; }

        //[ForeignKey("UserId")]
        //public virtual ApplicationUser User { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int ProductCount { get { return CartItems.Sum(ci=>ci.Quantity); } } // sepetteki ürünün sayısı


        public decimal TotalPrice { get { return CartItems.Sum(ci => ci.TotalPrice); } } // buraya geri dönülecek
        public virtual ICollection<CartItem> CartItems { get; set; }




    }
}