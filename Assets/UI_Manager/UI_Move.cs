using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI_Move : MonoBehaviour
{

    [Tooltip("���� ��� ����")][SerializeField] private bool useLoop;
    [Tooltip("���� ���ڸ��� ���࿩��")][SerializeField] private bool awake;
    [Tooltip("������ ���� �ð�")][SerializeField] private float duration;
    [Tooltip("�����ð�")][SerializeField] private float delayTime;
    [Tooltip("������(-1 �̸� ���ѹݺ�)")][SerializeField] private int loops;
    [Tooltip("���� Ÿ��")][SerializeField] private LoopType loopType;
    [Tooltip("�ӵ� ��ȭ��")][SerializeField] private Ease ease;
    [Tooltip("���� ��ǥ(���� ��ǥ)")][SerializeField] private Vector2 value;
    [Tooltip("���������� ������Ʈ")][SerializeField] private GameObject moveObject;
    [Tooltip("�̹�Ʈ �ױ�")][SerializeField] private string eventTag;

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
