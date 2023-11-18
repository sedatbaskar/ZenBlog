using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Data.Abstract;
using ZenBlog.Data.Concrete;
using ZenBlog.Entities.Concrete;
using ZenBlog.Entities.Dtos;
using ZenBlog.Services.Abstract;
using ZenBlog.Shared.Utilities.Result.Abstract;
using ZenBlog.Shared.Utilities.Result.ComplexTypes;
using ZenBlog.Shared.Utilities.Result.Concrete;

namespace ZenBlog.Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {

            await _unitOfWork.Categorys.AddASync(new Category
            {

                Name = categoryAddDto.Name,
                Description = categoryAddDto.Description,
                Note = categoryAddDto.Note,
                IsActive = categoryAddDto.IsActive,
                CreatedByName = createdByName,
                CreatedDate = DateTime.Now,
                ModifiedByName = createdByName,
                ModifiedDate = DateTime.Now,
                IsDeleted = false

            }).ContinueWith(t => _unitOfWork.SaveAsync());


            //await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} adlı kategori başarıyla eklendi");

        }

        public async Task<IResult> Delete(int categoryid, string modifiedByName)
        {
            var category = await _unitOfWork.Categorys.GetAsync(c => c.Id == categoryid);

            if (category != null)
            {
                category.IsDeleted = true;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                await _unitOfWork.Categorys.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());

                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarıyla silinmiştir.");
            }
            return new DataResult<Category>(ResultStatus.Error, "Böyle bir kategori bulunamadı", null);
        }

        public async Task<IDataResult<Category>> Get(int categoryid)
        {
            var category = await _unitOfWork.Categorys.GetAsync(c => c.Id == categoryid, c => c.Articles);

            if (category != null)
            {
                return new DataResult<Category>(ResultStatus.Success, category);
            }

            return new DataResult<Category>(ResultStatus.Error, "Böyle bir kategori bulunamadı", null);
        }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories = await _unitOfWork.Categorys.GetAllAsync(null, c => c.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Herhangi bir kategori bulunmadı", null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNoneDeleted()
        {
            var categories = await _unitOfWork.Categorys.GetAllAsync(c => !c.IsDeleted, c => c.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Herhangi bir kategori bulunmadı", null);

        }

        public async Task<IResult> HardDelete(int categoryid)
        {
            var category = await _unitOfWork.Categorys.GetAsync(c => c.Id == categoryid);

            if (category != null)
            {

                await _unitOfWork.Categorys.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());

                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori veri tabanından başarıyla silinmiştir.");
            }
            return new DataResult<Category>(ResultStatus.Error, "Böyle bir kategori bulunamadı", null);
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var category = await _unitOfWork.Categorys.GetAsync(c => c.Id == categoryUpdateDto.Id);
            if (category != null)
            {
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Note = categoryUpdateDto.Note;
                category.IsActive = categoryUpdateDto.IsActive;
                category.IsDeleted = category.IsDeleted;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;

                await _unitOfWork.Categorys.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategori başarıyla Güncellendi");

            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı", null);

        }
    }
}
