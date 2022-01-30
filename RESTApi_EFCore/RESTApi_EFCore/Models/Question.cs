using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApi_EFCore.Models
{
    internal sealed class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        [MaxLength(200)]
        public string LibelleQuestion { get; set; } = string.Empty;


    }
}
