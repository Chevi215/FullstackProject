﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Canvas.Core.Entities
{
    public class Favorite_Drowings
    {
        public int Id { get; set; } 
        public int User_Id { get; set; }
        public int Drowing_Id { get; set; }
    }
}
