using Microsoft.AspNetCore.Mvc;
using GameBackend.Models;

namespace GameBackend.Controllers;

[ApiController] // Fala que a classe é uma api
[Route("game")] // Define a rota
public class GameController: ControllerBase
{

    List<Game> lista = new List<Game>();

    [HttpGet] // Manda executar o método GET na rota /game
    public ActionResult Read() // ActionResult retorna os Status
    {
        Game g1 = new Game();
        g1.gameId = 1;
        g1.name = "GAME 1";
        g1.status = true;

        lista.Add(g1);
        
        return Ok(lista);
    }

    [HttpPost] // Manda executar o método POST na rota /game
    public ActionResult Create()
    {
        //Processar oq quiser
        //return NoContent();
        return Created("", null);
    }
}