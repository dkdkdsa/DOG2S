using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownManager : MonoBehaviour
{
    public Text button_text;
    public Text questName;
    public Text questString;
    public bool quest;
    public bool mission_clear;
    public enum State
    {
        quest1,
        quest2,
        quest3,
        quest4,
        quest5,
        quest6,
        quest7,
    }
    public State state;
    public void OnClick()
    {
        if (quest == false)
        {
            quest = true;
            button_text.text = "수락완료";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        state = State.quest1;
        quest = false;
        mission_clear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            mission_clear = true;
        }
        if (mission_clear == true)
        {
            quest = false;
            mission_clear = false;
            button_text.text = "수락";
            switch (state)
            {
                case State.quest1:
                    state = State.quest2;
                    return;
                case State.quest2:
                    state = State.quest3;
                    return;
                case State.quest3:
                    state = State.quest4;
                    return;
                case State.quest4:
                    state = State.quest5;
                    return;
                case State.quest5:
                    state = State.quest6;
                    return;
                case State.quest6:
                    state = State.quest7;
                    return;
            }

        }
        switch (state)
        {
            case State.quest1:
                questName.text = "퀘스트 1";
                questString.text = "퀘스트 1에 대한 설명";
                return;
            case State.quest2:
                questName.text = "퀘스트 2";
                questString.text = "퀘스트 2에 대한 설명";
                return;
            case State.quest3:
                questName.text = "퀘스트 3";
                questString.text = "퀘스트 3에 대한 설명";
                return;
            case State.quest4:
                questName.text = "퀘스트 4";
                questString.text = "퀘스트 4에 대한 설명";
                return;
            case State.quest5:
                questName.text = "퀘스트 5";
                questString.text = "퀘스트 5에 대한 설명";
                return;
            case State.quest6:
                questName.text = "퀘스트 6";
                questString.text = "퀘스트 6에 대한 설명";
                return;
            case State.quest7:
                questName.text = "퀘스트 7";
                questString.text = "퀘스트 7에 대한 설명";
                return;
        }
    }
}
