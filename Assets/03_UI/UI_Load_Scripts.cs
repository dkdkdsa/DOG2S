using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class UI_Load_Scripts : ScriptableObject
{

    [SerializeField] private string scenes_name;
    [SerializeField] private Type type;

    private enum Type
    {

        LoadScenens,

        Move,


    }

    public void Script_Loading()
    {

        if(type == Type.LoadScenens)
        {

            SceneManager.LoadScene(scenes_name);
            Debug.Log(2);

        }
        else if(type == Type.Move)
        {

            UI_Move loadObj = GameObject.Find("Image").GetComponent<UI_Move>();

            loadObj.Lode(false);

        }

    }

}
