﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcNinjectFluentValidation.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }

    }
}