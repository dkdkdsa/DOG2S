using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput2 : MonoBehaviour
{
    public GameObject window2;
    NpcOpen2 NO2;
    bool window2_open;
    private void Awake()
    {
        window2.SetActive(false);
        window2_open = false;
        window2_open = false;
        NO2 = FindObjectOfType<NpcOpen2>();
    }

    void Start()
    {

    }

    void Update()
    {
        Interaction();
    }
    void Interaction()
    {
        if (NO2.npc2_possible == true && window2_open == false && Input.GetKeyDown(KeyCode.E))
        {
            window2.SetActive(true);
            window2_open = true;
            window Window = window2.GetComponent<window>();
            Window.Load();
        }
        else if (window2_open == true && Input.GetKeyDown(KeyCode.E))
        {
            window2.SetActive(false);
            window2_open = false;
            window2.SetActive(false);
            window2_open = false;
        }
    }
}
