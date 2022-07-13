using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    float money;//돈
    float damage = 1;
    int weapon;//무기 레벨
    float currentCost = 1500;// 강화에 필요한 돈
    [SerializeField] Text notice; // 돈부족 안내 텍스트
    [SerializeField] Text costText; // 강화버튼 텍스트
    [SerializeField] Text damageText; //공격력 텍스트
    [SerializeField] Text weaponText; //강화 수치 텍스트
    private void Start()
    {
        damage = 1;//데미지 초기값 설정
        notice.gameObject.SetActive(false); // 안내 텍스트 초기값 안보이게
        currentCost = PlayerPrefs.GetFloat("Cost"); //강화에 필요한 돈 초기설정
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
        if (money >= currentCost)
        {
            weapon++;//강화수치 증가
            switch (weapon)//강화 단계별 비용 증가
            {
                case 0:
                    currentCost = 2000;
                    break;
                case 1:
                    currentCost = 6000;
                    break;
                case 2:
                    currentCost = 10000;
                    break;
                case 3:
                    currentCost = 14000;
                    break;
                case 4:
                    currentCost = 20000;
                    break;
                case 5:
                    currentCost = 30000;
                    break;
                default:
                    break;
            }
            money -= currentCost;
        }
        else
        {
            StartCoroutine(NoticeVisible());// 안내문구 보여주기
        }
        PlayerPrefs.SetInt("Weapon", weapon);
        PlayerPrefs.SetFloat("Cost", currentCost);
        switch (weapon)
        {
            case 0:
                damage = 1;
                break;
            case 1:
                damage = 2;
                break;
            case 2:
                damage = 3;
                break;
            case 3:
                damage = 5;
                break;
            case 4:
                damage = 7;
                break;
            case 5:
                damage = 10;
                break;
            default:
                break;
        }
        costText.text = $"강화 : {currentCost}";
        weaponText.text = $"+{weapon}강";
        damageText.text = $"Damage : {damage}";
    }
    /// <summary>
    /// 안내문구 보여주는 코루팅
    /// </summary>
    /// <returns></returns>
    IEnumerator NoticeVisible()
    {
        notice.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        notice.gameObject.SetActive(false);
    }
}
