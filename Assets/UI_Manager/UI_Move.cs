using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI_Move : MonoBehaviour
{

    [SerializeField] private bool useLoop;

    // Start is called before the first frame update
    void Start()
    {

        if (useLoop) Move_Loop();
        else Move();

    }

    private void Move_Loop()
    {

        Sequence sequence = DOTween.Sequence();
        //.Append(transform.DOMove())

    }

    private void Move()
    {



    }

}
