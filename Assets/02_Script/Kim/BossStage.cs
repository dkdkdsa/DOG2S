using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStage : MonoBehaviour
{
    Collider2D _collider2D;
    [SerializeField] GameObject boss;
    [SerializeField] Camera _camera;
    [SerializeField] Enemy_AI aI;
    private void Start()
    {


    }
    private void Update()
    {
        _collider2D = Physics2D.OverlapBox(transform.position, new Vector2(47, 14.5f), 0, LayerMask.GetMask("Player"));

        if (_collider2D != null)//������ �ڽ��� ���� �����Ǹ�
        {
            while (_camera.orthographicSize < 8)
            {
                _camera.orthographicSize += (Time.deltaTime * 0.1f);
            }
            _camera.orthographicSize = 8;
        }
        else//�ƴϸ�
        {
            _camera.orthographicSize = 7;
        }
    }
}
