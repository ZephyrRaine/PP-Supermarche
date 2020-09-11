using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public GameObject otherPrefab;
    public void InstantiatePrefab()
    {
        var mainCam = Camera.main.transform;
        var instance = Instantiate(otherPrefab, mainCam.position + mainCam.forward * 1f, Quaternion.identity, mainCam);
    }
}