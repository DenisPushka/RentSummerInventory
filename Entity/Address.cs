using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Aдрес.
    /// </summary>
    [Table(Name = "Address")]
    public class Address
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "AddressId")]
        public int AddressId { get; set; }

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

        /// <summary>
        /// Город, по умолчанию - "Самара".
        /// </summary>
        [Column(Name = "City")]
        public string City { get; set; }

        /// <summary>
        /// Улица, по умолчанию - "Московское шоссе".
        /// </summary>
        [Column(Name = "Street")]
        public string Street { get; set; }

        /// <summary>
        /// Дома, по умолчанию - "1".
        /// </summary>
        [Column(Name = "Home")]
        public string Home { get; set; }
    }
}