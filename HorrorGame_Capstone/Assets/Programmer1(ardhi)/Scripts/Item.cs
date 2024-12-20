using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType {
        HealthPotion,
        ManaPotion,
        Coin
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite() {
        switch (itemType)
        {
            default:
            case ItemType.HealthPotion : return ItemAssets.Instance.healthPotionSprite;
            case ItemType.ManaPotion : return ItemAssets.Instance.manaPotionSprite;
            case ItemType.Coin : return ItemAssets.Instance.coinSprite;
        }
    }
}
