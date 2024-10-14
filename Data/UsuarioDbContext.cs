using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsuarioAPI.Models;

namespace UsuarioAPI.Data;

public class UsuarioDbContext : IdentityDbContext<Usuario>
{
    public UsuarioDbContext(DbContextOptions opts) : base (opts)
    {
        
    }
}
