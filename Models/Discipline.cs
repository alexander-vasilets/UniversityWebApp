using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApp.Models
{
    public class Discipline
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Annotation { set; get; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { set; get; }

    }
}
