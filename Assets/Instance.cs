using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public FollowMainPrefab otherPrefab;
    public void InstantiatePrefab()
    {
        var instance = Instantiate(otherPrefab, transform.parent);
        instance.toFollow = this.transform;
    }
}