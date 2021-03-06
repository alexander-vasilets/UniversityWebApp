﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApp.Models.Validations;

namespace UniversityWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Discipline> Disciplines { get; set; }
    }

    public class SelectDisciplineViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        [DisciplineChoiceValidation(3)]
        public List<DisciplineFilter> Filters { get; set; }
    }
    public class DisciplineFilter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}
