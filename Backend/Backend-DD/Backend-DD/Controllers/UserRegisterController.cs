using BackendCrudMascota.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 

namespace Backend_DD.Controllers
{
    [Route("api/[controller]")] // Url de referencia 
    [ApiController]
    public class UserRegisterController : ControllerBase
    {
        // Variable privada de lectura 
        private readonly AplicationDBContext _dbContext;

        // Accedemos a la variable y hacer peticion a la base de datos y actualizarala etc
        public UserRegisterController(AplicationDBContext dbContext) 
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                // Hacemos una peticion que nos traiga los elementos de la tabla user 
                var listUser = await _dbContext.UserRegister.ToListAsync(); 
                return Ok(listUser);
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }

        }
    }
}
