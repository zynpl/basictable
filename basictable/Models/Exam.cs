using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace basictable.Models
{
    public class Exam
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int firstExam { get; set; }
        public int secondExam { get; set; }
        public int Project { get; set; }
        public string final { get; set; }
    }
}
