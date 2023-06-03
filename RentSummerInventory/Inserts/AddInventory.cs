using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entity;
using Repository;
using Repository.Provider;

namespace RentSummerInventory
{
    /// <summary>
    /// Форма добавления инвентаря.
    /// </summary>
    public partial class AddInventory : Form
    {
        /// <summary>
        /// Главная форма.
        /// </summary>
        private MainForm Form { get; }

        /// <summary>
        /// Группы инвентаря.
        /// </summary>
        private readonly List<GroupInventory> _groupInventories;

        /// <summary>
        /// Возрастные категории.
        /// </summary>
        private readonly List<AgeCategory> _ages;

        /// <summary>
        /// Вспомогательный провайдер.
        /// </summary>
        private readonly SupportiveQueryLinqProvider _supportive;

        public AddInventory(MainForm form)
        {
            InitializeComponent();

            Form = form;
            _supportive = Service.GetProviderSupportiveQuery();
            var subcategoryInventories = _supportive.GetSubcategoryInventories();

            foreach (var category in subcategoryInventories)
            {
                domainUpDown_subcategory.Items.Add(category.NameSubcategoryInventory);
            }

            _groupInventories = _supportive.GetGroupInventories();
            GetGroup(domainUpDown_subcategory.Items[0].ToString());

            _ages = _supportive.GetAgeCategories();
            foreach (var age in _ages)
            {
                domainUpDown_Age.Items.Add(age.NameCategory);
            }
        }

        /// <summary>
        /// Получение группы.
        /// </summary>
        /// <param name="subcategory">Подкатегория.</param>
        private void GetGroup(string subcategory)
        {
            domainUpDown_GroupInventory.Items.Clear();
            foreach (var group in _groupInventories
                         .Where(group =>
                             subcategory.Equals(group.SubcategoryInventory.NameSubcategoryInventory)))
            {
                domainUpDown_GroupInventory.Items.Add(group.NameGroup);
            }
        }

        /// <summary>
        /// Обработчик события, выбора подгруппы.
        /// </summary>
        private void domainUpDown_subcategory_SelectedItemChanged(object sender, EventArgs e)
        {
            var index = domainUpDown_subcategory.SelectedIndex;
            if (ValidationIndex(index, domainUpDown_subcategory))
                return;

            // Изменение группы.
            GetGroup(domainUpDown_subcategory.Items[index].ToString());

            // Изменение полей для выбора (в зависимости от подкатегории).
            switch (domainUpDown_subcategory.Items[index].ToString())
            {
                case "Велосипед":
                    label_Add1.Text = @"Кол-во людей: ";
                    textBox_Add1.Visible = label_Add1.Visible = true;
                    label_Add2.Text = @"Вес: ";
                    textBox_Add2.Visible = label_Add2.Visible = true;
                    label_Add3.Visible = textBox_Add3.Visible = false;
                    break;
                case "Самокат":
                    label_Add1.Text = @"Электрический (1/0): ";
                    textBox_Add1.Visible = label_Add1.Visible = true;
                    textBox_Add2.Visible = label_Add2.Visible =
                        label_Add3.Visible = textBox_Add3.Visible = false;
                    break;
                case "Скейтборд":
                    textBox_Add1.Visible = label_Add1.Visible =
                        textBox_Add2.Visible = label_Add2.Visible =
                            label_Add3.Visible = textBox_Add3.Visible = false;
                    break;
                case "Ролики":
                    label_Add1.Text = @"Размер (от-до): ";
                    textBox_Add1.Visible = label_Add1.Visible = true;
                    label_Add2.Text = @"Количество колес: ";
                    textBox_Add2.Visible = label_Add2.Visible = true;
                    label_Add3.Text = @"Есть тормоз (1/0): ";
                    label_Add3.Visible = textBox_Add3.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Валидация индекса таблицы.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <param name="domainUpDown">Содержит множество в котором происходит проверка.</param>
        /// <returns>true - в случае успеха</returns>
        private static bool ValidationIndex(int index, DomainUpDown domainUpDown) =>
            index < 0 || index > domainUpDown.Items.Count;

        /// <summary>
        /// ОБработчик события нажатия на кнопку "Сохранить".
        /// </summary>
        private void button_Save_Click(object sender, EventArgs e)
        {
            var select = domainUpDown_GroupInventory
                .Items[domainUpDown_GroupInventory.SelectedIndex];

            var selectGroup = _groupInventories
                .Where(group => select.Equals(group.NameGroup))
                .Select(group => group)
                .FirstOrDefault();

            select = domainUpDown_Age
                .Items[domainUpDown_Age.SelectedIndex];

            var ageId = _ages
                .Where(age => select.Equals(age.NameCategory))
                .Select(age => age.AgeCategoryId)
                .FirstOrDefault();

            var inventory = new Inventory
            {
                GroupInventoryId = selectGroup.GroupInventoryId,
                SubcategoryInventoryId = selectGroup.SubcategoryInventoryId,
                Name = textBox_Name.Text,
                PriceHour = int.Parse(numericUpDown_PriceHour.Text),
                PriceDeposit = int.Parse(numericUpDown_Deposit.Text),
                InStoke = true,
                AgeCategoryId = ageId
            };

            switch (selectGroup.SubcategoryInventory.NameSubcategoryInventory)
            {
                case "Велосипед":
                    Service.GetProviderInventory()
                        .AddInventory(inventory, new Bike
                        {
                            CountPeople = int.Parse(textBox_Add1.Text),
                            Weight = int.Parse(textBox_Add2.Text)
                        });
                    break;
                case "Самокат":
                    Service.GetProviderInventory()
                        .AddInventory(inventory, new Scooter
                        {
                            IsElectric = textBox_Add1.Text != @"0"
                        });
                    break;
                case "Скейтборд":
                    Service.GetProviderInventory()
                        .AddInventory(inventory, new Skateboard
                        {
                            TypeSkateboard = selectGroup.NameGroup
                        });
                    break;
                case "Ролики":
                    Service.GetProviderInventory()
                        .AddInventory(inventory, new RollerSkates
                        {
                            Size = textBox_Add1.Text,
                            CountWheel = int.Parse(textBox_Add2.Text),
                            IsDrag = textBox_Add3.Text != @"0"
                        });
                    break;
            }

            button_Exit_Click(sender, e);
        }

        /// <summary>
        /// ОБработчик события нажатия на кнопку "Закрыть".
        /// </summary>
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
            Form.UpdateSet(Service.GetProviderInventory().GetInventories());
            Form.Visible = true;
        }
    }
}