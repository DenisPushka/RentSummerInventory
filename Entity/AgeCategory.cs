using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Возрастная категория.
    /// </summary>
    [Table(Name = "AgeCategory")]
    public class AgeCategory
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "AgeCategoryId")]
        public int AgeCategoryId { get; set; }

        /// <summary>
        /// Название категории.
        /// </summary>
        [Column(Name = "NameCategory")]
        public string NameCategory { get; set; }
        
        /// <summary>
        /// Возростное начало категории.
        /// </summary>
        [Column(Name = "BeginAge")]
        public int BeginAge { get; set; }
        
        /// <summary>
        /// Возростное окончание категории.
        /// </summary>
        [Column(Name = "EndAge")]
        public int EndAge { get; set; }
    }
}