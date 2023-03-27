using ProductsMicroService.Application.DTO.Category;

namespace ProductsMicroService.Application.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategories();
        Guid AddNewCategory(CategoryDto category);
        CategoryDto GetCategory(Guid categoryId);
    }
}
