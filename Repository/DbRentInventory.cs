using Entity;
using LinqToDB;
using LinqToDB.Data;

namespace Repository
{
    /// <summary>
    /// База данных: RentSummerInventory.
    /// </summary>
    public class DbRentInventory : DataConnection
    {
        /// <summary>
        /// Инициализация.
        /// </summary>
        /// <param name="connectionString">Строка подключения.</param>
        public DbRentInventory(string connectionString)
            : base(ProviderName.SqlServer2019, connectionString)
        {
        }

        /// <summary>
        /// Таблица адрес.
        /// </summary>
        public ITable<Address> Addresses => this.GetTable<Address>();

        /// <summary>
        /// Таблица возрастаная категория.
        /// </summary>
        public ITable<AgeCategory> AgeCategories => this.GetTable<AgeCategory>();

        /// <summary>
        /// Таблица велосипед.
        /// </summary>
        public ITable<Bike> Bikes => this.GetTable<Bike>();

        /// <summary>
        /// Таблица бронирование.
        /// </summary>
        public ITable<Booking> Bookings => this.GetTable<Booking>();

        /// <summary>
        /// Таблица N:N - бронирование:инвентарь.
        /// </summary>
        public ITable<BookingInventoryMap> BookingInventoryMaps => this.GetTable<BookingInventoryMap>();

        /// <summary>
        /// Таблица категория товаров.
        /// </summary>
        public ITable<CategoryInventory> CategoryInventories => this.GetTable<CategoryInventory>();

        /// <summary>
        /// Таблица компания.
        /// </summary>
        public ITable<Company> Companies => this.GetTable<Company>();

        /// <summary>
        /// Таблица группа товаров.
        /// </summary>
        public ITable<GroupInventory> GroupInventories => this.GetTable<GroupInventory>();

        /// <summary>
        /// Таблица инвентарь.
        /// </summary>
        public ITable<Inventory> Inventories => this.GetTable<Inventory>();

        /// <summary>
        /// Таблица район.
        /// </summary>
        public ITable<Region> Regions => this.GetTable<Region>();

        /// <summary>
        /// Таблица аренда.
        /// </summary>
        public ITable<Rent> Rents => this.GetTable<Rent>();

        /// <summary>
        /// Таблица N:N - аренда:инвентарь.
        /// </summary>
        public ITable<RentInventoryMap> RentInventoryMaps => this.GetTable<RentInventoryMap>();

        /// <summary>
        /// Таблица восстановливаемый инвентарь.
        /// </summary>
        public ITable<RestoreInventory> RestoreInventories => this.GetTable<RestoreInventory>();

        /// <summary>
        /// Таблица ролики.
        /// </summary>
        public ITable<RollerSkates> RollerSkates => this.GetTable<RollerSkates>();

        /// <summary>
        /// Таблица самокат.
        /// </summary>
        public ITable<Scooter> Scooters => this.GetTable<Scooter>();

        /// <summary>
        /// Таблица скейтборд.
        /// </summary>
        public ITable<Skateboard> Skateboards => this.GetTable<Skateboard>();

        /// <summary>
        /// Таблица списанный инвентарь.
        /// </summary>
        public ITable<SpoiledInventory> SpoiledInventories => this.GetTable<SpoiledInventory>();

        /// <summary>
        /// Таблица подкатегория товаров.
        /// </summary>
        public ITable<SubcategoryInventory> SubcategoryInventories => this.GetTable<SubcategoryInventory>();

        /// <summary>
        /// Таблица арендатор.
        /// </summary>
        public ITable<Tenant> Tenants => this.GetTable<Tenant>();
    }
}