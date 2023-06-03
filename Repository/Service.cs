using Repository.Provider;

namespace Repository
{
    /// <summary>
    /// Сервис.
    /// </summary>
    public static class Service
    {
        /// <summary>
        /// Получение провайдера для таблицы "Инвентарь".
        /// </summary>
        /// <returns>Провайдер для таблицы "Инвентарь".</returns>
        public static InventoryLinqProvider GetProviderInventory() => new InventoryLinqProvider();

        /// <summary>
        /// Получение провайдера для таблицы "Аренда".
        /// </summary>
        /// <returns>Провайдер для таблицы "Аренда".</returns>
        public static RentLinqProvider GetProviderRent() => new RentLinqProvider();

        /// <summary>
        /// Получение провайдера для таблицы "Арендатор".
        /// </summary>
        /// <returns>Провайдер для таблицы "Арендатор".</returns>
        public static TenantLinqProvider GetProviderTenant() => new TenantLinqProvider();

        /// <summary>
        /// Получение провайдера для таблицы "Бронирование".
        /// </summary>
        /// <returns>Провайдер для таблицы "Бронирование".</returns>
        public static BookingLinqProvider GetProviderBooking() => new BookingLinqProvider();

        /// <summary>
        /// Получение провайдера для вспомогательных запросов.
        /// </summary>
        /// <returns>Провайдер для осуществления вспомгательных запросов.</returns>
        public static SupportiveQueryLinqProvider GetProviderSupportiveQuery() => new SupportiveQueryLinqProvider();
    }
}