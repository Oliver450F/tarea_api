using Microsoft.AspNetCore.Mvc;
 using System.Linq;
 using System.Threading.Tasks;
 using web_api_1.Models;
namespace web_api_1.Controllers{
     [Route("api/[controller]")]
public class empleadosController : Controller{

private Conexion dbConexion;
public  empleadosController(){
    dbConexion=ControllerContextAttribute.Create();
}
 [HttpGet]
         public ActionResult Get(){
            return Ok(dbConexion.empleados.ToArray());
         }
          [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id){
 var clientes = await dbConexion.Clientes.FindAsync(id);
            if (clientes !=null){
                return Ok(empleados);

            }else{
                return NotFound();

            }
        }
}

}