﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


//We’ll allow users to place albums in their cart without registering, but they’ll need to register as guests to complete checkout
namespace MVCMusicStore.Models
{
    public class Cart
    {
        // Our Cart items will have a string identifier named CartID to allow anonymous shopping
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; }
    }
}