using CollectionViewDemo.MVVM.Models;
using PropertyChanged;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectionViewDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DataViewModel
    {
       
        public ObservableCollection<Produkt> Produkts { get; set; } =
            new ObservableCollection<Produkt>();

        public bool IsRefrashing { get; set; }

        public ICommand RefreshCommand =>
            new Command(async () =>
            {
                IsRefrashing = true;
                await Task.Delay(3000);
                RefreshItems();  
                IsRefrashing=false;
            });

        public ICommand ThreshsholdRecheadCommand =>
            new Command(async () =>
            {
                RefreshItems(Produkts.Count);
            });

        public DataViewModel()
        {
            RefreshItems();
        }

        public ICommand DeleteCommand =>
            new Command((p) =>
            {
                Produkts.Remove((Produkt)p);
            });



        private void RefreshItems(int lastIndex=0)
        {
            int numberOfItemsPerPage = 10;
            var items = new ObservableCollection<Produkt> 
               {
                    new Produkt
                     {
                         Name = "Yogurt",
                         Price = 60.0m,
                         Image = "yogurt.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Produkt
                     {
                         Name = "Watermelon",
                         Price = 30.0m,
                         Image = "watermelon.png",
                         HasOffer = false,
                         Stock = 87
                     },
                     new Produkt
                     {
                         Name = "Water Bottle",
                         Price = 80.0m,
                         Image = "water_bottle.png",
                         HasOffer = true,
                         OfferPrice = 69.99m,
                         Stock = 33
                     },
                     new Produkt
                     {
                         Name = "Tomato",
                         Price = 120.0m,
                         Image = "tomato.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Produkt
                     {
                         Name = "Tea",
                         Price = 65.0m,
                         Image = "tea_bag.png",
                         HasOffer = false,
                         Stock = 82
                     },
                     new Produkt
                     {
                         Name = "Sparkling Drink",
                         Price = 35.0m,
                         Image = "sparkling_drink.png",
                         HasOffer = false,
                         Stock = 728
                     },
                     new Produkt
                     {
                         Name = "Spaguetti",
                         Price = 15.0m,
                         Image = "spaguetti.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Produkt
                     {
                         Name = "Cream",
                         Price = 48.0m,
                         Image = "cream.png",
                         HasOffer = false,
                         Stock = 22
                     },
                     new Produkt
                     {
                         Name = "Snack",
                         Price = 25.0m,
                         Image = "009_snack.png",
                         HasOffer = false,
                         Stock = 2
                     },
                     new Produkt
                     {
                         Name = "Shrimp",
                         Price = 300.0m,
                         Image = "shrimp.png",
                         HasOffer = true,
                         OfferPrice = 250.0m,
                         Stock = 58
                     },
                     new Produkt
                     {
                         Name = "Seasoning",
                         Price = 185.0m,
                         Image = "seasoning.png",
                         HasOffer = false,
                         Stock = 99
                     },
                     new Produkt
                     {
                         Name = "Sauce",
                         Price = 220.0m,
                         Image = "sauce.png",
                         HasOffer = false,
                         Stock = 72
                     },
                     new Produkt
                     {
                         Name = "Rice",
                         Price = 48.0m,
                         Image = "rice.png",
                         HasOffer = false,
                         Stock = 143
                     },
                     new Produkt
                     {
                         Name = "Peas",
                         Price = 114.0m,
                         Image = "peas.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Produkt
                     {
                         Name = "Ham",
                         Price = 215.0m,
                         Image = "ham_1.png",
                         HasOffer = true,
                         OfferPrice = 189.0m,
                         Stock = 732
                     },
                     new Produkt
                     {
                         Name = "Chicken Leg",
                         Price = 142.0m,
                         Image = "chicken_leg.png",
                         HasOffer = true,
                         OfferPrice = 125.0m,
                         Stock = 20
                     },
                     new Produkt
                     {
                         Name = "Pizza",
                         Price = 321.0m,
                         Image = "pizza.png",
                         HasOffer = false,
                         Stock = 559
                     },
                     new Produkt
                     {
                         Name = "Pineapple",
                         Price = 49.0m,
                         Image = "pineapple.png",
                         HasOffer = false,
                         Stock = 41
                     },
                     new Produkt
                     {
                         Name = "Pepper",
                         Price = 60.0m,
                         Image = "pepper.png",
                         HasOffer = true,
                         OfferPrice = 30.0m,
                         Stock = 64
                     },
                     new Produkt
                     {
                         Name = "Pasta",
                         Price = 52.0m,
                         Image = "pasta.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Produkt
                     {
                         Name = "Oil Bottle",
                         Price = 152.0m,
                         Image = "oil_bottle.png",
                         HasOffer = false,
                         Stock = 87
                     },
                     new Produkt
                     {
                         Name = "Mushroom",
                         Price = 28.0m,
                         Image = "mushroom.png",
                         HasOffer = false,
                         Stock = 17
                     },
                     new Produkt
                     {
                         Name = "Milk Bottle",
                         Price = 85.0m,
                         Image = "milk_bottle.png",
                         HasOffer = false,
                         Stock = 39
                     },
                     new Produkt
                     {
                         Name = "Meat",
                         Price = 450.0m,
                         Image = "meat.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Produkt
                     {
                         Name = "Lemon",
                         Price = 20.0m,
                         Image = "lemon.png",
                         HasOffer = false,
                         Stock = 87
                     },
                     new Produkt
                     {
                         Name = "Tomato Sauce",
                         Price = 15.0m,
                         Image = "tomato_sauce.png",
                         HasOffer = false,
                         Stock = 26
                     },
                     new Produkt
                     {
                         Name = "Juice",
                         Price = 60.0m,
                         Image = "juice.png",
                         HasOffer = false,
                         Stock = 31
                     },
                     new Produkt
                     {
                         Name = "Ice Cream",
                         Price = 251.0m,
                         Image = "ice_cream.png",
                         HasOffer = true,
                         OfferPrice = 200.0m,
                         Stock = 88
                     },
                     new Produkt
                     {
                         Name = "Ham",
                         Price = 290.0m,
                         Image = "ham.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Produkt
                     {
                         Name = "Ice",
                         Price = 125.0m,
                         Image = "ice.png",
                         HasOffer = false,
                         Stock = 22
                     },
                     new Produkt
                     {
                         Name = "Flour",
                         Price = 86.0m,
                         Image = "flour.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Produkt
                     {
                         Name = "Fish",
                         Price = 440.0m,
                         Image = "fish_1.png",
                         HasOffer = false,
                         Stock = 80
                     },
                     new Produkt
                     {
                         Name = "Fish 2",
                         Price = 425.0m,
                         Image = "fish.png",
                         HasOffer = false,
                         Stock = 24
                     },
                     new Produkt
                     {
                         Name = "Eggs",
                         Price = 150.0m,
                         Image = "eggs.png",
                         HasOffer = false,
                         Stock = 47
                     },
                     new Produkt
                     {
                         Name = "Cucumber",
                         Price = 35.0m,
                         Image = "cucumber.png",
                         HasOffer = false,
                         Stock = 74
                     },
                     new Produkt
                     {
                         Name = "Croissant",
                         Price = 68.0m,
                         Image = "croissant.png",
                         HasOffer = true,
                         OfferPrice = 50.0m,
                         Stock = 27
                     },
                     new Produkt
                     {
                         Name = "Cookies",
                         Price = 95.0m,
                         Image = "cookie.png",
                         HasOffer = false,
                         Stock = 56
                     },
                     new Produkt
                     {
                         Name = "Coffee",
                         Price = 154.0m,
                         Image = "toffee.png",
                         HasOffer = false,
                         Stock = 83
                     },
                     new Produkt
                     {
                         Name = "Chocolate Bar",
                         Price = 32.0m,
                         Image = "chocolate_bar.png",
                         HasOffer = false,
                         Stock = 21
                     },
                     new Produkt
                     {
                         Name = "Cheese",
                         Price = 36.0m,
                         Image = "cheese.png",
                         HasOffer = true,
                         OfferPrice = 25.0m,
                         Stock =73
                     },
                     new Produkt
                     {
                         Name = "Carrot",
                         Price = 15.0m,
                         Image = "carrot.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Produkt
                     {
                         Name = "Canned Food",
                         Price = 89.0m,
                         Image = "canned_food.png",
                         HasOffer = false,
                         Stock = 773
                     },
                     new Produkt
                     {
                         Name = "Soda",
                         Price = 45.0m,
                         Image = "can.png",
                         HasOffer = false,
                         Stock = 843
                     },
                     new Produkt
                     {
                         Name = "Candies",
                         Price = 55.0m,
                         Image = "candy.png",
                         HasOffer = false,
                         Stock = 71
                     },
                     new Produkt
                     {
                         Name = "Cake",
                         Price = 250.0m,
                         Image = "cake.png",
                         HasOffer = true,
                         OfferPrice = 200.0m,
                         Stock = 0
                     },
                     new Produkt
                     {
                         Name = "Bread",
                         Price = 100.0m,
                         Image = "bread_1.png",
                         HasOffer = false,
                         Stock =134
                     },
                     new Produkt
                     {
                         Name = "Bread",
                         Price = 85.0m,
                         Image = "bread.png",
                         HasOffer = false,
                         Stock = 8
                     },
                     new Produkt
                     {
                         Name = "Banana",
                         Price = 15.0m,
                         Image = "banana.png",
                         HasOffer = true,
                         OfferPrice = 10.0m,
                         Stock = 72
                     },
                     new Produkt
                     {
                         Name = "Apple",
                         Price = 40.0m,
                         Image = "apple.png",
                         HasOffer = false,
                         Stock = 737
                     },
                     new Produkt
                     {
                         Name = "Alcohol",
                         Price = 370.0m,
                         Image = "alcohol.png",
                         HasOffer = false,
                         Stock = 9
                     },
            };

            var pageItems = 
                items
                .Skip(lastIndex)
                .Take(numberOfItemsPerPage);

            foreach(var item in pageItems)
            {
                Produkts.Add(item);
            }
        }
        
    }
}
