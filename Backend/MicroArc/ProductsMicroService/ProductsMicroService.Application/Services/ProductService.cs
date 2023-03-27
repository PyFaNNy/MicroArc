using Microsoft.EntityFrameworkCore;
using ProductsMicroService.Application.DTO.Product;
using ProductsMicroService.Application.Exceptions;
using ProductsMicroService.Application.Interfaces;
using ProductsMicroService.Domain;

namespace ProductsMicroService.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDbContext _dbContext;

        public ProductService(IProductDbContext context)
        {
            _dbContext = context;
        }

        public bool UpdateProductName(UpdateProductDto updateProduct)
        {
            var product = _dbContext.Products.Find(updateProduct.ProductId);
            if (product is not null)
            {
                product.Name = updateProduct.Name;
                _dbContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public Guid AddNewProduct(AddNewProductDto addNewProduct)
        {
            var category = _dbContext.Categories.Find(addNewProduct.CategoryId);
            if (category == null)
            {
                throw new NotFoundException(nameof(Category), addNewProduct.CategoryId);
            }
                
            Product product = new Product()
            {
                Category = category,
                Description = addNewProduct.Description,
                Image = addNewProduct.Image,
                Name = addNewProduct.Name,
                Price = addNewProduct.Price
            };
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

            return product.Id;
        }

        public ProductDto GetProduct(Guid Id)
        {
            var product = _dbContext.Products.Include(p => p.Category)
               .SingleOrDefault(p => p.Id == Id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), Id);
            }
                
            ProductDto data = new ProductDto()
            {
                Description = product.Description,
                Id = product.Id,
                Image = product.Image,
                Name = product.Name,
                Price = product.Price,
                productCategory = new ProductCategoryDto
                {
                    Category = product.Category.Name,
                    CategoryId = product.Category.Id
                }
            };
            return data;
        }

        public List<ProductDto> GetProductList()
        {
            var data = _dbContext.Products
                 .Include(p => p.Category)
                 .OrderByDescending(p => p.Id)
                 .Select(p => new ProductDto
                 {
                     Description = p.Description,
                     Id = p.Id,
                     Image = p.Image,
                     Name = p.Name,
                     Price = p.Price,
                     productCategory = new ProductCategoryDto
                     {
                         Category = p.Category.Name,
                         CategoryId = p.Category.Id
                     }
                 }).ToList();
            return data;
        }
    }
}
