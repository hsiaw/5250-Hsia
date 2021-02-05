using System;
using SQLite;

namespace Mine.Models
{

    /// <summary>
    /// Items for the Characters and Monsters to use
    /// </summary>

    public class ItemModel
    {
        //The ID for the item
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        //The Display Text for the item
        public string Text { get; set; }

        //The description for the item
        public string Description { get; set; }

        //The Value of the Item +9 Damage
        public int Value { get; set; } = 0;
    }
}