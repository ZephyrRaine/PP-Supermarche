using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FoodDisplayer : MonoBehaviour
{
    public TMP_Text foodTitle;
    int current = 0;
    public static bool isActive = false;
    private void Awake()
    {
        foodTitle = GameObject.FindGameObjectWithTag("foodTitle").GetComponent<TMP_Text>();
        foreach(Transform t in GameObject.FindGameObjectWithTag("fleches").transform)
        {
            t.gameObject.SetActive(true);
        }
        ChangeCurrentFood(0);
        isActive = true;
    }

    private void OnDisable()
    {
        isActive = false;
    }

    public void ChangeCurrentFood(int offset)
    {
        current += offset;
        if (current < 0)
            current = 2;
        if (current > 2)
            current = 0;

        for(int i = 0; i < transform.childCount; i++)
        {
            Debug.Log("going through transform " + i);
            transform.GetChild(i).gameObject.SetActive(i == current);
        }

        foodTitle.text = transform.GetChild(current).name;
    }

}
