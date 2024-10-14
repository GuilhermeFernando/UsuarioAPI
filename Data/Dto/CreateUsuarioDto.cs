using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI.Data.Dto;

public class CreateUsuarioDto 
{
    [Required]
    public string Usuario { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Required]
    [Compare("Senha")]
    public string ConfirmaSenha { get; set; }
}
