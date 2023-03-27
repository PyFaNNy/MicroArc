using ProductsMicroService.Application.DTO.Category;
using ProductsMicroService.Application.Exceptions;
using ProductsMicroService.Application.Interfaces;
using ProductsMicroService.Domain;

namespace ProductsMicroService.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IProductDbContext _dbContext;

        public CategoryService(IProductDbContext context)
        {
            _dbContext = context;
        }
        public CategoryDto Getcategory(Guid categoryId)
        {
            var category = _dbContext.Categories.Find(categoryId);

            if(category == null)
            {
                throw new NotFoundException(nameof(Category), categoryId);
            }

            return new CategoryDto
            {
                Description = category.Description,
                Id = category.Id,
                Name = category.Name,
            };
        }
        public Guid AddNewCatrgory(CategoryDto category)
        {
            Category newCategory = new Category
            {
                Description = category.Description,
                Name = category.Name,
            };
            _dbContext.Categories.Add(newCategory);
            _dbContext.SaveChanges();
            return newCategory.Id;
        }
        public List<CategoryDto> GetCategories()
        {
            var data = _dbContext.Categories
               .OrderBy(p => p.Name)
               .Select(p => new CategoryDto
               {
                   Description = p.Description,
                   Name = p.Name,
                   Id = p.Id
               }).ToList();
            return data;
        }
    }
}
