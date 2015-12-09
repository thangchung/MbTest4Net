using System;
using System.ComponentModel.DataAnnotations;

namespace MbTest4Net.Attribute
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class IntegerAttribute : ValidationAttribute
    {
        public IntegerAttribute()
            : base("integer")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return new ValidationResult("Value cannot be null");

            int retNum;

            if (!int.TryParse(Convert.ToString(value), out retNum))
            {
                ErrorMessage = string.Format("{0} is not a numeric.", retNum);        
            }

            return ValidationResult.Success;
        }
    }
}