using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    float damage = 1;
    int weapon;//무기 레벨
    int currentCost = 1500;// 강화에 필요한 돈
    [SerializeField] Text notice; // 돈부족 안내 텍스트
    [SerializeField] Text costText; // 강화버튼 텍스트
    [SerializeField] Text damageText; //공격력 텍스트
    [SerializeField] Text weaponText; //강화 수치 텍스트
    [SerializeField] PlayerItem item;

    private void Start()
    {
        damage = 1;//데미지 초기값 설정
        notice.gameObject.SetActive(false); // 안내 텍스트 초기값 안보이게
        currentCost = PlayerPrefs.GetInt("Cost"); //강화에 필요한 돈 초기설정
        weapon = PlayerPrefs.GetInt("Weapon");
        damage = PlayerPrefs.GetFloat("Wapon_Damage");
        if (damage == 0) damage = 0;
        if (weapon == 0) weapon = 0; 
        if (currentCost == 0) currentCost = 2000;
        costText.text = $"강화 : {currentCost}";
        weaponText.text = $"+{weapon}강";
        damageText.text = $"Damage : {damage}";
        Debug.Log($"강화에 필요한 돈{currentCost}");
    }
    /// <summary>
    /// 버튼 클릭 이벤트
    /// </summary>
    public void UpgradeEvent()
    {
        Debug.Log("버튼눌림");

        Debug.Log(item.Money);

        if (item.Money >= currentCost)
        {
            item.Money -= currentCost;
            weapon++;//강화수치 증가

            currentCost = weapon switch
            {

                0 => 2000,
                1 => 10000,
                2 => 40000,
                3 => 100000,
                5 => 200000,
                _ => currentCost + 10000,

            };

            damage = weapon switch
            {

                0 => 2,
                1 => 3,
                2 => 4,
                3 => 5,
                4 => 6,
             _ => damage + 1,
            };

        }
        else
        {
            StartCoroutine(NoticeVisible());// 안내문구 보여주기
        }

        PlayerPrefs.SetInt("Weapon", weapon);
        PlayerPrefs.SetInt("Cost", currentCost);



        PlayerPrefs.SetFloat("Wapon_Damage", damage);
        costText.text = $"강화 : {currentCost}";
        weaponText.text = $"+{weapon}강";
        damageText.text = $"Damage : {damage}";
    }
    /// <summary>
    /// 안내문구 보여주는 코루틴
    /// </summary>
    /// <returns></returns>
    IEnumerator NoticeVisible()
    {
        notice.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        notice.gameObject.SetActive(false);
    }
}
