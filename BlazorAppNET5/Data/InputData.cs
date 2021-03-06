﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppNET5.Data
{
    public enum Country
    {
        Japan,
        China,
        America,
        Brazil
    }

    public enum FoodType
    {
        Rice,
        Bread,
        Meat,
        Vegetable
    }

    public enum DrinkType
    {
        Water,
        Tea,
        Coffee
    }

    public class InputData
    {
        [Required, EnumDataType(typeof(Country))]
        public Country? SelectedCountry { get; set; } = null;

        [Required, EnumDataType(typeof(DrinkType))]
        public DrinkType? SelectedDrinkType { get; set; } = null;

        [Required, EnumDataType(typeof(FoodType))]
        public FoodType? SelectedFoodType { get; set; } = null;
    }
}
