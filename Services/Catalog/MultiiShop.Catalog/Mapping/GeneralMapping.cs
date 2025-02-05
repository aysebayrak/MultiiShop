using AutoMapper;
using MongoDB.Driver.Core.Misc;
using MultiiShop.Catalog.Dtos.CategoryDtos;
using MultiiShop.Catalog.Entities;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiiShop.Catalog.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping() 
        { 
            CreateMap<Category , ResultCategoryDto>().ReverseMap();
            CreateMap<Category , CreateCategoryDto>().ReverseMap(); 
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();  
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>( ).ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();

            CreateMap<Product, ResultProductsWithCategoryDto>().ReverseMap();


        } 
    }
}
