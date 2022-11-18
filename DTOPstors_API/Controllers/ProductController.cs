using Core.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<ProductType> productTypeRepository;
        private readonly IRepository<ProductBrand> productBrandRepository;

        public ProductController(IRepository<Product> productRepository, IRepository<ProductType> productTypeRepository,
            IRepository<ProductBrand> productBrandRepository)
        {
            this.productRepository = productRepository;
            this.productTypeRepository = productTypeRepository;
            this.productBrandRepository = productBrandRepository;
        }

        [HttpGet("GetProdct")]
        public async Task<Product> GetProdctAsync(int id)
        {
            return await productRepository.GetByIdAsync(id);
        }

        [HttpGet("GetAllProdcts")]
        public async Task<IReadOnlyList<Product>> GetAllProdctsAsync()
        {
            return await productRepository.GetAllAsync();
        }

        [HttpGet("GetProductType")]
        public async Task<ProductType> GetProductTypeAsync(int id)
        {
            return await productTypeRepository.GetByIdAsync(id);
        }

        [HttpGet("GetAllProductTypes")]
        public async Task<IReadOnlyList<ProductType>> GetAllProductTypeAsync()
        {
            return await productTypeRepository.GetAllAsync();
        }

        [HttpGet("GetProductBrand")]
        public async Task<ProductBrand> GetProductBrandAsync(int id)
        {
            return await productBrandRepository.GetByIdAsync(id);
        }

        [HttpGet("GetAllProductBrands")]
        public async Task<IReadOnlyList<ProductBrand>> GetAllProductBrandAsync()
        {
            return await productBrandRepository.GetAllAsync();
        }


    }
}
