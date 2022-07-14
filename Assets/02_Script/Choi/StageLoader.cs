using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageLoader : MonoBehaviour
{

    [SerializeField] private PlayerMove player;
    [SerializeField] private GameObject stageBox;
    [SerializeField] private Camera main_Camear;
    [SerializeField] private UI_Move obj;
    [SerializeField] private UI_Move obj_Scene;
    [SerializeField] private ClearUI obj_Clear;
    [SerializeField] private Slider obj_Slider;
    [SerializeField] private ShowBuff obj_ShowBuff;

    private Stage[] stages;

    private int core;
    public int money;
    public int wapons;

    void Awake()
    {
        
        stages = stageBox.GetComponentsInChildren<Stage>();
        money = PlayerPrefs.GetInt("Money");
        core = PlayerPrefs.GetInt("Earthcore");

    }

    void Start()
    {

        Load();

        obj_Slider.maxValue = 100 + player.Buff_Hp;
        obj_Slider.value = obj_Slider.maxValue;
        obj_ShowBuff.Show();

    }

    public void Load()
    {

        int count = PlayerPrefs.GetInt("Stage");
        player.AttackPower = PlayerPrefs.GetFloat("Damage");
        player.Buff_Hp = PlayerPrefs.GetFloat("Buff_HP");
        player.Buff_Defance = PlayerPrefs.GetFloat("Buff_Defence");
        player.Buff_AttackPower = PlayerPrefs.GetFloat("Buff_AttackPower");
        player.Buff_Speed = PlayerPrefs.GetFloat("Buff_Speed");
        player.WaponAttackPower = PlayerPrefs.GetFloat("Wapon_Damage");
        
        if(player.AttackPower <= 0) player.AttackPower = 10;
        player.transform.position = stages[count].transform.position;
        main_Camear.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);       

    }

    public void LocdScenes()
    {

        int count = PlayerPrefs.GetInt("Stage");

        core = count switch
        {

            3 => 3,
            6 => 3,
            9 => 3,
            _ => 1,

        };

        PlayerPrefs.SetInt("Earthcore", core);
        PlayerPrefs.SetInt("Wapons", wapons);
        PlayerPrefs.SetInt("Money", money);
        obj_Clear.Disable();
        obj_Scene.Lode(true);
        PlayerPrefs.SetInt("Stage", 0);

    }

    public void LoadNext()
    {
        int count = PlayerPrefs.GetInt("Stage");
        obj_Clear.Disable();

        if(count == 9)
        {


            LocdScenes();

        }
        else
        {

            obj_Slider.maxValue = 100 + player.Buff_Hp;
            obj_Slider.value = obj_Slider.maxValue;
            obj.transform.position = new Vector2(obj.transform.position.x + 1960 * 2, obj.transform.position.y);
            player.transform.position = stages[count + 1].transform.position;
            main_Camear.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
            PlayerPrefs.SetInt("Stage", count + 1);
            obj.Lode(true);

        }

    }

}
