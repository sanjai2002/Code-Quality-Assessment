namespace CreateApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using CreateApi.Data;
using Microsoft.EntityFrameworkCore;
[ApiController]
  public class UserController : ControllerBase{
      private readonly Appdbcontext context;
        public UserController(Appdbcontext context){
            this.context=context; 
        }

     [HttpPost]
     [Route("PostMovie")]
    public async Task<IActionResult> PostUser(MovieModel MovieModel)
    {
        context.Add(MovieModel);
        
        return Ok(await context.SaveChangesAsync());
    }

  }