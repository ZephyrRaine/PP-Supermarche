using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FoodDisplayer : MonoBehaviour
{
    public TMP_Text foodTitle;
    int current = 0;
    private void Awake()
    {
        foodTitle = GameObject.FindGameObjectWithTag("foodTitle").GetComponent<TMP_Text>();
        ChangeCurrentFood(0);
    }

    public void ChangeCurrentFood(int offset)
    {
        current += offset;
        if (current < 0)
            current = 2;
        if (current > 2)
            current = 0;

        foreach (Transform t in transform)
        {
            t.gameObject.SetActive(t.GetSiblingIndex() == current);
        }

        foodTitle.text = transform.GetChild(current).name;
    }

}
