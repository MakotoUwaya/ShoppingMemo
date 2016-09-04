using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMemo.Model
{
    public class Category : ModelBase
    {
        private Guid id;

        public Guid ID
        {
            get { return this.id; }
            set { this.SetProperty(ref this.id, value); }
        }

        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.SetProperty(ref this.name, value); }
        }

        private List<Item> itemList;

        public List<Item> ItemList
        {
            get { return this.itemList; }
            set { this.SetProperty(ref this.itemList, value); }
        }

        public Category(string categoryName) : this(categoryName, null)
        {            
        }

        public Category(string categoryName, List<Item> item)
        {
            id = Guid.NewGuid();
            name = categoryName;

            if (item == null) item = new List<Item>();
            itemList = item;
        }
    }
}
