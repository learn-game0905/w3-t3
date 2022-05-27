using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveHandle : MonoBehaviour
{
    public Button btnRemove;
    private GameObject[] itemBags;
    private GameObject itemContainer;
    
    void Start()
    {
        itemContainer = GameObject.FindWithTag("ItemParent");
        itemBags = GameObject.FindGameObjectsWithTag("ItemBag");
        if (btnRemove != null)
        {
            btnRemove.onClick.AddListener(RemoveItem);
        }
    }

    private void RemoveItem()
    {
        int childCount = itemContainer.transform.childCount;
        if (childCount > 0)
        {
            Destroy(itemContainer.transform.GetChild(childCount - 1).gameObject);
        }
    }
}
