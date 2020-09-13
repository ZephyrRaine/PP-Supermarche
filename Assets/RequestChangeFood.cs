using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestChangeFood : MonoBehaviour
{
    FoodDisplayer _fd;
    FoodDisplayer fd
    {
        get
        {
            if(_fd == null)
                _fd = FindObjectOfType<FoodDisplayer>();
            return _fd;
        }
    }
    public void Change(int offset)
    {
        fd?.ChangeCurrentFood(offset);
    }
}
