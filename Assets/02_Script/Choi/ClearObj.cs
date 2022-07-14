using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearObj : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            PlayerMove playerMove = collision.GetComponent<PlayerMove>();
            playerMove.IsClear = true;
            ClearUI clear = FindObjectOfType<ClearUI>();
            clear.Show();

        }

    }

}
