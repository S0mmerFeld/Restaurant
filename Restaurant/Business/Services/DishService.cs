﻿using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Business.Validation;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class DishService : IDishService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DishService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<DishModel>> GetByFilterAsync(FilterSearchModel filterSearch)
        {

            var dishes = await _unitOfWork.DishRepository.GetAllWithDetailsAsync();
            var filtred = dishes
                .Where(p => p.Price >= (filterSearch.MinPrice ?? decimal.MinValue) && p.Price <= (filterSearch.MaxPrice ?? decimal.MaxValue));
            if (filterSearch.DishGroup != null)
            {
                filtred = filtred.Where(p => p.DishGroup == filterSearch.DishGroup);
            }

            List<DishModel> pml = new List<DishModel>();
            foreach (Dish p in filtred)
            {
                pml.Add(_mapper.Map<Dish, DishModel>(p));
            }
            return pml;

        }


        public async Task AddAsync(DishModel model)
        {
            if (model == null)
            {
                throw new RestaurantException("Model is null");
            }
            if (model.Price < 0)
            {
                throw new RestaurantException("Price is negative");
            }
            if (String.IsNullOrEmpty(model.Name))
            {
                throw new RestaurantException("Name is empty");
            }

            await _unitOfWork.DishRepository.AddAsync(_mapper.Map<Dish>(model));
            await _unitOfWork.SaveAsync();
        }


        public async Task DeleteAsync(int modelId)
        {
            await _unitOfWork.DishRepository.DeleteByIdAsync(modelId);

            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<DishModel>> GetAllAsync()
        {
            var dishes = await _unitOfWork.DishRepository.GetAllWithDetailsAsync();

            return _mapper.Map<IEnumerable<DishModel>>(dishes);
        }


        public async Task<IEnumerable<DishGroup>> GetDishCategoriesAsync()
        {
            var dishes = await _unitOfWork.DishRepository.GetAllWithDetailsAsync();
            var dishescategories = dishes.Select(c => c.DishGroup).Distinct();

            return dishescategories;
        }


        public IEnumerable<DishModel> Sort(IEnumerable<DishModel> dm, string Category, SortType st)
        {
            IEnumerable<DishModel> category_list;

            if (st == SortType.ByName)
            {
                category_list = dm.Where(c => c.DishGroup.ToString() == Category).OrderBy(d => d.Name.ToLower());
            }
            else
            {
                category_list = dm.Where(c => c.DishGroup.ToString() == Category).OrderByDescending(d => d.Price);
            }

            return category_list;
        }




        public async Task<DishModel> GetByIdAsync(int id)
        {
            var dish = await _unitOfWork.DishRepository.GetByIdAsync(id);
            return _mapper.Map<DishModel>(dish);
        }

        public async Task UpdateAsync(DishModel model)
        {
            if (model == null)
            {
                throw new RestaurantException("Model is null");
            }
            if (String.IsNullOrEmpty(model.Name))
            {
                throw new RestaurantException("Name is empty");
            }

            var dish = _mapper.Map<Dish>(model);

            _unitOfWork.DishRepository.Update(dish);

            await _unitOfWork.SaveAsync();
        }
    }
}
