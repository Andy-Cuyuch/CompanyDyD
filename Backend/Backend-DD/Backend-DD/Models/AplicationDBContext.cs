
// La clase permite  crear la base de datos, acceder,insertar,actualizar etc.
using Backend_DD.Models;
using Microsoft.EntityFrameworkCore; 

namespace BackendCrudMascota.Models
{
    // Nos va a permitir acceder a la base de datos
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options) { 
        
        
        }

        // Set por cada tabla
        public DbSet<UserRegister> UserRegister { get; set; }
       
    }
}
