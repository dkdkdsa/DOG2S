using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float damage = 40f;

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    void Push()
    {
        GetComponent<PooledObj>().Push();
    }
}
