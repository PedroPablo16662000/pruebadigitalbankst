using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

[DataContract]
public class UsuarioModel
{
    [DataMember]
    public decimal idUsuario { get; set; }

    [DataMember]
    [Required(ErrorMessage = "El campo es necesario")]
    [MaxLength(100, ErrorMessage = "No se admite más de 100 un caracteres")]
    public string nombreUsuario { get; set; }

    [DataMember]
    public DateTime fechaNacimientoUsuario { get; set; }

    [DataMember]
    [MaxLength(1, ErrorMessage = "No se admite más de un caracter")]
    public string SexoUsuario { get; set; }
}

