using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Projekat;
using Projekat.Entiteti;
using System.Runtime.InteropServices;

namespace API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ZgradaController : ControllerBase
{

    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {

        try
        {
            List<ZgradaPregled> result = await DTOManager.VratiZgrade();
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut]
    [Route("Delete/{zgradaId}")]
    public async Task<IActionResult> Delete([FromRoute]string zgradaId)
    {
        try
        {
            await DTOManager.ObrisiZgradu(zgradaId);
            return StatusCode(StatusCodes.Status202Accepted, $"Uspesno obrisana zgrada sa id-jem: {zgradaId}");
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet]
    [Route("Get/{zgradaId}")]
    public async Task<IActionResult> Get([FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.VratiZgradu(zgradaId);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    [Route("Create")]
    public async Task<IActionResult> Create(ZgradaBasic zgrada, string upravnikId)
    {
        try
        {
            var result = await DTOManager.SacuvajZgraduAsync(zgrada, upravnikId);
            return StatusCode(StatusCodes.Status200OK, result);

        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    [Route("CreateUlaz")]
    public async Task<IActionResult> CreateUlaz(UlaziBasic ulaz,string zgradaId)
    {
        try
        {
            await DTOManager.SacuvajUlazAsync(ulaz, zgradaId);
            return StatusCode(StatusCodes.Status201Created);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    [Route("CreateLift")]
    public async Task<IActionResult> CreateLift(LiftBasic lift,string zgradaId)
    {
        try
        {
            await DTOManager.SacuvajLiftAsync(lift, zgradaId);
            return StatusCode(StatusCodes.Status201Created, "Uspesno dodat lift");
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        } 
    }

    [HttpGet]
    [Route("Ulaz/GetAll")]
    public async Task<IActionResult> UlaziGetAll(string zgradaId)
    {
        try
        {
            var result =  DTOManager.vratiUlazeZgrade(zgradaId);

            return StatusCode(StatusCodes.Status200OK, result);

        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("Lift/GetAll")]
    public async Task<IActionResult> LiftoviGetAll(string zgradaId)
    {
        try
        {
            var result = await DTOManager.vratiLiftoveZgrade(zgradaId);

            return StatusCode(StatusCodes.Status200OK, result);

        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
            throw;
        }
    }

    [HttpGet]
    [Route("Lift/GetAllByType")]
    public async Task<IActionResult> LiftGetAllByType()
    {
        try
        {
            IEnumerable<LiftPregled> result = DTOManager.VratiLiftovePoTipuAsync();

            return StatusCode(StatusCodes.Status200OK, result.ToList());

        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpDelete]
    [Route("Garaza/Delete/{garazaId}")]
    public async Task<IActionResult> GarazaDelete([FromRoute]string garazaId)
    {
        try
        {
            await Task.Delay(1);
            DTOManager.ObrisiGarazu(garazaId);
            return StatusCode(StatusCodes.Status200OK, "Uspesno brisanje");
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("Parking/GetALl/{zgradaId}")]
    public async Task<IActionResult> ParkingGetAll([FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.vratiParkingMestaZgrade(zgradaId);

            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("StambeniProstor/GetALl/{zgradaId}")]
    public async Task<IActionResult> StambeniProstorGetAll([FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.VratiStambeniProstor(zgradaId);

            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("PoslovniProstor/GetALl/{zgradaId}")]
    public async Task<IActionResult> PoslovniProstorGetAll([FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.VratiPoslovniProstor(zgradaId);

            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("Garaza/GetALl/{zgradaId}")]
    public async Task<IActionResult> GarazaGetAll([FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.VratiGarazu(zgradaId);

            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPut]
    [Route("Garaza/Update")]
    public async Task<IActionResult> GarazaUpdate(GarazaBasic garaza)
    {
        try
        {
            DTOManager.IzmeniGarazu(garaza);
            return StatusCode(StatusCodes.Status200OK); 
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPost]
    [Route("{zgradaId}/Garaza/Insert")]
    public async Task<IActionResult> GarazaInsert(GarazaBasic garaza, [FromRoute]string zgradaId)
    {
        try
        {
            var result = await DTOManager.SacuvajGarazuAsync(garaza, zgradaId);
            return StatusCode(StatusCodes.Status201Created, result);    
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPost]
    [Route("{zgradaId}/StambeniProstor/Insert")]
    public async Task<IActionResult> StambeniProstorInsert(StambeniProstorBasic stambeniProstor, [FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.SacuvajStambeniProstorAsync(stambeniProstor, zgradaId);
            return StatusCode(StatusCodes.Status201Created, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPost]
    [Route("{zgradaId}/PoslovniProstor/Insert")]
    public async Task<IActionResult> PoslovniProstorInsert(PoslovniProstorBasic poslovniProstor, [FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.SacuvajPoslovniProstorAsync(poslovniProstor, zgradaId);
            return StatusCode(StatusCodes.Status201Created, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPost]
    [Route("PoslovniProstor/{poslovniProstorId}/InsertLokal")]
    public async Task<IActionResult> InsertLokal(LokalBasic lokal, [FromRoute] string poslovniProstorId)
    {
        try
        {
            await DTOManager.SacuvajLokalAsync(lokal, poslovniProstorId);
            return StatusCode(StatusCodes.Status201Created);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("{zgradaId}/Lokal/GetAll")]
    public async Task<IActionResult> LokaliGetAll([FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.vratiLokaleZgrade(zgradaId);
            return StatusCode(StatusCodes.Status201Created, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPost]
    [Route("{zgradaId}/Ugovor/Insert")]
    public async Task<IActionResult> UgovorInsert(UgovorBasic ugovor, [FromRoute] string zgradaId)
    {
        try
        {
            await DTOManager.SacuvajUgovorAsync(ugovor, zgradaId);
            return StatusCode(StatusCodes.Status201Created);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpDelete]
    [Route("Stan/Delete/{stanId}")]
    public async Task<IActionResult> StanDelete([FromRoute] string stanId)
    {
        try
        {
            await DTOManager.ObrisiStanAsync(stanId);
            return StatusCode(StatusCodes.Status201Created);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("Stan/{stanId}/Vlasnik/Get")]
    public async Task<IActionResult> VlasnikGet([FromRoute] string stanId)
    {
        try
        {
            var result = await DTOManager.VratiVlasnikaPremaStanu(stanId);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpGet]
    [Route("{zgradaId}/Stan/GetAll")]
    public async Task<IActionResult> StanoviGetAll([FromRoute] string zgradaId)
    {
        try
        {
            var result = await DTOManager.vratiStanoveZgrade(zgradaId);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPost]
    [Route("StambeniProstor/{stambeniProstorId}/Stan/Insert")]
    public async Task<IActionResult> StanInsert(StanBasic stan,[FromRoute]string stambeniProstorId)
    {
        try
        {
            var result = await DTOManager.SacuvajStanAsync(stan,stambeniProstorId);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }

    [HttpPost]
    [Route("Stan/{stanId}/Vlasnik/Insert")]
    public async Task<IActionResult> VlasnikInsert(VlasnikBasic vlasnik, [FromRoute]string stanId)
    {
        try
        {
            var result = await DTOManager.SacuvajVlasnikaAsync(vlasnik, stanId);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, error);
        }
    }
}
