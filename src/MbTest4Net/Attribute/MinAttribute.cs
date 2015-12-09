using System;
using System.ComponentModel.DataAnnotations;

namespace MbTest4Net.Attribute
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class MinAttribute : ValidationAttribute
    {
        public object Min { get { return _min; } }

        private readonly double _min;

        public MinAttribute(int min)
            : base("min")
        {
            _min = min;
        }

        public MinAttribute(double min)
            : base("min")
        {
            _min = min;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return new ValidationResult("Value cannot be null");

            double valueAsDouble;
            var isDouble = double.TryParse(Convert.ToString(value), out valueAsDouble);
            if (isDouble && valueAsDouble < _min)
            {
                return new ValidationResult(string.Format("{0} is less than {1}.", value, _min));    
            }

            return ValidationResult.Success;
        }
    }
}