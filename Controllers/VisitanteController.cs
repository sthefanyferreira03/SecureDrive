using Microsoft.AspNetCore.Mvc;
using SecureDrive.Models;
using SecureDrive.Services;

[Route("api/[controller]")]
[ApiController]
public class VisitanteController : ControllerBase
{
    private readonly IVisitanteService _visitanteService;

    public VisitanteController(IVisitanteService visitanteService)
    {
        _visitanteService = visitanteService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_visitanteService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var visitante = _visitanteService.GetById(id);
        if (visitante == null) return NotFound();
        return Ok(visitante);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Visitante visitante)
    {
        var novoVisitante = _visitanteService.Add(visitante);
        return CreatedAtAction(nameof(Get), new { id = novoVisitante.Id }, novoVisitante);
    }
}
