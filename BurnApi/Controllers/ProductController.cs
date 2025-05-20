using AutoMapper;
using Burn.BusinessLayer.Abstract;
using Burn.DataAccessLayer.Concrete;
using Burn.DtoLayer.DiscountDto;
using Burn.DtoLayer.FeatureDto;
using Burn.DtoLayer.ProductDto;
using Burn.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BurnApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetAll());
            return Ok(value);
        }
        [HttpGet("ProductCount")]
		public IActionResult ProductCount()
		{
			return Ok(_productService.TProductCount());
		}
		[HttpGet("ProductCountByHamburger")]
		public IActionResult ProductCountByHamburger()
		{
			return Ok(_productService.TProductCountByCategoryNameHamburger());
		}
		[HttpGet("ProductCountByDrink")]
		public IActionResult ProductCountByDrink()
		{
			return Ok(_productService.TProductCountByCategoryNameDrink());
		}
		[HttpGet("ProductPriceAvg")]
		public IActionResult ProductPriceAvg()
		{
			return Ok(_productService.TProductPriceAvg());
		}
		[HttpGet("ProductNameByMaxPrice")]
		public IActionResult ProductNameByMaxPrice()
		{
			return Ok(_productService.TProductNameByMaxPrice());
		}
		[HttpGet("ProductNameByMinPrice")]
		public IActionResult ProductNameByMinPrice()
		{
			return Ok(_productService.TProductNameByMinPrice());
		}
		[HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory() 
        {
            var context = new BurnContext();
            var value = context.Products.Include(x => x.Category).Select(y=> new ResultProductWithCategory
            {
                Description=y.Description,
                ImageUrl=y.ImageUrl,
                Price=y.Price,
                ProductID=y.ProductID,
                ProductName=y.ProductName,
                ProductStatus=y.ProductStatus,
                CategoryName=y.Category.CategoryName
            });
            return Ok(value.ToList());
        }


        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                CategoryID =createProductDto.CategoryID,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                ProductStatus  = createProductDto.ProductStatus,
            });
            return Ok("Ürün Bilgisi eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün Bilgisi silindi");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                ProductStatus = updateProductDto.ProductStatus,
                ProductName = updateProductDto.ProductName,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductID = updateProductDto.ProductID,
            });
            return Ok("Ürün Bilgisi güncellendi");
        }
    }
}
