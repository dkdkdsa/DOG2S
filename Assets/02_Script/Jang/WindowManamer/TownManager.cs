using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownManager : MonoBehaviour
{
    public SpriteRenderer SP;
    public Sprite SP1;
    public Sprite SP2;
    public Sprite SP3;
    public Sprite SP4;
    public Sprite SP5;
    public Text button_text;
    public Text questString;
    public float step;
    public void OnClick()
    {
        step += 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (step)
        {
            case 0:
                questString.text = "여기는 마을회관입니다, E키를 눌러 창을 닫거나 건물로 들어가는 등, 여러 상호작용을 할 수 있습니다. 이제부터 마을의 시설에 대해 알려드리겠습니다.";
                SP.sprite = SP1;
                return;
            case 1:
                questString.text = "마을회관에서는 얼마든지 튜토리얼에 대한 설명을 들을 수 있습니다. 또한 안에는 우물이 존재하는데 우물은 자신이 가지고 있는 '어스코어'를 넣어 에너지로 전환하여 타워를 움직이게 해주는 타워의 심장입니다. 어스코어로 채운 에너지의 양에 따라 타워의 이동속도가 달라집니다.";
                SP.sprite = SP2;
                return;
            case 2:
                questString.text = "대장간에서는 자신의 무기를 강화하여 체력과 공격력을 올릴 수 있습니다. 강화할수록 가격이 비싸집니다.";
                SP.sprite = SP3;
                return;
            case 3:
                questString.text = "음식점에서는 여러 음식과 술을 구입하여 여러 버프를 얻을 수 있습니다. 음식은 체력과 공격력이 늘고, 술은 속도가 줄고 방어력이 늘어나며 비쌀수록 버프가 늘어나 술은 속도도 같이 늘어납니다. 버프는 던전에서 사망 시 효과가 사라집니다.";
                SP.sprite = SP4;
                return;
            case 4:
                questString.text = "마지막으로 던전은 사나운 몬스터들이 들끓는 곳입니다. 몬스터을 처리할 때마다 돈을 벌 수 있으며 던전을 한층 클리어 할때마다 어스코어를 얻을 수 있습니다.";
                SP.sprite = SP5;
                return;
            case 5:
                questString.text = "이제 설명이 끝났으니 모험을 즐겨주세요!";
                SP.sprite = null;
                return;
        }
    }
}
