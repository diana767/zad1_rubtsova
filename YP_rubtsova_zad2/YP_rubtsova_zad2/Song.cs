﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_rubtsova_zad2
{
    struct Song
    {
        public string author;
        public string title;
        public string filename;

        public Song(string authorr, string titlee, string filenamee)
        {
            author = authorr;
            title = titlee;
            filename = filenamee;
        }
    }
}