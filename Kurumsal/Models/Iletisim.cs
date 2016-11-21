﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kurumsal.Models
{
    [Table("tblIletisim")]
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }
    }
}