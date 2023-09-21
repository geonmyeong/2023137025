using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public int slotId;      //½½·Ô ¹øÈ£
    public int itemId;      //¾ÆÀÌÅÛ ¹øÈ£

    public void InitDummy(int slotId, int itemId)
    {
        this.slotId = slotId;
        this.itemId = itemId;
    }
}