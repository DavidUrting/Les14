﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Les14.Domain.Models
{
    public class NoAutoGeneratedKey
    {
        // Mapt NIET op een 'Identity' column: de database kent dus geen nummer toe.
        public int Id { get; set; }
    }
}
