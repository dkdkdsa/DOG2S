using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownOpen : MonoBehaviour
{
    public bool town_possible;
    // Start is called before the first frame update
    void Start()
    {
        town_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 0.7f, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            town_possible = true;
        }
        else
        {
            town_possible = false;
        }
    }
}
