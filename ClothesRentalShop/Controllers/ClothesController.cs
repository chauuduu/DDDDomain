using Application.Service.ClothService;
using Domain.Cloth;
using Microsoft.AspNetCore.Mvc;

namespace ClothesRentalShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesController : ControllerBase
    {
        readonly IClothesService ClothesService;
        public ClothesController(IClothesService ClothesService)
        {
            this.ClothesService = ClothesService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ClothesService.GetList());
        }
        [HttpGet("Name")]
        public IActionResult GetLike(String Name)
        {
            return Ok(ClothesService.GetListLike(Name));
        }
        [HttpGet("Id")]
        public IActionResult GetById(int Id)
        {
            return Ok(ClothesService.GetById(Id));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Clothes ClothesEx)
        {
            return Ok(ClothesService.Add(ClothesEx));
        }
        [HttpPut]
        public async Task<IActionResult> Update(int Id,Clothes ClothesEx)
        {
            return Ok(ClothesService.Update(Id,ClothesEx));
        }
        [HttpDelete("ID")]
        public IActionResult Delete(int ID)
        {
            return Ok(ClothesService.Delete(ID));
        }
    }
}

