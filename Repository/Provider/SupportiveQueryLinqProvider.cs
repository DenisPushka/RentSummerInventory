using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Entity;
using LinqToDB;

namespace Repository.Provider
{
    public class SupportiveQueryLinqProvider
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        private readonly string _connectionString =
            ConfigurationManager.AppSettings.Get("ConnectionStringToDbRentInventory");

        /// <summary>
        /// Получение подкатегорий.
        /// </summary>
        /// <returns>Подкатегории.</returns>
        public List<SubcategoryInventory> GetSubcategoryInventories()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from s in db.SubcategoryInventories
                            select s
                        )
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
        /// Получение групп инвенторя.
        /// </summary>
        /// <returns>Группы инвенторя.</returns>
        public List<GroupInventory> GetGroupInventories()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from q in db.GroupInventories
                            select q
                        )
                        .LoadWith(request => request.SubcategoryInventory)
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
        /// Получение возрастных категорий.
        /// </summary>
        /// <returns>Возрастные категории.</returns>
        public List<AgeCategory> GetAgeCategories()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from category in db.AgeCategories
                            select category
                        )
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
        /// Получение компаний занимающяяся ремонтом.
        /// </summary>
        /// <returns>Ремонтные компании.</returns>
        public List<Company> GetCompany()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from company in db.Companies
                            select company
                        )
                        .LoadWith(request => request.Address)
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
        /// Получение всего производяегося ремонта.
        /// </summary>
        /// <returns>Ремонт.</returns>
        public List<RestoreInventory> GetRepair()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from restore in db.RestoreInventories
                            select restore
                        )
                        .LoadWith(request => request.Inventory)
                        .LoadWith(request => request.Company)
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
        /// Добавление ремонта.
        /// </summary>
        /// <param name="companyId">Id компании.</param>
        /// <param name="inventories">Все Id инвентаря.</param>
        /// <param name="price">Цена.</param>
        public void AddRepair(int companyId, IEnumerable<int> inventories, SqlMoney price)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    var restoreInventoryId =
                        (
                            from restoreInventory in db.RestoreInventories
                            select restoreInventory
                        )
                        .ToList()
                        .Last()
                        .RestoreInventoryId;

                    foreach (var inventory in inventories)
                    {
                        db.RestoreInventories
                            .DataContext
                            .Insert(new RestoreInventory
                            {
                                RestoreInventoryId = ++restoreInventoryId,
                                CompanyId = companyId,
                                InventoryId = inventory,
                                Price = price
                            });
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