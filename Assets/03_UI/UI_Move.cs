using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI_Move : MonoBehaviour
{

    [Tooltip("���� ��� ����")][SerializeField] private bool useLoop;
    [Tooltip("���� ���ڸ��� ���࿩��")][SerializeField] private bool awake;
    [Tooltip("������ ���� �ð�")][SerializeField] private float duration;
    [Tooltip("ȸ�� ����")][SerializeField] private float rotateAngle;
    [Tooltip("�����ð�")][SerializeField] private float delayTime;
    [Tooltip("������(-1 �̸� ���ѹݺ�)")][SerializeField] private int loops;
    [Tooltip("�̹�Ʈ �ױ�")][SerializeField] private string eventTag;
    [Tooltip("���� Ÿ��")][SerializeField] private LoopType loopType;
    [Tooltip("�ӵ� ��ȭ��")][SerializeField] private Ease ease;
    [Tooltip("������ Ÿ��")][SerializeField] private MoveType moveType;
    [Tooltip("������ ��ǥ ���� ��ǥ�ּ� ������")][SerializeField] private Vector2 value;
    [Tooltip("���������� ������Ʈ")][SerializeField] private GameObject moveObject;
    [Tooltip("�ε���ũ��Ʈ")][SerializeField] private UI_Load_Scripts scripts;

    private bool isLoadScripts;

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

            Lode(false);

        }

    }

    public void Lode(bool load)
    {

        isLoadScripts = load;

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

            if (scripts != null && isLoadScripts == true) scripts.Script_Loading();

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
