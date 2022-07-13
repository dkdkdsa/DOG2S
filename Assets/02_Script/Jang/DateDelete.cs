using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateDelete : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
            gameObject.GetComponent<DateDelete>().enabled = false;
        }
    }
}
