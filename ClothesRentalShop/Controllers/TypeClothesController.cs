using Application.Service;
using Application.Service.TypeClothService;
using Domain.Cloth;
using Microsoft.AspNetCore.Mvc;

namespace ClothesRentalShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeClothesController : ControllerBase
    {
        readonly ITypeClothesService TypeClothesService;
        public TypeClothesController(ITypeClothesService TypeClothesService)
        {
            this.TypeClothesService = TypeClothesService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(TypeClothesService.GetList());
        }
        [HttpGet("Id")]
        public IActionResult GetById(int Id)
        {
            return Ok(TypeClothesService.GetById(Id));
        }
        [HttpPost]
        public async Task<IActionResult> Insert(TypeClothes TypeClothesEx)
        {
            return Ok(TypeClothesService.Add(TypeClothesEx));
        }
        [HttpPut]
        public async Task<IActionResult> Update(int Id,TypeClothes TypeClothesEx)
        {
            return Ok(TypeClothesService.Update(Id,TypeClothesEx));
        }
        [HttpDelete("ID")]
        public IActionResult Delete(int ID)
        {
            return Ok(TypeClothesService.Delete(ID));
        }
    }
}


