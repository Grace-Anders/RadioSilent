
namespace RadioSilent
{
    public class Item
    {
        public string ItemName;
        public string ItemDescription;
        public int ItemWorth;


        public Item() { }
        public Item(string itemname, string itemdescription, int itemworth)
        {
            ItemName = itemname;
            ItemDescription = itemdescription;
            ItemWorth = itemworth;
        }
    }
}
