//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto01Fabio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class STUDENT
    {
        public int idStudent { get; set; }

        [Required]
        [RegularExpression((@"([A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ](\s)*)+"), ErrorMessage = "Introduce  correct code, with out letters")]
        public string typeDocumentStudent { get; set; }

        [Required]
        [RegularExpression((@"\d+"), ErrorMessage = "Introduce  correct document, without letters")]
        public int documentStudent { get; set; }

        [Required]
        [RegularExpression((@"\d+"), ErrorMessage = "Introduce  correct code, with out letters")]
        public int codeStudent { get; set; }

        [Required]
        [RegularExpression((@"([A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ](\s)*)+"), ErrorMessage = "Introduce a correct name, it doesn't have to have numbers")]
        public string nameStudent { get; set; }
        [Required]
        [RegularExpression((@"([A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ](\s)*)+"), ErrorMessage = "Introduce a correct last name, it doesn't have to have numbers")]
        public string lastNameStudent { get; set; }

        [Required]
        [StringLength(9, ErrorMessage = "You have to write a correct gender")]
        public string genderStudent { get; set; }

        [Required]
        [EmailAddress]
        public string emailStudent { get; set; }

        [Required]
        [RegularExpression((@"\d+"), ErrorMessage = "Introduce a correct phone")]
        public int phoneStudent { get; set; }
    }
}
