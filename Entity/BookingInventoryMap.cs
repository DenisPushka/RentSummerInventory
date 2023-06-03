using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Промежуточная таблица для связи N:N - бронирование:инвентраь.
    /// </summary>
    [Table(Name = "BookingInventoryMap")]
    public class BookingInventoryMap
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "BookingInventoryMapId")]
        public int BookingInventoryMapId { get; set; }
        
        /// <summary>
        /// Ключ к записи из таблицы "Бронирование".
        /// </summary>
        [Column(Name = "BookingId"), NotNull]
        public int BookingId { get; set; }

        /// <summary>
        /// Ключ к записи из таблицы "Инвентарь".
        /// </summary>
        [Column(Name = "InventoryId"), NotNull]
        public int InventoryId { get; set; }
    }
}