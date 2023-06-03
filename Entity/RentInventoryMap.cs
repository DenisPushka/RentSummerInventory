using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Промежуточная таблица для связи N:N - аренда:инвентарь.
    /// </summary>
    [Table(Name = "RentInventoryMap")]
    public class RentInventoryMap
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "RentInventoryMapId")]
        public int RentInventoryMapId { get; set; }

        /// <summary>
        /// Ключ к таблице "Аренда".
        /// </summary>
        [Column(Name = "RentId")]
        public int RentId { get; set; }
        
        /// <summary>
        /// Ключ к таблице "Инвентарь".
        /// </summary>
        [Column(Name = "InventoryId")]
        public int InventoryId { get; set; }

    }
}