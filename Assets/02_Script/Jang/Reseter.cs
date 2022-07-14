using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseter : MonoBehaviour
{
    PlayerItem PI;
    // Start is called before the first frame update
    void Start()
    {
        PI = FindObjectOfType<PlayerItem>();
        PlayerPrefs.DeleteAll();
        PI.Money = 0;
        PI.Earthcore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
