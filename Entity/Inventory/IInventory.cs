using LinqToDB.Mapping;

namespace Entity
{
    public interface IInventory
    {
        /// <summary>
        /// Ключ к таблице инвентарь.
        /// </summary>
        [Column(Name = "InventoryId")]
        int InventoryId { get; set; }

        /// <summary>
        /// Инвентарь.
        /// </summary>
        [Association(ThisKey = "InventoryId", OtherKey = "InventoryId", CanBeNull = false)]
        Inventory Inventory { get; set; }
    }
}