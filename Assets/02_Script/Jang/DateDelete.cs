using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateDelete : MonoBehaviour
{
    PlayerItem PI;
    ShopManager SM;
    void Start()
    {
        PI = FindObjectOfType<PlayerItem>();
        SM = FindObjectOfType<ShopManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SM.TowerEnergy = 0;
            PI.Money = 99999;
            PI.Earthcore = 100;
            PlayerPrefs.DeleteAll();
            gameObject.GetComponent<DateDelete>().enabled = false;
        }
    }
}
