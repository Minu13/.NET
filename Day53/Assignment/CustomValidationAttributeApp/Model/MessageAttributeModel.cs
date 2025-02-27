using CustomValidationAttributeApp.Validator;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationAttributeApp.Model
{
    public class MessageAttributeModel
    {
        [ContainsWord("important")]
        public string MessageContent { get; set; }
    }
}
