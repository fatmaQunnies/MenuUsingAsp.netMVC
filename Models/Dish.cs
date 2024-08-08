﻿namespace Menu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public String Price { get; set; }
        public List<DishIngredient> DishIngredients { get; set; }
}
}