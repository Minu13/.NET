using System.ComponentModel.DataAnnotations;

namespace CustomValidationAttributeApp.Validator
{
    public class ContainsWordAttribute : ValidationAttribute
    {
        private readonly string _word;

        public ContainsWordAttribute(string word)
        {
            _word = word;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success; 
            }

            string stringValue = value.ToString();

            if (!stringValue.Contains(_word))
            {
                return new ValidationResult(ErrorMessage ?? $"The field must contain the word '{_word}'.");
            }
            return ValidationResult.Success;
        }
    }
}

