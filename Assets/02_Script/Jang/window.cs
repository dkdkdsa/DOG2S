using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class window : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(0, 0);
        transform.DOScale(1, 1).SetEase(Ease.OutBounce);
        DOTween.Kill(this);
    }
        // Update is called once per frame
    void Update()
    {
        
    }

    public void Load() 
    {

        transform.localScale = new Vector2(0, 0);
        transform.DOScale(1, 1).SetEase(Ease.OutBounce);
        DOTween.Kill(this);

    }

}
