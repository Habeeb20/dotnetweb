
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace dotnetWebApi.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
         private static List<Character> characters  = new List<Character>{
            new Character(),
            new Character {Id = 1 , Name = "sam"}
         };
        public ICharacterService _CharacterService { get;set; }

         public CharacterController(ICharacterService characterService)
         {
            _CharacterService = characterService;
            
         }




        [HttpGet("GetAll")]
        public async Task<ServiceResponse<ActionResult<List<Character>>>> Get() => Ok(await _CharacterService.GetAllCharacters());

        [HttpGet("{Id}")]
        public async Task<ServiceResponse<ActionResult<Character>>> GetSingle(int id)
        {
            return Ok(await _CharacterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ServiceResponse<ActionResult<List<Character>>>> AddCharacter(Character newCharacter)
        {
            
            return Ok(await _CharacterService.AddCharacter(new Character()));
        }
        

    }
   
}