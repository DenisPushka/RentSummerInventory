using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Самокат.
    /// </summary>
    [Table(Name = "Scooter")]
    public class Scooter : IInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "ScooterId")]
        public int ScooterId { get; set; }

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
        /// Электрический самокат.
        /// </summary>
        [Column(Name = "IsElectric")]
        public bool IsElectric { get; set; }
    }
}