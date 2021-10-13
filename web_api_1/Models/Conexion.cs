using Microsoft.EntityFrameworkCore;
namespace web_api_1.Models{
class Conexion: DbContext{
    public Conexion (DbContextOptions <Conexion> options): base(options){}
public DbSet <empleados> empleados{get;set;}

    }
   class Conectar{
private const string cadenaConexion="servert=localhost;port=3306;database=empresabd2;userid=fnl_empresa;pwd=final123";
public static Conexion Create(){
    var constructor = new DbContextOptionsBuilder<Conexion>();
constructor.UseMySQL(cadenaConexion);
var cn= new Conexion(constructor.Options);
}
   }
    }
      
    
   



