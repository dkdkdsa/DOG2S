using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    public GameObject SmithyOpen_window;
    public GameObject TownOpen_window;
    DungeonOpen DO;
    SmithyOpen SO;
    TownOpen TO;
    WellOpen WO;
    bool SmithyOpen_window_open;
    bool TownOpen_window_open;
    private void Awake()
    {
        SmithyOpen_window.SetActive(false);
        SmithyOpen_window_open = false;
        TownOpen_window_open = false;
        DO = FindObjectOfType<DungeonOpen>();
        TO = FindObjectOfType<TownOpen>();
        SO = FindObjectOfType<SmithyOpen>();
        WO = FindObjectOfType<WellOpen>();
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
        if (DO.dungeon_possible == true && Input.GetKeyDown(KeyCode.E))
        if (NO.npc_possible == true && window_open == false && Input.GetKeyDown(KeyCode.E))
        {
            window.SetActive(true);
            window_open = true;
            window Window = window.GetComponent<window>();
            Window.Load();
        }
        else if (window_open == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("���尣 ��");
            SmithyOpen_window.SetActive(false);
            SmithyOpen_window_open = false;
            window.SetActive(false);
            window_open = false;
        }
        Out();
    }
    void Out()
    {
        if (-2 <= transform.position.x && transform.position.x <= 2 && transform.position.y <= -4)
        {
            Debug.Log("����ȸ�� ����");
            TownOpen_window.SetActive(true);
            TownOpen_window_open = true;
            window Window = TownOpen_window.GetComponent<window>();
            Window.Load();
        }
        else if (TownOpen_window_open == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("����ȸ�� ����");
            TownOpen_window.SetActive(false);
            TownOpen_window_open = false;
            SceneManager.LoadScene("JangWheeseSong 1");
        }
    }
}
