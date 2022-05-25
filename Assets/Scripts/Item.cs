using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Item : MonoBehaviour
{
    public DataItem dateItem;
    public TMP_Text quantityItem;
    public Image imgItem;

    void Start()
    {
        quantityItem.text = dateItem.quantityItem.ToString();
        imgItem.sprite = dateItem.imgItem;
    }
    
}
