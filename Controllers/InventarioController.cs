using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApp.Controllers.Models;

namespace WebApp.Controllers
{
    [Route("api/inventario")]
    
    public class InventarioController : ControllerBase
    {

        private readonly ApplicarionDbContext context;

        public InventarioController(ApplicarionDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<List<Inventario>> GetAll()
        {
            return await context.Inventario.ToListAsync();
        }

        [HttpGet("{id:int}",Name = "ObtenerInventarioPorId")]
        public async Task<ActionResult<Inventario>> Get(int id)
        {
            var Inventario = await context.Inventario.FirstOrDefaultAsync(x => x.ProductoId == id);
            if (Inventario is null) 
            {
                return NotFound();
            }
            return Inventario;
        }

        [HttpPost]
        public async Task<CreatedAtRouteResult> Post([FromBody] Inventario inventario)
        {

            context.Add(inventario);
            await context.SaveChangesAsync();
            return CreatedAtRoute("ObtenerInventarioPorId", new { id = inventario.ProductoId }, inventario);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Inventario>> Put(int id,[FromBody] Inventario inventario)
        {
            var existeInventario = await context.Inventario.AnyAsync(x => x.ProductoId == id);

            if (!existeInventario)
            {
                return NotFound();
            }

            context.Update(inventario);

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete (int id)
        {
            var filasBorradas = await context.Inventario.Where(x => x.ProductoId == id).ExecuteDeleteAsync();

            if (filasBorradas==0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
