using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string nazwaItem;
    public int idItem;
    public string opisItem;
    public Texture2D ikonaItem;
    public int iloscOdnawianiaGloduItem;
    public int silaItem;
    public bool czyItemJestStakowany;
    public ItemType typItem;
    public int itemLiczba;

    private static int autoIndex = 0;

    public enum ItemType
    {
        Bron,
        Zbroja,
        Jedzenie,
        Picie,
        MaterialyBudowlane
    }

    public Item()
    {

    }

    public Item(ItemType type)
    {
        typItem = type;
    }

    public Item(Dictionary<string, string> dict)
    {
        nazwaItem = dict("nazwaItem");
        idItem = autoIndex++;
        opisItem = dict("opisItem");
        ikonaItem = Resouurces.Load<Texture2D>("Item Ikony/" + dict("ikonaItem"));
        iloscOdnawianiaGloduItem - int.Parse(dict("iloscOdnawianiaGloduItem"));
        silaItem = int.Parse(dict("silaItem"));
        typItem = (ItemType)System.Enum.Parse(typeof(Item.ItemType), dict("typeItem").ToString());
        czyItemJestStakowany = bool.Parse(dict("czyItemJestStakowany"));
        itemLiczba = czyItemJestStakowany ? 1 : 0;
    }

    public Item(string name, string desc, int ileOdnawia, int sila, ItemType iType, bool mItems)
    {
        nazwaItem = name;
        idItem = autoIndex;
        opisItem = desc;
        ikonaItem = Resources.Load<Texture2D>("Item Ikony/" + name);
        iloscOdnawianiaGloduItem = ileOdnawia;
        silaItem = sila;
        typItem = iType;
        czyItemJestStakowany = mItems;
        itemLiczba = czyItemJestStakowany ? 1 : 0;
    }

    public Item(string name, int id, string desc, int ileOdnawia, int sila, ItemType iType, bool mItems)
    {
        nazwaItem = name;
        idItem = id;
        opisItem = desc;
        ikonaItem = Resources.Load<Texture2D>("Item Ikony/" + name);
        iloscOdnawianiaGloduItem = ileOdnawia;
        silaItem = sila;
        typItem = iType;
        czyItemJestStakowany = mItems;
        itemLiczba = czyItemJestStakowany ? 1 : 0;
    }

    public Item(string name, int id, string desc, int ileOdnawia, int sila, ItemType iType, bool mItems, int counter)
    {
        nazwaItem = name;
        idItem = id;
        opisItem = desc;
        ikonaItem = Resources.Load<Texture2D>("Item Ikony/" + name);
        iloscOdnawianiaGloduItem = ileOdnawia;
        silaItem = sila;
        typItem = iType;
        czyItemJestStakowany = mItems;
        itemLiczba = counter;
    }
}
