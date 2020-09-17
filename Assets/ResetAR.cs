using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ResetAR : MonoBehaviour
{
    void Start()
    {
        var arSession = GetComponent<ARSession>();
        arSession.Reset();
    }



}
