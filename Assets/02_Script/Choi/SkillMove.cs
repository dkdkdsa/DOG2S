using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMove : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private GameObject explosionEffect;

    private PlayerMove playerMove;

    void Awake()
    {
        
        playerMove = FindObjectOfType<PlayerMove>();

    }

    float knockBackPos;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        Collider2D col = Physics2D.OverlapBox(transform.position, new Vector2(1, 1), 0, LayerMask.GetMask("Enemy"));

        if (col)
        {

            Enemy_AI enemy = col.gameObject.GetComponent<Enemy_AI>();
            enemy.TakeDamage(Random.Range(20, 30), playerMove.KnockBackPos);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }

    }

}
