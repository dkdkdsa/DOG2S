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
    bool SmithyOpen_window_open;
    bool TownOpen_window_open;
    private void Awake()
    {
        SmithyOpen_window.SetActive(false);
        SmithyOpen_window_open = false;
        TownOpen_window_open = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        DO = FindObjectOfType<DungeonOpen>();
        SO = FindObjectOfType<SmithyOpen>();
        TO = FindObjectOfType<TownOpen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DO.dungeon_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("���� ����");
        }
        if (SO.smithy_possible == true && SmithyOpen_window_open == false && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("���尣 ����");
            SmithyOpen_window.SetActive(true);
            SmithyOpen_window_open = true;
            window Window = SmithyOpen_window.GetComponent<window>();
            Window.Load();
        }
        else if (SmithyOpen_window_open == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("���尣 ��");
            SmithyOpen_window.SetActive(false);
            SmithyOpen_window_open = false;
            gameObject.GetComponent<window>().enabled = false;
        }
        if (TO.town_possible == true && TownOpen_window_open == false && Input.GetKeyDown(KeyCode.E))
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
        }
    }
}
