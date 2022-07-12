using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLoader : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject stageBox;
    [SerializeField] private Camera main_Camear;
    [SerializeField] private UI_Move obj;
    [SerializeField] private UI_Move obj_Scene;

    private Stage[] stages;

    void Awake()
    {
        
        stages = stageBox.GetComponentsInChildren<Stage>();

    }

    void Start()
    {

        Load();

    }

    // Update is called once per frame
    void Update()
    {

       // LoadNext();

    }

    public void Load()
    {

        int count = PlayerPrefs.GetInt("Stage");

        player.transform.position = stages[count].transform.position;
        main_Camear.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

    }

    public void LocdScenes()
    {

        obj_Scene.Lode(true);

        PlayerPrefs.SetInt("Stage", 0);

    }

    public void LoadNext()
    {
        int count = PlayerPrefs.GetInt("Stage");

        if(count == 9)
        {

            LocdScenes();

        }
        else
        {

            obj.transform.position = new Vector2(obj.transform.position.x + 1960 * 2, obj.transform.position.y);
            player.transform.position = stages[count + 1].transform.position;
            main_Camear.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
            PlayerPrefs.SetInt("Stage", count + 1);
            obj.Lode(true);

        }

    }

}
