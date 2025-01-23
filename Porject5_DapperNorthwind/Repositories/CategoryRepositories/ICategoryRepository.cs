using Porject5_DapperNorthwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject5_DapperNorthwind.Repositories.CategoryRepositories
{
	// interface'ler, metodların imzasını tutar
	public interface ICategoryRepository
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();
		Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
		Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
		Task DeleteCategoryAsync(int id);
		Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);
	}
}
