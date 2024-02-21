using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projekat;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LicencaController : ControllerBase
{
    [HttpPost]
    [Route("Insert")]
    public async Task<IActionResult> Insert(LicencaBasic licenca)
    {
        try
        {
            var result = await DTOManager.SacuvajLicencuAsync(licenca);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await DTOManager.VratiLicence();
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }


}
