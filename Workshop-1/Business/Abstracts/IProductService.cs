using Workshop_1.Business.Dtos.Requests;
using Workshop_1.Business.Dtos.Responses;

namespace Workshop_1.Business.Abstracts
{
    public interface IProductService
    {
        void Add(CreateProductRequest product); //request
        List<GetAllProductResponse> GetProducts(); //response
    }
}
