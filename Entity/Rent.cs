using System;
using System.Data.SqlTypes;
using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Аренда.
    /// </summary>
    [Table(Name = "Rent")]
    public class Rent
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "RentId")]
        public int RentId { get; set; }

        /// <summary>
        /// Ключ к таблице "Арендатор".
        /// </summary>
        [Column(Name = "TenantId")]
        public int TenantId { get; set; }

        /// <summary>
        /// Арендатор.
        /// </summary>
        [Association(ThisKey = "TenantId", OtherKey = "TenantId", CanBeNull = false)]
        public Tenant Tenant { get; set; }

        /// <summary>
        /// Цена за аренду.
        /// </summary>
        [Column(Name = "PriceRent")]
        public SqlMoney PriceRent { get; set; }

        /// <summary>
        /// Начало аренды.
        /// </summary>
        [Column(Name = "DateStart")]
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Конец аренды.
        /// </summary>
        [Column(Name = "DateEnd")]
        public DateTime DateEnd { get; set; }

        /// <summary>
        /// Сумма за весь депозит.
        /// </summary>
        [Column(Name = "AllPriceDeposit")]
        public SqlMoney AllPriceDeposit { get; set; }

        /// <summary>
        /// Количество арендованного инвентаря.
        /// </summary>
        [Column(Name = "CountInventory")]
        public int CountInventory { get; set; }

        /// <summary>
        /// Аренда в процессе.
        /// </summary>
        [Column(Name = "IsRent")]
        public bool IsRent { get; set; }
    }
}