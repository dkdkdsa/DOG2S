using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{

    [SerializeField] private AudioSource m_AudioSource;

    public GameObject window;
    NpcOpen NO;
    bool window_open;
    private void Awake()
    {
        window.SetActive(false);
        window_open = false;
        window_open = false;
        NO = FindObjectOfType<NpcOpen>();
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
        if (NO.npc_possible == true && window_open == false && Input.GetKeyDown(KeyCode.E))
        {
            window.SetActive(true);
            window_open = true;
            m_AudioSource.Play();
            window Window = window.GetComponent<window>();
            Window.Load();
        }
        else if (window_open == true && Input.GetKeyDown(KeyCode.E))
        {
            window.SetActive(false);
            window_open = false;
            window.SetActive(false);
            window_open = false;
        }
    }
}
