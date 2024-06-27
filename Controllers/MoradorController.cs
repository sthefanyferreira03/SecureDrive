using Microsoft.AspNetCore.Mvc;
using SecureDrive.Models;
using SecureDrive.Services;

[Route("api/[controller]")]
[ApiController]
public class MoradorController : ControllerBase
{
    private readonly IMoradorService _moradorService;

    public MoradorController(IMoradorService moradorService)
    {
        _moradorService = moradorService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_moradorService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var morador = _moradorService.GetById(id);
        if (morador == null) return NotFound();
        return Ok(morador);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Morador morador)
    {
        var novoMorador = _moradorService.Add(morador);
        return CreatedAtAction(nameof(Get), new { id = novoMorador.Id }, novoMorador);
    }

    [HttpPost("{cpf}/veiculos")]
    public IActionResult AddVeiculo(string cpf, [FromBody] Veiculo veiculo)
    {
        _moradorService.AddVeiculo(cpf, veiculo);
        return NoContent();
    }

    [HttpPost("{cpf}/visitantes")]
    public IActionResult AddVisitante(string cpf, [FromBody] Visitante visitante)
    {
        _moradorService.AddVisitante(cpf, visitante);
        return NoContent();
    }
}
