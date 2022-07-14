using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MooneyManager : MonoBehaviour
{
    PlayerItem PI;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        PI = FindObjectOfType<PlayerItem>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "µ· : " + PI.Money;
    }
}
