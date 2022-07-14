using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthcoreDecrease : MonoBehaviour
{
    ShopManager SM;
    // Start is called before the first frame update
    void Start()
    {
        SM = FindObjectOfType<ShopManager>();
        InvokeRepeating("Ed", 1, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Ed()
    {
        if (SM.TowerEnergy > 0)
        {
            SM.TowerEnergy -= 1;
        }
    }
}
