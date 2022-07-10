using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI_Move : MonoBehaviour
{

    [Tooltip("루프 사용 여부")][SerializeField] private bool useLoop;
    [Tooltip("시작 하자마자 실행여부")][SerializeField] private bool awake;
    [Tooltip("움직임 지속 시간")][SerializeField] private float duration;
    [Tooltip("지연시간")][SerializeField] private float delayTime;
    [Tooltip("루프수(-1 이면 무한반복)")][SerializeField] private int loops;
    [Tooltip("루프 타입")][SerializeField] private LoopType loopType;
    [Tooltip("속도 변화량")][SerializeField] private Ease ease;
    [Tooltip("최종 좌표(로컬 좌표)")][SerializeField] private Vector2 value;
    [Tooltip("움직여야할 오브젝트")][SerializeField] private GameObject moveObject;
    [Tooltip("이밴트 테그")][SerializeField] private string eventTag;

    public string EventTag => eventTag;


    // Start is called before the first frame update
    void Start()
    {
        if (awake)
        {
            if (useLoop) Move_Loop();
            else Move();
        }


    }

    public void Lode()
    {

        if (useLoop) Move_Loop();
        else Move();

    }

    public void Kill()
    {

        DOTween.Kill(this);

    }

    private void Move_Loop()
    {

        Sequence sequence = DOTween.Sequence()
        .Append(moveObject.transform.DOMove(value, duration))
        .SetEase(ease)
        .AppendInterval(delayTime)
        .OnStepComplete(() =>
        {



        })
        .SetLoops(loops, loopType);

    }

    private void Move()
    {

        Sequence sequence = DOTween.Sequence()
        .Append(moveObject.transform.DOMove(value, duration))
        .SetEase(ease)
        .OnComplete(() =>
        {


        });

    }

}
