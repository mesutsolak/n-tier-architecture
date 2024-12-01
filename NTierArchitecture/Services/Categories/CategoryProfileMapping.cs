using Services.Categories.Dto;

namespace Services.Categories;

public class CategoryProfileMapping : Profile
{
    public CategoryProfileMapping()
    {
        CreateMap<CategoryDto, Category>().ReverseMap();
        CreateMap<Category, CategoryWithProductsDto>().ReverseMap();
        CreateMap<CreateCategoryRequest, Category>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.ToLowerInvariant()));
        CreateMap<UpdateCategoryRequest, Category>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.ToLowerInvariant()));
    }
}
