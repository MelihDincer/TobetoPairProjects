using System.Collections.Generic;
using TobetoPairProjects.Entities;
using Workshop_1.Business.Abstracts;
using Workshop_1.Business.Dtos.Requests;
using Workshop_1.Business.Dtos.Responses;
using Workshop_1.DataAccess.Abstracts;

namespace TobetoPairProjects.Business.Concretes;
public class ProductManager : IProductService
{
    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Add(CreateProductRequest product)
    {
        //business rules

        Product productToCreate = new Product();
        productToCreate.Description = product.Description;
        productToCreate.UnitPrice = product.UnitPrice;
        productToCreate.Name = product.Name;
        productToCreate.CategoryId = product.CategoryId;
        productToCreate.DiscountRate = product.DiscountRate;

        _productDal.Add(productToCreate);
    }

    public List<GetAllProductResponse> GetProducts()
    {
        //business rules

        List<GetAllProductResponse> products = new List<GetAllProductResponse>();
        foreach(var item in _productDal.GetProducts())
        {
            GetAllProductResponse getAllProductResponse = new GetAllProductResponse();
            getAllProductResponse.UnitPrice = item.UnitPrice;
            getAllProductResponse.Description = item.Description;
            getAllProductResponse.Name = item.Name;
            getAllProductResponse.Id = item.Id;
            getAllProductResponse.DiscountRate = item.DiscountRate;
            getAllProductResponse.CategoryId = item.CategoryId;

            products.Add(getAllProductResponse);
        }
        return products;
    }
}

