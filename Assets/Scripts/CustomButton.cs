using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerClickHandler
{
    public CustomPanel panelPrefab;
    public bool isReturn;
    public bool noTransition;
    public bool bypass;

    protected object payload;

    public virtual void LoadScreen()
    {
        Debug.Log(panelPrefab.name);
        if(noTransition)
        {
            InterfaceManager.Instance.ShowScreen(panelPrefab, payload, isReturn, 0f);
        }
        else
        {            
            InterfaceManager.Instance.ShowScreen(panelPrefab, payload, isReturn);
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(!bypass && panelPrefab != null)
        {
            LoadScreen();
        }
    }

}
