using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Entity;
using LinqToDB;

namespace Repository.Provider
{
    /// <summary>
    /// Провайдер linq2DB для таблицы "Booking".
    /// </summary>
    public class BookingLinqProvider
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        private readonly string _connectionString =
            ConfigurationManager.AppSettings.Get("ConnectionStringToDbRentInventory");

        /// <summary>
        /// Добавление бронирования.
        /// </summary>
        /// <param name="booking">Бронь.</param>
        /// <param name="arrayInventory">Множество id инвентаря.</param>
        public void AddBooking(Booking booking, IEnumerable<int> arrayInventory)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    var bookingId =
                        (
                            from rentN in db.Bookings
                            select rentN
                        )
                        .ToList()
                        .Last()
                        .BookingId;

                    booking.BookingId = ++bookingId;
                    db.Bookings
                        .DataContext
                        .Insert(booking);

                    var id =
                        (
                            from buffer in db.BookingInventoryMaps
                            select buffer
                        )
                        .ToList()
                        .Last()
                        .BookingInventoryMapId;

                    foreach (var inventoryId in arrayInventory)
                    {
                        db.BookingInventoryMaps
                            .DataContext
                            .Insert(new BookingInventoryMap
                            {
                                BookingInventoryMapId = ++id,
                                InventoryId = inventoryId,
                                BookingId = bookingId
                            });
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Получение бронирования.
        /// </summary>
        /// <returns>Бронирования.</returns>
        public IEnumerable<Booking> GetBookings()
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                        (
                            from booking in db.Bookings
                            select booking
                        )
                        .LoadWith(request => request.Tenant)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Получение одной брони.
        /// </summary>
        /// <param name="id">Id брони.</param>
        /// <returns>Брониварование.</returns>
        public Booking GetBooking(int id)
        {
            try
            {
                using (var db = new DbRentInventory(_connectionString))
                {
                    return
                    (
                        from booking in db.Bookings
                        where booking.BookingId == id
                        select booking
                    ).FirstOrDefault() ?? new Booking();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
    }
}