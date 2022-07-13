using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthcore1Manager : MonoBehaviour
{
    PlayerItem PI;
    ShopManager SM;
    public void OnClick_Input()
    {
        if (PI.Earthcore > 0 && SM.TowerEnergy < 81)
        {
            PI.Earthcore -= 1;
            SM.TowerEnergy += 20;
        }
        else { }
    }
    // Start is called before the first frame update
    void Start()
    {
        PI = FindObjectOfType<PlayerItem>();
        SM = FindObjectOfType<ShopManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
