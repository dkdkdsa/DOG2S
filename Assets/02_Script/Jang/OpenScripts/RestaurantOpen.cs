using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantOpen : MonoBehaviour
{
    public bool restaurant_possible;
    // Start is called before the first frame update
    void Start()
    {
        restaurant_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapBox(transform.position, new Vector2(1.3f, 1.3f), 0, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            restaurant_possible = true;
        }
        else
        {
            restaurant_possible = false;
        }
    }
}
