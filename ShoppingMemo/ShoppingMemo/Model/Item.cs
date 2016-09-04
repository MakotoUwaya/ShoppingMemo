using System;

namespace ShoppingMemo.Model
{
    /// <summary>
    /// 購入対象アイテム
    /// </summary>
    public class Item : ModelBase
    {
        private Guid id;
        /// <summary>
        /// アイテムを一意に判別するためのID
        /// </summary>
        public Guid ID
        {
            get { return this.id; }
            set { this.SetProperty(ref this.id, value); }
        }


        private string name;
        /// <summary>
        /// アイテムの名前
        /// </summary>
        public string Name
        {
            get { return name; }
            set { this.SetProperty(ref this.name, value); }
        }

        private bool isFinished;
        /// <summary>
        /// 購入が完了したか
        /// </summary>
        public bool IsFinished
        {
            get { return this.isFinished; }
            set { this.SetProperty(ref this.isFinished, value); }
        }

        // TODO: 色のプロパティを持つ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="itemName">アイテムの名前</param>
        public Item(string itemName)
        {
            ID = new Guid();
            this.Name = itemName;
        }
    }
}
