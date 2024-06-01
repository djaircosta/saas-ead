using Ead.Core.Responses;

namespace Ead.Core;

public interface ICategoryHandler
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync(CreateCategoryRequest request);
    Task<Response<Category?>> GetByIdAsync(CreateCategoryRequest request);
    Task<PagedResponse<List<Category>?>> GetAllAsync(CreateCategoryRequest request);
    
}