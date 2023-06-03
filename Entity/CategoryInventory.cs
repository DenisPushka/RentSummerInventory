using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Категория товаров.
    /// </summary>
    [Table(Name = "CategoryInventory")]
    public class CategoryInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "CategoryInventoryId")]
        public int CategoryInventoryId { get; set; }
        
        /// <summary>
        /// Название категории.
        /// </summary>
        [Column(Name = "NameCategory")]
        public string NameCategory { get; set; }
        
        /// <summary>
        /// Количество оставшегося товара.
        /// </summary>
        [Column(Name = "CountInventory")]
        public int CountInventory { get; set; }

    }
}