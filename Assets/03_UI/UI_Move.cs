using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI_Move : MonoBehaviour
{

    [Tooltip("루프 사용 여부")][SerializeField] private bool useLoop;
    [Tooltip("시작 하자마자 실행여부")][SerializeField] private bool awake;
    [Tooltip("움직임 지속 시간")][SerializeField] private float duration;
    [Tooltip("회전 각도")][SerializeField] private float rotateAngle;
    [Tooltip("지연시간")][SerializeField] private float delayTime;
    [Tooltip("루프수(-1 이면 무한반복)")][SerializeField] private int loops;
    [Tooltip("이밴트 테그")][SerializeField] private string eventTag;
    [Tooltip("루프 타입")][SerializeField] private LoopType loopType;
    [Tooltip("속도 변화량")][SerializeField] private Ease ease;
    [Tooltip("움직임 타입")][SerializeField] private MoveType moveType;
    [Tooltip("움직일 좌표 현재 좌표애서 더해짐")][SerializeField] private Vector2 value;
    [Tooltip("움직여야할 오브젝트")][SerializeField] private GameObject moveObject;

    public string EventTag => eventTag;

    private enum MoveType
    {

        Move,

        Rotate,

    }

    // Start is called before the first frame update
    void Start()
    {
        if (awake)
        {

            Lode();

        }

    }

    public void Lode()
    {

        if (useLoop)
        {

            if (moveType == MoveType.Move) Move_Loop();
            else if (moveType == MoveType.Rotate) Rotate_Loop();

        }
        else
        {

            if(moveType == MoveType.Move) Move();
            else if(moveType == MoveType.Rotate) Rotate();

        }

    }

    public void Kill()
    {

        DOTween.Kill(this);

    }

    private void Move_Loop()
    {

        Sequence sequence = DOTween.Sequence()
        .Append(moveObject.transform.DOMove(new Vector2(moveObject.transform.position.x + value.x, moveObject.transform.position.y + value.y), duration))
        .SetEase(ease)
        .AppendInterval(delayTime)
        .OnStepComplete(() =>
        {



        })
        .SetLoops(loops, loopType);

    }

    private void Rotate_Loop()
    {

        Sequence sequence = DOTween.Sequence()
        .Append(moveObject.transform.DORotate(new Vector3(0, 0, rotateAngle), duration))
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
        .Append(moveObject.transform.DOMove(new Vector2(moveObject.transform.position.x + value.x, moveObject.transform.position.y + value.y), duration))
        .SetEase(ease)
        .OnComplete(() =>
        {


        });

    }

    private void Rotate()
    {

        Sequence sequence = DOTween.Sequence()
        .Append(moveObject.transform.DORotate(new Vector3(0, 0, rotateAngle), duration))
        .SetEase(ease)
        .OnComplete(() =>
        {



        });

    }

}
