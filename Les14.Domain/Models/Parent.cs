using System;
using System.Collections.Generic;

namespace Les14.Domain
{
    public class Parent
    {
        public int Id { get; set; }

        public ICollection<Child> Children { get; set; }
    }
}
