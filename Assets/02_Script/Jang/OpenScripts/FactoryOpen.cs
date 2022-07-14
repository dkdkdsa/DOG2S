using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryOpen : MonoBehaviour
{
    public bool factory_possible;
    // Start is called before the first frame update
    void Start()
    {
        factory_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapBox(transform.position, new Vector2(2f, 2f), 0, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            factory_possible = true;
        }
        else
        {
            factory_possible = false;
        }
    }
}
