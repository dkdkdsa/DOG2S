using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ClearUI : MonoBehaviour
{

    [SerializeField] private Transform image;
    [SerializeField] private PlayerMove move;

    public void Show()
    {

        image.gameObject.SetActive(true);
        image.DOScale(1, 1f).SetEase(Ease.OutBounce);

    }

    public void Disable()
    {

        image.DOScale(0, 0.5f).SetEase(Ease.OutBounce)
        .OnComplete(() =>
        {

            image.gameObject.SetActive(false);
            move.IsClear = false;

        });

    }

}
