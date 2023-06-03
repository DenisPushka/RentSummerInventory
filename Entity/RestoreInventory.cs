using System.Data.SqlTypes;
using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Инвентраь на восстановлении.
    /// </summary>
    [Table(Name = "RestoreInventory")]
    public class RestoreInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "RestoreInventoryId")]
        public int RestoreInventoryId { get; set; }

        /// <summary>
        /// Ключ к таблице "Комания".
        /// </summary>
        [Column(Name = "CompanyId")]
        public int CompanyId { get; set; }
        
        /// <summary>
        /// Компания.
        /// </summary>
        [Association(ThisKey = "CompanyId", OtherKey = "CompanyId", CanBeNull = false)]
        public Company Company { get; set; }

        /// <summary>
        /// Ключ к таблице "Инвентраь".
        /// </summary>
        [Column(Name = "InventoryId")]
        public int InventoryId { get; set; }
        
        /// <summary>
        /// Инвентарь.
        /// </summary>
        [Association(ThisKey = "InventoryId", OtherKey = "InventoryId", CanBeNull = false)]
        public Inventory Inventory { get; set; }
        
        /// <summary>
        /// Цена.
        /// </summary>
        [Column(Name = "Price")]
        public SqlMoney Price { get; set; }
    }
}