using System;
using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Бронирование.
    /// </summary>
    [Table(Name = "Booking")]
    public class Booking
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "BookingId")]
        public int BookingId { get; set; }

        /// <summary>
        /// Ключ к таблице "Арендатор".
        /// </summary>
        [Column(Name = "TenantId")]
        public int TenantId { get; set; }

        /// <summary>
        /// Арендатор.
        /// </summary>
        [Association(ThisKey = "TenantId", OtherKey = "TenantId", CanBeNull = false)]
        public Tenant Tenant { get; set; }
        
        /// <summary>
        /// Дата и время окончание брони.
        /// </summary>
        [Column(Name = "DateEnd")]
        public DateTime DateEnd { get; set; }

    }
}