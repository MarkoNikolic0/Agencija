using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Projekat;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UpravnikController : ControllerBase
{
    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
		try
		{
			var result = await DTOManager.VratiUpravnike();
			return StatusCode(StatusCodes.Status200OK, result);
		}
		catch (Exception ex) 
		{
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
		}
    }

	[HttpPost]
	[Route("Insert")]
	public async Task<IActionResult> Insert(UpravnikBasic upravnik, string licencaId)
	{
		try
		{
			var result = await DTOManager.SacuvajUpravnikaAsync(upravnik, licencaId);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Update(UpravnikBasic upravnik)
    {
		try
		{
			var result = await DTOManager.IzmeniUpravnikaAsync(upravnik);
            return StatusCode(StatusCodes.Status200OK, $"Uspesno izmenjen upravnik: {result.Ime} {result.Prezime}");
        }
		catch (Exception ex)
		{
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
		}
    }

    [HttpDelete]
    [Route("Delete/{upravnikId}")]
    public async Task<IActionResult> Delete(string upravnikId)
    {
        try
        {
            await DTOManager.obrisiUpravnika(upravnikId);
            return StatusCode(StatusCodes.Status200OK, $"Uspesno obrisan upravnik sa ID-jem: {upravnikId}");
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }
}

