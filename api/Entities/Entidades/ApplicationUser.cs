using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Entities.Entidades;

public class ApplicationUser : IdentityUser
{
    [Column("USR_CPF")]
    public string CPF { get; set; }
}