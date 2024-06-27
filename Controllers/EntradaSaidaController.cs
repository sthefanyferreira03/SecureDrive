using Microsoft.AspNetCore.Mvc;
using SecureDrive.Models;
using SecureDrive.Services;

[Route("api/[controller]")]
[ApiController]
public class EntradaSaidaController : ControllerBase
{
    private readonly IEntradaSaidaService _entradaSaidaService;

    public EntradaSaidaController(IEntradaSaidaService entradaSaidaService)
    {
        _entradaSaidaService = entradaSaidaService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_entradaSaidaService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var entradaSaida = _entradaSaidaService.GetById(id);
        if (entradaSaida == null) return NotFound();
        return Ok(entradaSaida);
    }

    [HttpPost]
    public IActionResult Post([FromBody] EntradaSaida entradaSaida)
    {
        var novaEntradaSaida = _entradaSaidaService.Add(entradaSaida);
        return CreatedAtAction(nameof(Get), new { id = novaEntradaSaida.Id }, novaEntradaSaida);
    }
}
