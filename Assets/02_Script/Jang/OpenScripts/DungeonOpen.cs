using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonOpen : MonoBehaviour
{
    public bool dungeon_possible;
    // Start is called before the first frame update
    void Start()
    {
        dungeon_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 1, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            dungeon_possible = true;
        }
        else
        {
            dungeon_possible = false;
        }
    }
}
