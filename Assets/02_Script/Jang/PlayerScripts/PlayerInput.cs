using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    public GameObject window;
    NpcOpen NO;
    bool window_open;
    private void Awake()
    {
        window.SetActive(false);
        window_open = false;
<<<<<<< Updated upstream
    }
    // Start is called before the first frame update
    void Start()
    {
        NO = FindObjectOfType<NpcOpen>();
    }

    // Update is called once per frame
    void Update()
    {
=======
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
>>>>>>> Stashed changes
        if (NO.npc_possible == true && window_open == false && Input.GetKeyDown(KeyCode.E))
        {
            window.SetActive(true);
            window_open = true;
            window Window = window.GetComponent<window>();
            Window.Load();
        }
        else if (window_open == true && Input.GetKeyDown(KeyCode.E))
        {
            window.SetActive(false);
            window_open = false;
<<<<<<< Updated upstream
=======
            window.SetActive(false);
            window_open = false;
>>>>>>> Stashed changes
        }
        Out();
    }
    void Out()
    {
        if (-2 <= transform.position.x && transform.position.x <= 2 && transform.position.y <= -4)
        {
            SceneManager.LoadScene("JangWheeseSong 1");
        }
    }
}
