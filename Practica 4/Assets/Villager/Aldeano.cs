using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : MonoBehaviour
{
    public enum VillagerType
    {
        Normal = 0,
        Pescador = 1,
        Herrero = 2,
    }
    public class VillagerBase : MonoBehaviour
    {
        public int Health = 100;
        public string Name = "Villager";
        public List<Item> Inventory;
        public Sprite Skin;
        public VillagerType Type = VillagerType.Normal;
        public Item SelectedItem;
        public List<Item> TradeItems;
        public VillagerBase()
        {

        }
        public VillagerBase(string _name, int _health, VillagerType _type, Sprite _skin)
        {
            Name = _name;
            Health = _health;
            Type = _type;
        }

        public virtual void SetName(string _name)
        {
            Name = _name;
        }
        public virtual void GetName(int _health)
        {
            Health = _health;
        }
        public virtual void SetType(VillagerType _type)
        {
            Type = _type;
        }
        public virtual void SetSkin(Sprite _skin)
        {
            Skin = _skin;
        }
        public virtual void SetSelectedItem(Item _intem)
        {
            SelectedItem = _intem;
        }
        public virtual void CreateInventory()
        {
            Inventory = new List<Item>();
        }
        public virtual void AddItemToInventory(Item _item)
        {
            Inventory.Add(_item);
        }
        public virtual string GetName()
        {
            return Name;
        }
        public virtual VillagerType GetType()
        {
            return Type;
        }
        public virtual Item GetSelectedItem()
        {
            return SelectedItem;
        }
        public virtual Item GetInventoryItem(int _index)
        {
            return Inventory[_index];
        }
        public virtual void CreateItemsToTrade()
        {
            TradeItems = new List<Item>();
        }
        public virtual List<Item> GetTradeItems()
        {
            return TradeItems;
        }
        public virtual Item Trade(Item Trade)
        {
            return new Item();
        }
    }
}