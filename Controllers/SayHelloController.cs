//Harrison Busby
//10/27/2022
//Mini Challenge 1 Endpoints
//Peer reviewed by: Jasmine Leek - clean, simple code that runs as expected when tested. nice job


using Microsoft.AspNetCore.Mvc;

namespace BusbyHSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
   [HttpGet]
   [Route("Hello/{name}")]

   public string Big(string name){

return $"Hello {name}, it is nice to meet you";

}
}
