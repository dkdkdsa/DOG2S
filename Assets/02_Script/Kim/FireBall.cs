using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float damage = 40f;

    private PlayerMove playerMove;
    private PlayerManager playerManager;
    private bool isDie;

    private void Awake()
    {
        
        playerManager = FindObjectOfType<PlayerManager>();
        playerMove = FindObjectOfType<PlayerMove>();

    }

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        if(!isDie && Physics2D.OverlapBox(transform.position, new Vector2(1.8f, 1f), 0, LayerMask.GetMask("Player")) && playerMove.IsDie == false && playerMove.IsDash == false)
        {


            isDie = true;
            playerManager.TakeDamage(damage);
            Push();

        }

    }

    void Push()
    {
        GetComponent<PooledObj>().Push();
    }
}
