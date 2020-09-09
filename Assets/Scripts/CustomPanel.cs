using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class CustomPanel : MonoBehaviour
{
    Graphic[] graphics;

    private void Start() {
        graphics = GetComponentsInChildren<Graphic>(true);
    }


    public void FadeToZero(float duration, System.Action callback)
    {
        Sequence mySequence = DOTween.Sequence();
        foreach(Graphic g in graphics)
        {
            mySequence.Join(g.DOFade(0,duration));
        }
        mySequence.OnComplete(()=>callback());
    }
}
