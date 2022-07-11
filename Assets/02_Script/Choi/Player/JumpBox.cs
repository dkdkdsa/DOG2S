using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBox : MonoBehaviour
{

    private bool isGround;

    public bool IsGround()
    {

        return isGround;

    }

    private void Update()
    {

        //Debug.Log(isGround);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log(collision.name);
        isGround = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        isGround = false;
    }

}
