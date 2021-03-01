using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Exam.Data
{
    public class Map
    {
        [Key]
        public int Id {get; set;}
        public List<Cell> Cells {get;set;}
        public User Owner {get;set;}
    }
}