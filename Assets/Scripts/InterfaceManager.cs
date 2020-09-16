using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;
using System.Globalization;
public class InterfaceManager : MonoBehaviour
{
    static InterfaceManager _instance;
    public CustomPanel firstPanel;
    GraphicRaycaster raycaster;
    public Transform panelsTransform;
    CustomPanel currentPanel;
    CustomPanel currentPrefab;
    public static InterfaceManager Instance
    {
        get
        {
            return _instance;
        }
    }

    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();

        //ShowScreen(firstPanel, null);
    }

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        _instance = this;
        raycaster = GetComponent<GraphicRaycaster>();
    }


    public void ShowScreen(CustomPanel prefab, object payload, bool isReturn = false, float durationTime = 0.5f)
    {
        if (currentPrefab == prefab)
            return;

        currentPrefab = prefab;
        CustomPanel go = Instantiate(prefab, panelsTransform);
        if(payload != null)
        {
            go.GetComponent<IPayloadReceiver>()?.ReceivedPayload(payload);
        }
        
        if (currentPanel != null)
        {
            raycaster.enabled = false;
            go.transform.SetAsFirstSibling();
            currentPanel.FadeToZero(durationTime, () =>
            {
                Destroy(currentPanel.gameObject);
                currentPanel = go;
                raycaster.enabled = true;
            });
        }
        else
        {
            currentPanel = go;
        }
        
    }

}
