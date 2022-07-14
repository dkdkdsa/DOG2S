using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    [SerializeField] private float value;

    private Rigidbody2D player_rigidbody;

    void Awake()
    {
        
        player_rigidbody = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {

        Artificial_Gravity();

    }

    private void Artificial_Gravity()
    {

        player_rigidbody.velocity = new Vector2(player_rigidbody.velocity.x, player_rigidbody.velocity.y - value);

    }

}
