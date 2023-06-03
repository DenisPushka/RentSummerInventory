using System;
using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Списанный инвентарь.
    /// </summary>
    [Table(Name = "SpoiledInventory")]
    public class SpoiledInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "SpoiledInventoryId")]
        public int SpoiledInventoryId { get; set; }

        /// <summary>
        /// Ключ к таблице инвентарь.
        /// </summary>
        [Column(Name = "InventoryId")]
        public int InventoryId { get; set; }
        
        /// <summary>
        /// Инвентарь.
        /// </summary>
        [Association(ThisKey = "InventoryId", OtherKey = "InventoryId", CanBeNull = false)]
        public Inventory Inventory { get; set; }

        /// <summary>
        /// Дата списания.
        /// </summary>
        [Column(Name = "DateSpoiled")]
        public DateTime DateSpoiled { get; set; }
    }
}