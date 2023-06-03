using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Группа товаров.
    /// </summary>
    [Table(Name = "GroupInventory")]
    public class GroupInventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "GroupInventoryId")]
        public int GroupInventoryId { get; set; }

        /// <summary>
        /// Название группы.
        /// </summary>
        [Column(Name = "NameGroup")]
        public string NameGroup { get; set; }
        
        /// <summary>
        /// Ключ к таблице "Подкатегория".
        /// </summary>
        [Column(Name = "SubcategoryInventoryId")]
        public int SubcategoryInventoryId { get; set; }
        
        /// <summary>
        /// Подкатегория.
        /// </summary>
        [Association(ThisKey = "SubcategoryInventoryId", OtherKey = "SubcategoryInventoryId", CanBeNull = false)]
        public SubcategoryInventory SubcategoryInventory { get; set; }

        /// <summary>
        /// Количество товаров.
        /// </summary>
        [Column(Name = "CountInventory")]
        public int CountInventory { get; set; }
    }
}