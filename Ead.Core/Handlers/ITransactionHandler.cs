using Ead.Core.Responses;

namespace Ead.Core;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Transaction?>> UpdateAsync(CreateCategoryRequest request);
    Task<Response<Transaction?>> DeleteAsync(CreateCategoryRequest request);
    Task<Response<Transaction?>> GetByIdAsync(CreateCategoryRequest request);
    Task<PagedResponse<List<Transaction>?>> GetAllAsync(CreateCategoryRequest request);

}
