using System.Data.SqlTypes;
using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Инвентарь.
    /// </summary>
    [Table(Name = "Inventory")]
    public class Inventory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "InventoryId")]
        public int InventoryId { get; set; }

        /// <summary>
        /// Ключ к таблице категория инвенторя.
        /// </summary>
        [Column(Name = "GroupInventoryId")]
        public int GroupInventoryId { get; set; }
        
        /// <summary>
        /// Группа товара.
        /// </summary>
        [Association(ThisKey = "GroupInventoryId", OtherKey = "GroupInventoryId", CanBeNull = false)]
        public GroupInventory GroupInventory { get; set; }
        
        /// <summary>
        /// Ключ к таблице подкатегория.
        /// </summary>
        [Column(Name = "SubcategoryInventoryId")]
        public int SubcategoryInventoryId { get; set; }
        
        /// <summary>
        /// Подкатегория.
        /// </summary>
        [Association(ThisKey = "SubcategoryInventoryId", OtherKey = "SubcategoryInventoryId", CanBeNull = false)]
        public SubcategoryInventory SubcategoryInventory { get; set; }
        
        /// <summary>
        /// Название.
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Цена за час.
        /// </summary>
        [Column(Name = "PriceHour")]
        public SqlMoney PriceHour { get; set; }
        
        /// <summary>
        /// Залог.
        /// </summary>
        [Column(Name = "PriceDeposit")]
        public SqlMoney PriceDeposit { get; set; }
        
        /// <summary>
        /// Товар в наличии.
        /// </summary>
        [Column(Name = "InStore")]
        public bool InStoke { get; set; }
        
        /// <summary>
        /// Ключ к таблице "Категория товара".
        /// </summary>
        [Column(Name = "AgeCategoryId")]
        public int AgeCategoryId { get; set; }
        
        /// <summary>
        /// Категория товара.
        /// </summary>
        [Association(ThisKey = "AgeCategoryId", OtherKey = "AgeCategoryId", CanBeNull = false)]
        public AgeCategory AgeCategory { get; set; }
    }
}