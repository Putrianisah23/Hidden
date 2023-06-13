using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hovering : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject HoverBased;
    public GameObject HoverPanel;    
    
    public void OnPointerEnter (PointerEventData eventData)
    {
        HoverBased.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverPanel.SetActive(true);
    }
}