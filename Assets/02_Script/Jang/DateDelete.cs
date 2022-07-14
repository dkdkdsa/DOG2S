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
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            PI.Money += 9999;
            PI.Earthcore += 10;
        }
    }
}
