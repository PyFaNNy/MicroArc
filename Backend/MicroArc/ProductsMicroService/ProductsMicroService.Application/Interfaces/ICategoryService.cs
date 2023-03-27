using ProductsMicroService.Application.DTO.Category;

namespace ProductsMicroService.Application.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategories();
        Guid AddNewCatrgory(CategoryDto category);
        CategoryDto Getcategory(Guid categoryId);
    }
}
