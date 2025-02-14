﻿using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class RestaurantDbContext : DbContext, IRestaurantDbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<DishComposition> DishCompositions { get; set; }
        public DbSet<DishOrder> DishOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<Customer> RestaurantUsers { get; set; }
        public DbSet<TableOrder> TableOrders { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
               new Ingredient { Id = 1, Name = "Water", Amount = 23, ExpirationDate = new DateTime(2021, 1, 30), ImportDate = new DateTime(2022, 12, 12), Price = 5, IngredientGroup = IngredientGroup.Drinks },
               new Ingredient { Id = 2, Name = "Pork", Amount = 7, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 3, Name = "Pork", Amount = 4, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 4, Name = "Pork", Amount = 4, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 5, Name = "Pork", Amount = 30, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 6, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 7, Name = "Pork", Amount = 3, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 8, Name = "Pork", Amount = 1, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 9, Name = "Pork", Amount = 4, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 10, Name = "Pork", Amount = 13, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 11, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 12, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 13, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 14, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 15, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 16, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 17, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 18, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 19, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 20, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 21, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 22, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 23, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 24, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 25, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 26, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 27, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 28, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 29, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 30, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 31, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 32, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 33, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 34, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 35, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 36, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 37, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 38, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 39, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 40, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 41, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 42, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 43, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 44, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 45, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 46, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 47, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 48, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 49, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 50, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 51, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 52, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 53, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 54, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 55, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 56, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 57, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 58, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },               
               new Ingredient { Id = 59, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 60, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 61, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 62, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 63, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 64, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 65, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 66, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 67, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 68, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 69, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 70, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 71, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat },
               new Ingredient { Id = 72, Name = "Pork", Amount = 10, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat }
               );          



            

            modelBuilder.Entity<Dish>().HasData(
               new Dish
               {
                   Id = 1,
                   Name = "NEGRONI",
                   ImgPath = "/img/menu/NEGRONI.jpg",
                   Price = 1,
                   Description = "The Botanist gin, Campari, Vermouth Di Torino",
                   DishGroup = DishGroup.Alcohol                   
               },

               new Dish
               {
                   Id = 2,
                   Description = "Tanqueray London Dry gin, Noilly Prat dry vermouth",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/martini.jpg",
                   
                   Name = "MARTINI",
                   Price = 2
               },

               new Dish
               {
                   Id = 3,
                   Description = "Sazerac Rye whiskey, Cocchi Vermouth Di Torino",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/manhattan.jpg",
                   
                   Name = "MANHATTAN",
                   Price = 3
               },

               new Dish
               {
                   Id = 4,
                   Description = "Four Roses Yellow Label bourbon, lemon",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/whiskey_sour.jpg",
                   
                   Name = "WHISKEY SOUR",
                   Price = 4
               },

               new Dish
               {
                   Id = 5,
                   Description = "Buffalo Trace bourbon, demerara, Angostura Bitters",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/OLD_FASHIONED.jpg",
                   
                   Name = "OLD FASHIONED",
                   Price = 5
               },

               new Dish
               {
                   Id = 6,
                   Description = "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/BLOODY_MARY.jpg",
                   
                   Name = "BLOODY MARY",
                   Price = 6
               },

               new Dish
               {
                   Id = 7,
                   Description = "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Roasted_stuffed_mushrooms.jpg",
                   
                   Name = "Roasted stuffed mushrooms",
                   Price = 19.99m
               },

               new Dish
               {
                   Id = 8,
                   Description = "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                   
                   Name = "Baked spring rolls",
                   Price = 18.50m
               },

               new Dish
               {
                   Id = 9,
                   Description = "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                   
                   Name = "Baked spring rolls",
                   Price = 7.05m
               },

               new Dish
               {
                   Id = 10,
                   Description = "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Sweet_fried_saganaki.jpg",
                   
                   Name = "Sweet fried saganaki",
                   Price = 29.95m
               },

               new Dish
               {
                   Id = 11,
                   Description = "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Bacon_rings.jpg",
                   
                   Name = "Bacon rings",
                   Price = 38.51m
               },

               new Dish
               {
                   Id = 12,
                   Description = "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Blooming_onion.jpg",
                   
                   Name = "Blooming onion",
                   Price = 10.30m
               },

               new Dish
               {
                   Id = 13,
                   Description = "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/CALZONES.jpg",
                   
                   Name = "CALZONES",
                   Price = 27.95m
               },

               new Dish
               {
                   Id = 14,
                   Description = "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg",
                   
                   Name = "Deep Fried Main Dishes",
                   Price = 35.95m
               },

               new Dish
               {
                   Id = 15,
                   Description = "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/MEATBALLS.jpg",
                   
                   Name = "MEATBALLS",
                   Price = 33.95m
               },

               new Dish
               {
                   Id = 16,
                   Description = "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/QUICHE.jpg",
                   
                   Name = "QUICHE",
                   Price = 11.95m
               },

               new Dish
               {
                   Id = 17,
                   Description = "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/CHICKEN_MAIN_DISHES.jpg",
                   
                   Name = "CHICKEN MAIN DISHES",
                   Price = 22.95m
               },

               new Dish
               {
                   Id = 18,
                   Description = "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/SEAFOOD_MAIN_DISHES.jpg",
                   
                   Name = "SEAFOOD MAIN DISHES",
                   Price = 11.95m
               },

               new Dish
               {
                   Id = 19,
                   Description = "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/TIRAMISU_LAYER_CAKE.jpg",
                   
                   Name = "TIRAMISU LAYER CAKE",
                   Price = 18.95m
               },

               new Dish
               {
                   Id = 20,
                   Description = "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/DEVIL'S_FOOD_CAKE.jpg",
                   
                   Name = "DEVIL'S FOOD CAKE",
                   Price = 15.95m
               },

               new Dish
               {
                   Id = 21,
                   Description = "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/LEMON_SOUFFLES.jpg ",
                   
                   Name = "LEMON SOUFFLES",
                   Price = 22.95m
               },

               new Dish
               {
                   Id = 22,
                   Description = "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/BAKLAVA.jpg",
                   
                   Name = "BAKLAVA",
                   Price = 11.95m
               },

               new Dish
               {
                   Id = 23,
                   Description = "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/LEMON_CAKE_DOBERGE.jpg ",
                   
                   Name = "LEMON CAKE DOBERGE",
                   Price = 33.95m
               },

               new Dish
               {
                   Id = 24,
                   Description = "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/CHOCOLATE_FONDUE.jpg ",
                   
                   Name = "CHOCOLATE FONDUE",
                   Price = 44.95m
               },
               new Dish
               {
                   Id = 25,
                   Description = "The Botanist gin, Campari, Vermouth Di Torino",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/NEGRONI.jpg",
                   
                   Name = "NEGRONI",
                   Price = 25

               },

               new Dish
               {
                   Id = 26,
                   Description = "Tanqueray London Dry gin, Noilly Prat dry vermouth",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/martini.jpg",
                   
                   Name = "MARTINI",
                   Price = 26
               },

               new Dish
               {
                   Id = 27,
                   Description = "Sazerac Rye whiskey, Cocchi Vermouth Di Torino",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/manhattan.jpg",
                   
                   Name = "MANHATTAN",
                   Price = 27
               },

               new Dish
               {
                   Id = 28,
                   Description = "Four Roses Yellow Label bourbon, lemon",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/whiskey_sour.jpg",
                   
                   Name = "WHISKEY SOUR",
                   Price = 28
               },

               new Dish
               {
                   Id = 29,
                   Description = "Buffalo Trace bourbon, demerara, Angostura Bitters",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/OLD_FASHIONED.jpg",
                   
                   Name = "OLD FASHIONED",
                   Price = 29
               },

               new Dish
               {
                   Id = 30,
                   Description = "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/BLOODY_MARY.jpg",
                   
                   Name = "BLOODY MARY",
                   Price = 30
               },

               new Dish
               {
                   Id = 31,
                   Description = "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Roasted_stuffed_mushrooms.jpg",
                   
                   Name = "Roasted stuffed mushrooms",
                   Price = 31
               },

               new Dish
               {
                   Id = 32,
                   Description = "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                   
                   Name = "Baked spring rolls",
                   Price = 32
               },

               new Dish
               {
                   Id = 33,
                   Description = "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                   
                   Name = "Baked spring rolls",
                   Price = 33
               },

               new Dish
               {
                   Id = 34,
                   Description = "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Sweet_fried_saganaki.jpg",
                   
                   Name = "Sweet fried saganaki",
                   Price = 34
               },

               new Dish
               {
                   Id = 35,
                   Description = "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Bacon_rings.jpg",
                   
                   Name = "Bacon rings",
                   Price = 35
               },

               new Dish
               {
                   Id = 36,
                   Description = "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Blooming_onion.jpg",
                   
                   Name = "Blooming onion",
                   Price = 36
               },

               new Dish
               {
                   Id = 37,
                   Description = "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/CALZONES.jpg",
                   
                   Name = "CALZONES",
                   Price = 37
               },

               new Dish
               {
                   Id = 38,
                   Description = "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg",
                   
                   Name = "Deep Fried Main Dishes",
                   Price = 38
               },

               new Dish
               {
                   Id = 39,
                   Description = "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/MEATBALLS.jpg",
                   
                   Name = "MEATBALLS",
                   Price = 39
               },

               new Dish
               {
                   Id = 40,
                   Description = "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/QUICHE.jpg",
                   
                   Name = "QUICHE",
                   Price = 40
               },

               new Dish
               {
                   Id = 41,
                   Description = "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/CHICKEN_MAIN_DISHES.jpg",
                   
                   Name = "CHICKEN MAIN DISHES",
                   Price = 41
               },

               new Dish
               {
                   Id = 42,
                   Description = "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/SEAFOOD_MAIN_DISHES.jpg",
                   
                   Name = "SEAFOOD MAIN DISHES",
                   Price = 42
               },

               new Dish
               {
                   Id = 43,
                   Description = "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/TIRAMISU_LAYER_CAKE.jpg",
                   
                   Name = "TIRAMISU LAYER CAKE",
                   Price = 43
               },

               new Dish
               {
                   Id = 44,
                   Description = "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/DEVIL'S_FOOD_CAKE.jpg",
                   
                   Name = "DEVIL'S FOOD CAKE",
                   Price = 44
               },

               new Dish
               {
                   Id = 45,
                   Description = "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/LEMON_SOUFFLES.jpg ",
                   
                   Name = "LEMON SOUFFLES",
                   Price = 45
               },

               new Dish
               {
                   Id = 46,
                   Description = "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/BAKLAVA.jpg",
                   
                   Name = "BAKLAVA",
                   Price = 46
               },

               new Dish
               {
                   Id = 47,
                   Description = "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/LEMON_CAKE_DOBERGE.jpg ",
                   
                   Name = "LEMON CAKE DOBERGE",
                   Price = 47
               },

               new Dish
               {
                   Id = 48,
                   Description = "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/CHOCOLATE_FONDUE.jpg ",
                   
                   Name = "CHOCOLATE FONDUE",
                   Price = 48
               },
               new Dish
               {
                   Id = 49,
                   Description = "The Botanist gin, Campari, Vermouth Di Torino",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/NEGRONI.jpg",
                   
                   Name = "NEGRONI",
                   Price = 49

               },

               new Dish
               {
                   Id = 50,
                   Description = "Tanqueray London Dry gin, Noilly Prat dry vermouth",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/martini.jpg",
                   
                   Name = "MARTINI",
                   Price = 50
               },

               new Dish
               {
                   Id = 51,
                   Description = "Sazerac Rye whiskey, Cocchi Vermouth Di Torino",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/manhattan.jpg",
                   
                   Name = "MANHATTAN",
                   Price = 51
               },

               new Dish
               {
                   Id = 52,
                   Description = "Four Roses Yellow Label bourbon, lemon",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/whiskey_sour.jpg",
                   
                   Name = "WHISKEY SOUR",
                   Price = 52
               },

               new Dish
               {
                   Id = 53,
                   Description = "Buffalo Trace bourbon, demerara, Angostura Bitters",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/OLD_FASHIONED.jpg",
                   
                   Name = "OLD FASHIONED",
                   Price = 53
               },

               new Dish
               {
                   Id = 54,
                   Description = "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.",
                   DishGroup = DishGroup.Alcohol,
                   ImgPath = "/img/menu/BLOODY_MARY.jpg",
                   
                   Name = "BLOODY MARY",
                   Price = 54
               },

               new Dish
               {
                   Id = 55,
                   Description = "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Roasted_stuffed_mushrooms.jpg",
                   
                   Name = "Roasted stuffed mushrooms",
                   Price = 55
               },

               new Dish
               {
                   Id = 56,
                   Description = "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                   
                   Name = "Baked spring rolls",
                   Price = 56
               },

               new Dish
               {
                   Id = 57,
                   Description = "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                   
                   Name = "Baked spring rolls",
                   Price = 57
               },

               new Dish
               {
                   Id = 58,
                   Description = "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Sweet_fried_saganaki.jpg",
                   
                   Name = "Sweet fried saganaki",
                   Price = 58
               },

               new Dish
               {
                   Id = 59,
                   Description = "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Bacon_rings.jpg",
                   
                   Name = "Bacon rings",
                   Price = 59
               },

               new Dish
               {
                   Id = 60,
                   Description = "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion",
                   DishGroup = DishGroup.Starters,
                   ImgPath = "/img/menu/Blooming_onion.jpg",
                   
                   Name = "Blooming onion",
                   Price = 60
               },

               new Dish
               {
                   Id = 61,
                   Description = "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/CALZONES.jpg",
                   
                   Name = "CALZONES",
                   Price = 61
               },

               new Dish
               {
                   Id = 62,
                   Description = "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg",
                   
                   Name = "Deep Fried Main Dishes",
                   Price = 62
               },

               new Dish
               {
                   Id = 63,
                   Description = "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/MEATBALLS.jpg",
                   
                   Name = "MEATBALLS",
                   Price = 63
               },

               new Dish
               {
                   Id = 64,
                   Description = "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/QUICHE.jpg",
                   
                   Name = "QUICHE",
                   Price = 64
               },

               new Dish
               {
                   Id = 65,
                   Description = "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/CHICKEN_MAIN_DISHES.jpg",
                   
                   Name = "CHICKEN MAIN DISHES",
                   Price = 65
               },

               new Dish
               {
                   Id = 66,
                   Description = "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.",
                   DishGroup = DishGroup.MainPlates,
                   ImgPath = "/img/menu/SEAFOOD_MAIN_DISHES.jpg",
                   
                   Name = "SEAFOOD MAIN DISHES",
                   Price = 66
               },

               new Dish
               {
                   Id = 67,
                   Description = "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/TIRAMISU_LAYER_CAKE.jpg",
                   
                   Name = "TIRAMISU LAYER CAKE",
                   Price = 67
               },

               new Dish
               {
                   Id = 68,
                   Description = "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/DEVIL'S_FOOD_CAKE.jpg",
                   
                   Name = "DEVIL'S FOOD CAKE",
                   Price = 68
               },

               new Dish
               {
                   Id = 69,
                   Description = "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/LEMON_SOUFFLES.jpg ",
                   
                   Name = "LEMON SOUFFLES",
                   Price = 69
               },

               new Dish
               {
                   Id = 70,
                   Description = "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/BAKLAVA.jpg",
                   
                   Name = "BAKLAVA",
                   Price = 70
               },

               new Dish
               {
                   Id = 71,
                   Description = "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/LEMON_CAKE_DOBERGE.jpg ",
                   
                   Name = "LEMON CAKE DOBERGE",
                   Price = 71
               },

               new Dish
               {
                   Id = 72,
                   Description = "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ",
                   DishGroup = DishGroup.Desert,
                   ImgPath = "/img/menu/CHOCOLATE_FONDUE.jpg ",
                   
                   Name = "CHOCOLATE FONDUE",
                   Price = 72
               }
       );

            modelBuilder.Entity<DishComposition>().HasData(
                    new DishComposition
                    {
                        Id = 1, 
                        DishId = 1, 
                        IngredientId = 1
                    },
                    new DishComposition
                    {
                        Id = 2,
                        DishId = 1,
                        IngredientId = 2
                    },
                    new DishComposition
                    {
                        Id = 3,
                        DishId = 3,
                        IngredientId = 3
                    },
                    new DishComposition
                    {
                        Id = 4,
                        DishId = 4,
                        IngredientId = 4
                    },
                    new DishComposition
                    {
                        Id = 5,
                        DishId = 5,
                        IngredientId = 5
                    },
                    new DishComposition
                    {
                        Id = 6,
                        DishId = 6,
                        IngredientId = 6
                    },
                    new DishComposition
                    {
                        Id = 7,
                        DishId = 7,
                        IngredientId = 7
                    },
                    new DishComposition
                    {
                        Id = 8,
                        DishId = 8,
                        IngredientId = 8
                    },
                    new DishComposition
                    {
                        Id = 9,
                        DishId = 9,
                        IngredientId = 9
                    },
                    new DishComposition
                    {
                        Id = 10,
                        DishId = 10,
                        IngredientId = 10
                    },
                    new DishComposition
                    {
                        Id = 11,
                        DishId = 11,
                        IngredientId = 11
                    },
                    new DishComposition
                    {
                        Id = 12,
                        DishId = 12,
                        IngredientId = 12
                    },
                    new DishComposition
                    {
                        Id = 13,
                        DishId = 13,
                        IngredientId = 13
                    },
                    new DishComposition
                    {
                        Id = 14,
                        DishId = 14,
                        IngredientId = 14
                    },
                    new DishComposition
                    {
                        Id = 15,
                        DishId = 15,
                        IngredientId = 15
                    },
                    new DishComposition
                    {
                        Id = 16,
                        DishId = 16,
                        IngredientId = 16
                    },
                    new DishComposition
                    {
                        Id = 17,
                        DishId = 17,
                        IngredientId = 17
                    },
                    new DishComposition
                    {
                        Id = 18,
                        DishId = 18,
                        IngredientId = 18
                    },
                    new DishComposition
                    {
                        Id = 19,
                        DishId = 19,
                        IngredientId = 19
                    },
                    new DishComposition
                    {
                        Id = 20,
                        DishId = 20,
                        IngredientId = 20
                    },
                    new DishComposition
                    {
                        Id = 21,
                        DishId = 21,
                        IngredientId = 21
                    },
                    new DishComposition
                    {
                        Id = 22,
                        DishId = 22,
                        IngredientId = 22
                    },
                    new DishComposition
                    {
                        Id = 23,
                        DishId = 23,
                        IngredientId = 23
                    },
                    new DishComposition
                    {
                        Id = 24,
                        DishId = 24,
                        IngredientId = 24
                    },
                    new DishComposition
                    {
                        Id = 25,
                        DishId = 25,
                        IngredientId = 25
                    },
                    new DishComposition
                    {
                        Id = 26,
                        DishId = 26,
                        IngredientId = 26
                    },
                    new DishComposition
                    {
                        Id = 27,
                        DishId = 27,
                        IngredientId = 27
                    },
                    new DishComposition
                    {
                        Id = 28,
                        DishId = 28,
                        IngredientId = 28
                    },
                    new DishComposition
                    {
                        Id = 29,
                        DishId = 29,
                        IngredientId = 29
                    },
                    new DishComposition
                    {
                        Id = 30,
                        DishId = 30,
                        IngredientId = 30
                    },
                    new DishComposition
                    {
                        Id = 31,
                        DishId = 31,
                        IngredientId = 31
                    },
                    new DishComposition
                    {
                        Id = 32,
                        DishId = 32,
                        IngredientId = 32
                    },
                    new DishComposition
                    {
                        Id = 33,
                        DishId = 33,
                        IngredientId = 33
                    },
                    new DishComposition
                    {
                        Id = 34,
                        DishId = 34,
                        IngredientId = 34
                    },
                    new DishComposition
                    {
                        Id = 35,
                        DishId = 35,
                        IngredientId = 35
                    },
                    new DishComposition
                    {
                        Id = 36,
                        DishId = 36,
                        IngredientId = 36
                    },
                    new DishComposition
                    {
                        Id = 37,
                        DishId = 37,
                        IngredientId = 37
                    },
                    new DishComposition
                    {
                        Id = 38,
                        DishId = 38,
                        IngredientId = 38
                    },
                    new DishComposition
                    {
                        Id = 39,
                        DishId = 39,
                        IngredientId = 39
                    },
                    new DishComposition
                    {
                        Id = 40,
                        DishId = 40,
                        IngredientId = 40
                    },
                    new DishComposition
                    {
                        Id = 41,
                        DishId = 41,
                        IngredientId = 41
                    },
                    new DishComposition
                    {
                        Id = 42,
                        DishId = 42,
                        IngredientId = 42
                    },
                    new DishComposition
                    {
                        Id = 43,
                        DishId = 43,
                        IngredientId = 43
                    },
                    new DishComposition
                    {
                        Id = 44,
                        DishId = 44,
                        IngredientId = 44
                    },
                    new DishComposition
                    {
                        Id = 45,
                        DishId = 45,
                        IngredientId = 45
                    },
                    new DishComposition
                    {
                        Id = 46,
                        DishId = 46,
                        IngredientId = 46
                    },
                    new DishComposition
                    {
                        Id = 47,
                        DishId = 47,
                        IngredientId = 47
                    },
                    new DishComposition
                    {
                        Id = 48,
                        DishId = 48,
                        IngredientId = 48
                    },
                    new DishComposition
                    {
                        Id = 49,
                        DishId = 49,
                        IngredientId = 49
                    },
                    new DishComposition
                    {
                        Id = 50,
                        DishId = 50,
                        IngredientId = 50
                    },
                    new DishComposition
                    {
                        Id = 51,
                        DishId = 51,
                        IngredientId = 51
                    },
                    new DishComposition
                    {
                        Id = 52,
                        DishId = 52,
                        IngredientId = 52
                    },
                    new DishComposition
                    {
                        Id = 53,
                        DishId = 53,
                        IngredientId = 53
                    },
                    new DishComposition
                    {
                        Id = 54,
                        DishId = 54,
                        IngredientId = 54
                    },
                    new DishComposition
                    {
                        Id = 55,
                        DishId = 55,
                        IngredientId = 55
                    },
                    new DishComposition
                    {
                        Id = 56,
                        DishId = 56,
                        IngredientId = 56
                    },
                    new DishComposition
                    {
                        Id = 57,
                        DishId = 57,
                        IngredientId = 57
                    },
                    new DishComposition
                    {
                        Id = 58,
                        DishId = 58,
                        IngredientId = 58
                    },
                    new DishComposition
                    {
                        Id = 59,
                        DishId = 59,
                        IngredientId = 59
                    },
                    new DishComposition
                    {
                        Id = 60,
                        DishId = 60,
                        IngredientId = 60
                    },
                    new DishComposition
                    {
                        Id = 61,
                        DishId = 61,
                        IngredientId = 61
                    },
                    new DishComposition
                    {
                        Id = 62,
                        DishId = 62,
                        IngredientId = 62
                    },
                    new DishComposition
                    {
                        Id = 63,
                        DishId = 63,
                        IngredientId = 63
                    },
                    new DishComposition
                    {
                        Id = 64,
                        DishId = 64,
                        IngredientId = 64
                    },
                    new DishComposition
                    {
                        Id = 65,
                        DishId = 65,
                        IngredientId = 65
                    },
                    new DishComposition
                    {
                        Id = 66,
                        DishId = 66,
                        IngredientId = 66
                    },
                    new DishComposition
                    {
                        Id = 67,
                        DishId = 67,
                        IngredientId = 67
                    },
                    new DishComposition
                    {
                        Id = 68,
                        DishId = 68,
                        IngredientId = 68
                    },
                    new DishComposition
                    {
                        Id = 69,
                        DishId = 69,
                        IngredientId = 69
                    },
                    new DishComposition
                    {
                        Id = 70,
                        DishId = 70,
                        IngredientId = 70
                    },
                    new DishComposition
                    {
                        Id = 71,
                        DishId = 71,
                        IngredientId = 71
                    },
                    new DishComposition
                    {
                        Id = 72,
                        DishId =72,
                        IngredientId = 72
                    }
                );
;



            var ingredients = modelBuilder.Entity<Ingredient>();
            ingredients.HasMany(c => c.DishCompositions)
                    .WithOne(c=>c.Ingredient)
                    .HasForeignKey(c => c.IngredientId);

            var dish = modelBuilder.Entity<Dish>();
            dish.HasMany(c => c.DishCompositions)
                    .WithOne(d => d.Dish);

            var dishorder = modelBuilder.Entity<DishOrder>();
            dishorder.HasOne(c => c.Dish)
                    .WithOne();

            var order = modelBuilder.Entity<Order>();
            order.HasOne(c => c.TableOrder)
                    .WithOne();
            order.HasMany(c => c.DishesOrder)
                    .WithOne(d => d.Order);

            var tableorder = modelBuilder.Entity<TableOrder>();
            tableorder.HasOne(c => c.RestaurantTable)
                    .WithOne();

            var customer = modelBuilder.Entity<Customer>();
            customer.HasOne(c => c.CustomerOrder)
                    .WithOne();
            customer.HasOne(c => c.Person)
                    .WithOne();

            var admin = modelBuilder.Entity<Customer>();
            admin.HasOne(c => c.Person)
                    .WithOne();




            base.OnModelCreating(modelBuilder);
        }
    }

}
