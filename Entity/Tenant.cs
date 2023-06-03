using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Арендатор.
    /// </summary>
    [Table(Name = "Tenant")]
    public class Tenant
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "TenantId")]
        public int TenantId { get; set; }

        /// <summary>
        /// ФИО.
        /// </summary>
        [Column(Name = "FIO")]
        public string Fio { get; set; }
        
        /// <summary>
        /// Возраст.
        /// </summary>
        [Column(Name = "Age")]
        public int Age { get; set; }
        
        /// <summary>
        /// Пол.
        /// </summary>
        [Column(Name = "Gender")]
        public char Gender { get; set; }
        
        /// <summary>
        /// Ключ к таблице "Район".
        /// </summary>
        [Column(Name = "RegionId")]
        public int RegionId { get; set; }
        
        /// <summary>
        /// Район.
        /// </summary>
        [Association(ThisKey = "RegionId", OtherKey = "RegionId", CanBeNull = false)]
        public Region Region { get; set; }
    }
}