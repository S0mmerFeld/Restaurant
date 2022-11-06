﻿using Data.Entities;

namespace Restaurant.Models
{
    public class IngredientViewModel
    {
        public SortType SelectSortType { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public IEnumerable<IngredientGroup> Categories { get; set; }

        public int Page { get; set; } = 0;
        public int MaxPage { get; set; }
        public string Category { get; set; } = "Meat";
        public int PageSize { get; } = 6;

    }

    public enum IngredientSort
    {
        ByName, ByAmount
    }
}
