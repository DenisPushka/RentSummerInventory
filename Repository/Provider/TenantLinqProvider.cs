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
    /// Провайдер linq2DB для таблицы "Tenant".
    /// </summary>
    public class TenantLinqProvider
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        private readonly string _connectionString =
            ConfigurationManager.AppSettings.Get("ConnectionStringToDbRentInventory");

        /// <summary>
        /// Добавление арендадателя.
        /// </summary>
        /// <param name="tenant">Арендадатель.</param>
        public void AddTenant(Tenant tenant)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    tenant.TenantId =
                        (
                            from t in db.Tenants
                            select t
                        )
                        .ToList()
                        .Last()
                        .TenantId + 1;
                    
                    db.Tenants
                        .DataContext
                        .Insert(tenant);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Получение арендодателей.
        /// </summary>
        /// <returns>Арендаторы.</returns>
        public IEnumerable<Tenant> GetTenants()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from tenant in db.Tenants
                            select tenant
                        )
                        .LoadWith(request => request.Region)
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
        /// Получение арендодателя.
        /// </summary>
        /// <param name="id">Id арендатора.</param>
        /// <returns>Арендатор.</returns>
        public Tenant GetTenant(int id)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                    (
                        from tenant in db.Tenants
                        where tenant.TenantId == id
                        select tenant
                    ).FirstOrDefault() ?? new Tenant();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Изменение арендадателей.
        /// </summary>
        /// <param name="newTenant">Новые данные арендадателей.</param>
        public void UpdateTenant(List<Tenant> newTenant)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    foreach (var ten in newTenant)
                    {
                        db.Tenants
                            .Where(tenant => tenant.TenantId == ten.TenantId)
                            .Set(tenant => tenant.Fio, ten.Fio)
                            .Set(tenant => tenant.RegionId, ten.RegionId)
                            .Set(tenant => tenant.Age, ten.Age)
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