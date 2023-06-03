using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Aдрес.
    /// </summary>
    [Table(Name = "Company")]
    public class Company
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "CompanyId")]
        public int CompanyId { get; set; }
        
        /// <summary>
        /// Название комании.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "NameCompany")]
        public string NameCompany { get; set; }
        
        /// <summary>
        /// Номер телефона компании.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "Phone")]
        public string Phone { get; set; }
        
        /// <summary>
        /// Ключ к таблице "Адрес".
        /// </summary>
        [Column(Name = "AddressId")]
        public int AddressId { get; set; }
        
        /// <summary>
        /// Адрес.
        /// </summary>
        [Association(ThisKey = "AddressId", OtherKey = "AddressId", CanBeNull = false)]
        public Address Address { get; set; }
    }
}