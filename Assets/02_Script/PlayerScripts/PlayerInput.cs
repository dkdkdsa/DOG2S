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
        {
            Debug.Log("던전 입장");
        }
        if (SO.smithy_possible == true && SmithyOpen_window_open == false && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("대장간 오픈");
            SmithyOpen_window.SetActive(true);
            SmithyOpen_window_open = true;
            window Window = SmithyOpen_window.GetComponent<window>();
            Window.Load();
        }
        else if (SmithyOpen_window_open == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("대장간 끔");
            SmithyOpen_window.SetActive(false);
            SmithyOpen_window_open = false;
        }
        if (TO.town_possible == true && TownOpen_window_open == false && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("마을회관 입장");
            TownOpen_window.SetActive(true);
            TownOpen_window_open = true;
            window Window = TownOpen_window.GetComponent<window>();
            Window.Load();
        }
        else if (TownOpen_window_open == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("마을회관 퇴장");
            TownOpen_window.SetActive(false);
            TownOpen_window_open = false;
        }
    }
}
