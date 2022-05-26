using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropItem : MonoBehaviour, IBeginDragHandler , IDragHandler, IEndDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform reactTransform;
    private CanvasGroup canvasGroup;
    public GameObject[] listItemDrop;
    public GameObject[] listItemBag;
    public GameObject[] listBag;

    private void Awake()
    {
        reactTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        listItemDrop = GameObject.FindGameObjectsWithTag("Finish");
        listItemBag = GameObject.FindGameObjectsWithTag("Item");
        listBag = GameObject.FindGameObjectsWithTag("ItemBag");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.7f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1;
        for (int i = 0; i < listItemDrop.Length; i++)
        {
            if (Vector2.Distance(eventData.pointerDrag.transform.position, listItemDrop[i].transform.position) < 30 )
            {
                transform.position = listItemDrop[i].transform.position;
            }
        }

        for (int i = 0; i < listItemBag.Length; i++)
        {
            if (Vector2.Distance(eventData.pointerDrag.transform.position, listItemBag[i].transform.position) < 20)
            {
                transform.position = listItemBag[i].transform.position;
            }
        }

        for (int i = 0; i < listBag.Length; i++)
        {
            if (eventData.pointerDrag.transform.position == listBag[i].transform.position)
            {
                
            }
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("drop item");
    }
}
