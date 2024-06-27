using Microsoft.AspNetCore.Mvc;
using SecureDrive.Models;
using SecureDrive.Services;

[Route("api/[controller]")]
[ApiController]
public class VeiculoController : ControllerBase
{
    private readonly IVeiculoService _veiculoService;

    public VeiculoController(IVeiculoService veiculoService)
    {
        _veiculoService = veiculoService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_veiculoService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var veiculo = _veiculoService.GetById(id);
        if (veiculo == null) return NotFound();
        return Ok(veiculo);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Veiculo veiculo)
    {
        var novoVeiculo = _veiculoService.Add(veiculo);
        return CreatedAtAction(nameof(Get), new { id = novoVeiculo.Id }, novoVeiculo);
    }
}
