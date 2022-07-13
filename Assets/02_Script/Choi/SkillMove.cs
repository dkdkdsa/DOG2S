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

        float pos = transform.rotation.y switch
        {

            0 => 2,
            180 => -2,
            _ => -2,

        };

        Collider2D col = Physics2D.OverlapBox(transform.position, new Vector2(1, 1), 0, LayerMask.GetMask("Enemy"));
        if (col != null)
        {

            Enemy_AI enemy = col.gameObject.GetComponent<Enemy_AI>();

            if (enemy.IsDie == false)
            {

                enemy.TakeDamage((int)Random.Range(playerMove.AttackPower * 2, playerMove.AttackPower * 2.5f), pos);
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);

            }
        }
    }

}
