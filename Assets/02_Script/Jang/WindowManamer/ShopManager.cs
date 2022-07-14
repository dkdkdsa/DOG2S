using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    CamereMove CM;
    Shake shake;
    public float TowerEnergy;
    // Start is called before the first frame update
    void Start()
    {
        CM = FindObjectOfType<CamereMove>();
        shake = FindObjectOfType<Shake>();
        TowerEnergy = PlayerPrefs.GetFloat("TowerEarthcore", 0);

        int i = PlayerPrefs.GetInt("Start");
        if (i == 0)
        {

            PlayerPrefs.SetInt("Start", 1);
            Debug.Log(234);
            TowerEnergy = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("TowerEarthcore", TowerEnergy);
        if (TowerEnergy >= 90)
        {
            CM.speed = 3;
            shake.shake = 0.05f;
        }
        else if (TowerEnergy >= 60)
        {
            CM.speed = 2;
            shake.shake = 0.05f;
        }
        else if (TowerEnergy >= 30)
        {
            CM.speed = 1;
            shake.shake = 0.05f;
        }
        else if (TowerEnergy >= 1)
        {
            CM.speed = 0.4f;
            shake.shake = 0.05f;
        }
        else
        {
            CM.speed = 0;
            shake.shake = 0;
        }
    }
}
