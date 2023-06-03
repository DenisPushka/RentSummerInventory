using LinqToDB.Mapping;

namespace Entity
{
    /// <summary>
    /// Район.
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Ключ идентификатор.
        /// </summary>
        [PrimaryKey]
        [Column(Name = "RegionId")]
        public int RegionId { get; set; }

        /// <summary>
        /// Название региона.
        /// </summary>
        [Column(Name = "NameRegion")]
        public string NameRegion { get; set; }
    }
}