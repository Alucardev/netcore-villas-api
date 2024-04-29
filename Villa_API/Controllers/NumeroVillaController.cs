using AutoMapper;
using Data;
using Data.Dtos;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace Villa_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroVillaController : ControllerBase
    {
        private readonly ILogger<NumeroVillaController> _logger;
        private readonly INumberVillaRepository _numberRepo;
        private readonly IVillaRepository _villaRepo;
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        protected APIResponse _response;

        

        public NumeroVillaController(ILogger<NumeroVillaController> logger, ApplicationDbContext db, IMapper mapper, INumberVillaRepository numberRepo, IVillaRepository villarepo)
        {
            _db = db;
            _numberRepo = numberRepo;
            _logger = logger;
            _mapper = mapper;
            _villaRepo = villarepo;
            _response = new();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetNumberVillas()
        {
            try
            {
                _logger.LogInformation("Obtener numeros villas ");
                IEnumerable<NumberVilla> numberVillaList = await _numberRepo.GetAll();

                _response.Result = _mapper.Map<IEnumerable<NumberVillaDto>>(numberVillaList);
                _response.statusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.ErrorMessages = new List<string>() { ex.ToString()};
            }
            return _response;
        }

        [HttpGet("id:int", Name = "GetNumberVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetNumberVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Error al traer numero Villa con Id" + id);
                    _response.statusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var numberVilla = await _numberRepo.Get(v => v.VillaNumber == id);

                if (numberVilla == null)
                {
                    _response.statusCode = HttpStatusCode.NotFound;
                    _response.Error = true;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<NumberVillaDto>(numberVilla);
                _response.statusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.Error = true;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateNumberVilla([FromBody] NumberVillaCreateDto numberVillaCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(_response);
                }

                if (await _numberRepo.Get(v => v.VillaNumber == numberVillaCreateDto.VillaNumber) != null)
                {
                    ModelState.AddModelError("VillaNumberExist", "El Numero de villa ya existe.");
                    return BadRequest(ModelState);
                }

                if (numberVillaCreateDto == null)
                {
                    return BadRequest(numberVillaCreateDto);
                }

                NumberVilla model = _mapper.Map<NumberVilla>(numberVillaCreateDto);
                await _numberRepo.Create(model);
                model.CreationDate = DateTime.Now;
                model.UpdateDate = DateTime.Now;
                _response.Result = model;
                _response.statusCode = HttpStatusCode.Created;
                CreatedAtRoute("GetNumberVilla", new { id = model.VillaNumber }, _response);

            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }


        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteNumberVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.Error = true;
                    _response.statusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var numberVilla = await _numberRepo.Get(v => v.VillaNumber == id);
                if (numberVilla == null)
                {
                    _response.Error = true;
                    _response.statusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _numberRepo.Remove(numberVilla);
                _response.statusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return BadRequest(_response);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateNumberVilla(int id, [FromBody] NumberVillaUpdateDto updateNumberDto)
        {
          
                if (updateNumberDto == null || id != updateNumberDto.VillaNumber)
                {
                    _response.Error = true;
                    _response.statusCode= HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                if(await _villaRepo.Get(V=>V.Id == updateNumberDto.VillaId) == null)
                {
                    ModelState.AddModelError("ClaveForanea", "Villa not exists.");
                    return BadRequest(ModelState);
                }

                NumberVilla model = _mapper.Map<NumberVilla>(updateNumberDto);

                await _numberRepo.Update(model);
                _response.statusCode = HttpStatusCode.NoContent;
                return Ok(_response);
        }
    }
}