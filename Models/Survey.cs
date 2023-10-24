#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace EcuestaDojoValidacion.Models;

public class Survey{
    [Required(ErrorMessage = "Por favor proporciona este dato!")]
    [MinLength(2, ErrorMessage="Tu nombre debe de tener al menos 2 caracteres.")]
    public string Nombre {get;set;}

    [Required(ErrorMessage = "Por favor proporciona este dato!")]
    public string Locacion {get;set;}

    [Required(ErrorMessage = "Por favor proporciona este dato!")]
    public string Lenguaje {get;set;}

    [Required(AllowEmptyStrings = true)]
    public string Comentario {get;set;}
}