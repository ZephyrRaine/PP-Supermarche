using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMainPrefab : MonoBehaviour
{
    public Transform toFollow;

    // Update is called once per frame
    void Update()
    {
        if(toFollow != null)
        {
            transform.position = toFollow.position;
            transform.rotation = toFollow.rotation;
        }
    }
}