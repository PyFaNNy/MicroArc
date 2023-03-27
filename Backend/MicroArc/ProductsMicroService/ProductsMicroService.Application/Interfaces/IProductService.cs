using ProductsMicroService.Application.DTO.Product;

namespace ProductsMicroService.Application.Interfaces
{
    public interface IProductService
    {
        List<ProductDto> GetProductList();
        ProductDto GetProduct(Guid Id);
        Guid AddNewProduct(AddNewProductDto addNewProduct);
        bool UpdateProductName(UpdateProductDto updateProduct);
    }
}
