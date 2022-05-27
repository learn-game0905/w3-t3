using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnhancedUI.EnhancedScroller;
using UnityEngine.UI;


public class AnimalCellView : EnhancedScrollerCellView
{
    public Text animalNameText;
    public void SetData(ScrollerData data)
    {
        animalNameText.text = data.animalName;
    }
}

