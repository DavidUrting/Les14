﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Les14.Models.EntityFramework
{
    public class KeyViewModel
    {
        /// <summary>
        /// Bevat de max value van de kolom + 1.
        /// Dit wordt als suggestie gegeven voor een nieuwe key in de NoAutoGeneratedKey tabel.
        /// </summary>
        public int KeySuggestionForNoAutoGeneratedKey { get; set; }
    }
}
