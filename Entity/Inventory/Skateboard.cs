using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Скейтборд.
    /// </summary>
    [Table(Name = "Skateboard")]
    public class Skateboard : IInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "SkateboardId")]
        public int SkateboardId { get; set; }

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
        /// Тип скейтборда.
        /// </summary>
        [Column(Name = "TypeSkateboard")]
        public string TypeSkateboard { get; set; }
    }
}