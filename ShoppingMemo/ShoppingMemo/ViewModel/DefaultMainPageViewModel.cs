using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingMemo.Model;

namespace ShoppingMemo.ViewModel
{
    public class DefaultMainPageViewModel : ModelBase
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.SetProperty(ref this.name, value); }
        }

        private List<Category> categoryList;

        public List<Category> CategoryList
        {
            get { return this.categoryList; }
            set { this.SetProperty(ref this.categoryList, value); }
        }


        public DefaultMainPageViewModel()
        {
            this.categoryList = new List<Category>();
            this.categoryList.Add(new Category("Shop",
                new List<Item>() { new Item("Something eat.") }));

            this.Name = "Sample";
        }


    }
}
