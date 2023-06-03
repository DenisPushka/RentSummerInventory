using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Ролики.
    /// </summary>
    [Table(Name = "RollerSkates")]
    public class RollerSkates : IInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "RollerSkatesId")]
        public int RollerSkatesId { get; set; }

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
        /// Количество колес.
        /// </summary>
        [Column(Name = "CountWheel")]
        public int CountWheel { get; set; }

        /// <summary>
        /// Размер.
        /// </summary>
        [Column(Name = "Size")]
        public string Size { get; set; }

        /// <summary>
        /// С тормозом.
        /// </summary>
        [Column(Name = "IsDrag")]
        public bool IsDrag { get; set; }
    }
}