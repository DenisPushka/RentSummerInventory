using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Подкатегория товаров.
    /// </summary>
    [Table(Name = "SubcategoryInventory")]
    public class SubcategoryInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "SubcategoryInventoryId")]
        public int SubcategoryInventoryId { get; set; }

        /// <summary>
        /// Ключ к таблице категория товаров.
        /// </summary>
        [Column(Name = "CategoryInventoryId")]
        public int CategoryInventoryId { get; set; }

        /// <summary>
        /// Категория товаров.
        /// </summary>
        [Association(ThisKey = "CategoryInventoryId", OtherKey = "CategoryInventoryId", CanBeNull = false)]
        public CategoryInventory CategoryInventory { get; set; }
        
        /// <summary>
        /// Название подкатегории.
        /// </summary>
        [Column(Name = "NameSubcategoryInventory")]
        public string NameSubcategoryInventory { get; set; }
    }
}