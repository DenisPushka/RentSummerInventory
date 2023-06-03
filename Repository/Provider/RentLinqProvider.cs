using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Entity;
using LinqToDB;

namespace Repository.Provider
{
    /// <summary>
    /// Провайдер linq2DB для таблицы "Rent".
    /// </summary>
    public class RentLinqProvider
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        private readonly string _connectionString =
            ConfigurationManager.AppSettings.Get("ConnectionStringToDbRentInventory");

        /// <summary>
        /// Добавление аренды.
        /// </summary>
        /// <param name="rent">Аренда.</param>
        /// <param name="inventories">Все Id инвентаря.</param>
        public void AddRent(Rent rent, IEnumerable<int> inventories)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    var rentId =
                        (
                            from rentN in db.Rents
                            select rentN
                        )
                        .ToList()
                        .Last()
                        .RentId;

                    rent.RentId = ++rentId;
                    db.Rents
                        .DataContext
                        .Insert(rent);

                    var rentInventoryMapsId =
                        (
                            from rentN in db.RentInventoryMaps
                            select rentN
                        )
                        .ToList()
                        .Last()
                        .RentInventoryMapId;

                    foreach (var inventory in inventories)
                    {
                        db.RentInventoryMaps
                            .DataContext
                            .Insert(new RentInventoryMap
                            {
                                RentInventoryMapId = ++rentInventoryMapsId, 
                                InventoryId = inventory, 
                                RentId = rentId
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

        /// <summary>
        /// Получение всех аренд.
        /// </summary>
        /// <returns>Все аренды.</returns>
        public IEnumerable<Rent> GetRents()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from rent in db.Rents
                            select rent
                        )
                        .LoadWith(request => request.Tenant)
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
        /// Получение аренды.
        /// </summary>
        /// <param name="id">Id аренды.</param>
        /// <returns>Аренда.</returns>
        public Rent GetRent(int id)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                    (
                        from rent in db.Rents
                        where rent.RentId == id
                        select rent
                    ).FirstOrDefault() ?? new Rent();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Изменение аренды.
        /// </summary>
        /// <param name="id">Id аренды.</param>
        /// <param name="newRent">Новые данные аренды.</param>
        public void UpdateTenant(int id, Rent newRent)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    db.Rents
                        .Where(rent => rent.RentId == id)
                        .Set(rent => rent.TenantId, newRent.TenantId)
                        .Set(rent => rent.CountInventory, newRent.CountInventory)
                        .Set(rent => rent.AllPriceDeposit, newRent.AllPriceDeposit)
                        .Set(rent => rent.PriceRent, newRent.PriceRent)
                        .Update();
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