using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Велосипед.
    /// </summary>
    [Table(Name = "Bike")]
    public class Bike : IInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "BikeId")]
        public int BikeId { get; set; }

        /// <summary>
        /// Количество людей, которые могу ехать на велосипеде.
        /// </summary>
        [Column(Name = "CountPeople")]
        public int CountPeople { get; set; }

        /// <summary>
        /// Тип велосипеда.
        /// </summary>
        [Column(Name = "Weight")]
        public int Weight { get; set; }

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
    }
}