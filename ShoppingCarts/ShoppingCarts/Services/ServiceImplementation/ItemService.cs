using ShoppingCarts.Helpers;
using ShoppingCarts.Model;
using ShoppingCarts.Services.ServiceInterface;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShoppingCarts.Services.ServiceImplementation.ItemService))]

namespace ShoppingCarts.Services.ServiceImplementation
{
    public class ItemService : IItemService
    {
        private List<Item> Items;

        public ItemService()
        {
            Items = new List<Item>();
        }

        public async Task<List<Item>> GetItems()
        {
            Items.Clear();

            Items.Add(new Item
            {
                Image = "https://www.smarthomenx.com/wp-content/uploads/2019/02/pasted-image-0-1.png",
                Name = "Aibo",
                CustomName1 = "Add voice recognition",
                CustomName2 = "Add AI",
                CustomName3 = "Add dogs toy",
                Price = 10000,
                CustomPrice = 3000,
                Index = 1,
                Status = Settings.ItemStatus1,
                CustomStatus = Settings.ItemCustomStatus1,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://switch.com.kw/wp-content/uploads/2018/10/cozmo_robot_anki.png",
                Name = "Anki",
                CustomName1 = "Add expand movement range",
                CustomName2 = "Add AI",
                CustomName3 = "Add accessory",
                Price = 20050,
                CustomPrice = 5000,
                Index = 2,
                Status = Settings.ItemStatus2,
                CustomStatus = Settings.ItemCustomStatus2,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://i.blogs.es/e134ae/kuri/1366_2000.png",
                Name = "Kuri",
                Price = 10500,
                CustomPrice = 3000,
                Index = 3,
                Status = Settings.ItemStatus3,
                CustomStatus = Settings.ItemCustomStatus3,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://electronics360.globalspec.com/images/assets/458/14458/marscat.jpg",
                Name = "MarsCat",
                Price = 15000,
                CustomPrice = 6000,
                Index = 4,
                Status = Settings.ItemStatus4,
                CustomStatus = Settings.ItemCustomStatus4,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://zdnet3.cbsistatic.com/hub/i/r/2016/02/08/54ef6f07-bd9d-4c9c-9ab9-8abc5ce8224e/resize/770xauto/7d603709dfbf48967866abc855c3bf80/nao.png",
                Name = "NAO",
                Price = 12000,
                CustomPrice = 5000,
                Index = 5,
                Status = Settings.ItemStatus5,
                CustomStatus = Settings.ItemCustomStatus5,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://images-eu.ssl-images-amazon.com/images/I/41YHc8QpEsL.jpg",
                Name = "WOW Wee Robot",
                Price = 17000,
                CustomPrice = 7000,
                Index = 6,
                Status = Settings.ItemStatus6,
                CustomStatus = Settings.ItemCustomStatus6,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://igralandia.ru/pictures/backgroundtransparent/width315/height415/good_id11920/pic_name7bd702ac55c2434c82758b704020a64a.jpg",
                Name = "Wow Wee Coji",
                Price = 1500,
                CustomPrice = 500,
                Index = 7,
                Status = Settings.ItemStatus7,
                CustomStatus = Settings.ItemCustomStatus7,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://ae01.alicdn.com/kf/UTB8yRDqjL2JXKJkSanrq6y3lVXad/Wowwee.jpg_50x50.jpg",
                Name = "Wow Wee Cat",
                Price = 13000,
                CustomPrice = 5000,
                Index = 8,
                Status = Settings.ItemStatus8,
                CustomStatus = Settings.ItemCustomStatus8,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://scdn.slashgear.com/wp-content/uploads/2019/07/app.jpg",
                Name = "KiKi",
                Price = 18000,
                CustomPrice = 5000,
                Index = 9,
                Status = Settings.ItemStatus9,
                CustomStatus = Settings.ItemCustomStatus9,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://image.smythstoys.com/original/desktop/173746.jpg",
                Name = "SMR",
                Price = 9000,
                CustomPrice = 3000,
                Index = 10,
                Status = Settings.ItemStatus10,
                CustomStatus = Settings.ItemCustomStatus10,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://image.smythstoys.com/original/desktop/167345.jpg",
                Name = "Tobbie",
                Price = 7000,
                CustomPrice = 3000,
                Index = 11,
                Status = Settings.ItemStatus11,
                CustomStatus = Settings.ItemCustomStatus11,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://static.asiatimes.com/uploads/2019/11/Screen-Shot-2019-11-12-at-12.40.14-PM-900x540.png",
                Name = "Asia",
                Price = 10000,
                CustomPrice = 3000,
                Index = 12,
                Status = Settings.ItemStatus12,
                CustomStatus = Settings.ItemCustomStatus12,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://www.icases.ru/upload/iblock/68c/68c0a959f74bd45a742212bf3e06fdf4.jpg",
                Name = "UBtech",
                Price = 12000,
                CustomPrice = 4000,
                Index = 13,
                Status = Settings.ItemStatus13,
                CustomStatus = Settings.ItemCustomStatus14,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://upload.wikimedia.org/wikipedia/commons/6/6c/Atlas_from_boston_dynamics.jpg",
                Name = "Atlas",
                Price = 13000,
                CustomPrice = 6000,
                Index = 14,
                Status = Settings.ItemStatus14,
                CustomStatus = Settings.ItemCustomStatus14,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://global.honda/content/dam/site/global/innovation/cq_img/robotics/ASIMO/phisical03.jpg",
                Name = "Asimo",
                Price = 100000,
                CustomPrice = 20000,
                Index = 15,
                Status = Settings.ItemStatus15,
                CustomStatus = Settings.ItemCustomStatus15,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            return await Task.FromResult(Items);
        }
    }
}