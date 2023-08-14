using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class HistOperation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Result { get; set; }
        public DateTime Date { get; set; }
    }
}
