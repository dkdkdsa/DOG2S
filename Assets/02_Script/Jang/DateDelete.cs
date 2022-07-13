using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateDelete : MonoBehaviour
{
    PlayerItem PI;
    void Start()
    {
        PI = FindObjectOfType<PlayerItem>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PI.Earthcore = 100;
            PlayerPrefs.DeleteAll();
            gameObject.GetComponent<DateDelete>().enabled = false;
        }
    }
}
