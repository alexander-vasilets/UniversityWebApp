using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApp.Models.Validations
{
    public class DisciplineChoiceValidation : ValidationAttribute
    {
        int _maxCount;

        public DisciplineChoiceValidation(int maxCount)
        {
            _maxCount = maxCount;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var discs = value as List<DisciplineFilter>;
            if (discs.Count(d => d.Selected == true) > _maxCount)
            {
                var errMess = $"Having {validationContext.DisplayName} disciplines is not allowed (maximum is {_maxCount}).";
                return new ValidationResult(errMess);
            }
            return ValidationResult.Success;
        }
    }
}
