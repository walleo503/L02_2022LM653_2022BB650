﻿using Microsoft.EntityFrameworkCore;

namespace L02_2022LM653_2022BB650.Models
{
    public class dastosDbConext : DbContext
    {
        public dastosDbConext(DbContextOptions options) : base(options) {
        
        }

    }
}
