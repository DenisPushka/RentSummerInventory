using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Diagnostics;
using Entity;
using LinqToDB;

namespace Repository.Provider
{
    /// <summary>
    /// Провайдер linq2DB для таблицы "Inventory".
    /// </summary>
    public class InventoryLinqProvider
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        private readonly string _connectionString =
            ConfigurationManager.AppSettings.Get("ConnectionStringToDbRentInventory");

        /// <summary>
        /// Добавление инвенатря.
        /// </summary>
        /// <param name="inventory">Сущность инвентарь.</param>
        /// <param name="product">Добавляемый объект.</param>
        public void AddInventory(Inventory inventory, IInventory product)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    var inventoryId =
                        (
                            from inv in db.Inventories
                            select inv
                        )
                        .ToList()
                        .Last()
                        .InventoryId;

                    inventory.InventoryId = ++inventoryId;
                    db.Inventories
                        .DataContext
                        .Insert(inventory);

                    var typeProduct = product.GetType();

                    product.InventoryId = inventoryId;

                    if (ReferenceEquals(typeof(Bike), typeProduct))
                    {
                        var bike = (Bike)product;
                        bike.BikeId =
                            (
                                from b in db.Bikes
                                select b
                            )
                            .ToList()
                            .Last()
                            .BikeId + 1;

                        db.Bikes
                            .DataContext
                            .Insert(bike);
                    }
                    else if (ReferenceEquals(typeof(Scooter), typeProduct))
                    {
                        var scooter = (Scooter)product;
                        scooter.ScooterId =
                            (
                                from sc in db.Scooters
                                select sc
                            )
                            .ToList()
                            .Last()
                            .ScooterId + 1;

                        db.Scooters
                            .DataContext
                            .Insert(scooter);
                    }
                    else if (ReferenceEquals(typeof(RollerSkates), typeProduct))
                    {
                        var roller = (RollerSkates)product;
                        roller.RollerSkatesId =
                            (
                                from r in db.RollerSkates
                                select r
                            )
                            .ToList()
                            .Last()
                            .RollerSkatesId + 1;

                        db.RollerSkates
                            .DataContext
                            .Insert(roller);
                    }
                    else
                    {
                        var skateboard = (Skateboard)product;
                        skateboard.SkateboardId =
                            (
                                from sc in db.Skateboards
                                select sc
                            )
                            .ToList()
                            .Last()
                            .SkateboardId + 1;

                        db.Skateboards
                            .DataContext
                            .Insert(skateboard);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Получение данных из таблицы "Инвентарь".
        /// </summary>
        /// <returns>Инвентарь</returns>
        public List<Inventory> GetInventories()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from inventory in db.Inventories
                            select inventory
                        )
                        .LoadWith(request => request.AgeCategory)
                        .LoadWith(request => request.SubcategoryInventory)
                        .LoadWith(request => request.GroupInventory)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Поиск по категории.
        /// </summary>
        /// <param name="nameCategory">Название категории.</param>
        /// <returns>Инвентарь из данной категории.</returns>
        public List<Inventory> GetInventoriesForCategories(string nameCategory)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from inventory in db.Inventories
                            select inventory
                        )
                        .LoadWith(request => request.AgeCategory)
                        .LoadWith(request => request.SubcategoryInventory)
                        .Where(request => request.SubcategoryInventory.NameSubcategoryInventory.Equals(nameCategory))
                        .LoadWith(request => request.GroupInventory)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Поиск по названию.
        /// </summary>
        /// <param name="name">Название</param>
        /// <returns>Инвентарь.</returns>
        public List<Inventory> GetInventoryForName(string name)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from inventory in db.Inventories
                            select inventory
                        )
                        .Where(inventory => inventory.Name.Contains(name))
                        .LoadWith(request => request.AgeCategory)
                        .LoadWith(request => request.SubcategoryInventory)
                        .LoadWith(request => request.GroupInventory)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }    
        }
        
        /// <summary>
        /// Обновление инвентаря.
        /// </summary>
        /// <param name="inventories">Обновленный инвентарь.</param>
        public void UpdateInventory(List<Inventory> inventories)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    foreach (var inventory in inventories)
                    {
                        db.Inventories
                            .Where(inv => inv.InventoryId == inventory.InventoryId)
                            .Set(inv => inv.Name, inventory.Name)
                            .Set(inv => inv.PriceHour, inventory.PriceHour)
                            .Set(inv => inv.PriceDeposit, inventory.PriceDeposit)
                            .Set(inv => inv.InStoke, inventory.InStoke)
                            .Update();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
    }
}