using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class AddHandle : MonoBehaviour
{
    private Button addBtn;
    private GameObject itemParent;
    private GameObject[] itemBags;
    public GameObject prefab;

    void Start()
    {
        itemBags = GameObject.FindGameObjectsWithTag("ItemBag");
        itemParent = GameObject.FindWithTag("ItemParent");
        addBtn = GameObject.FindWithTag("btnAdd").GetComponent<Button>();
        addBtn.onClick.AddListener(AddItem);
    }

    public void AddItem()
    {
        if (itemParent.transform.childCount < 18)
        {
            try
            {
                Instantiate(itemBags[Random.Range(0 , itemBags.Length)] , itemParent.transform);    
            }
            catch (Exception e)
            {
                if (prefab != null)
                {
                    Instantiate(prefab, itemParent.transform);
                }
            }   
        }
    }
    
}
