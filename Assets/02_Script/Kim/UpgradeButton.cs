using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    float damage = 1;
    int weapon;//���� ����
    int currentCost = 1500;// ��ȭ�� �ʿ��� ��
    [SerializeField] Text notice; // ������ �ȳ� �ؽ�Ʈ
    [SerializeField] Text costText; // ��ȭ��ư �ؽ�Ʈ
    [SerializeField] Text damageText; //���ݷ� �ؽ�Ʈ
    [SerializeField] Text weaponText; //��ȭ ��ġ �ؽ�Ʈ
    [SerializeField] PlayerItem item;

    private void Start()
    {
        damage = 1;//������ �ʱⰪ ����
        notice.gameObject.SetActive(false); // �ȳ� �ؽ�Ʈ �ʱⰪ �Ⱥ��̰�
        currentCost = PlayerPrefs.GetInt("Cost"); //��ȭ�� �ʿ��� �� �ʱ⼳��
        weapon = PlayerPrefs.GetInt("Weapon");
        damage = PlayerPrefs.GetFloat("Wapon_Damage");
        if (damage == 0) damage = 0;
        if (weapon == 0) weapon = 0; 
        if (currentCost == 0) currentCost = 2000;
        costText.text = $"��ȭ : {currentCost}";
        weaponText.text = $"+{weapon}��";
        damageText.text = $"Damage : {damage}";
        Debug.Log($"��ȭ�� �ʿ��� ��{currentCost}");
    }
    /// <summary>
    /// ��ư Ŭ�� �̺�Ʈ
    /// </summary>
    public void UpgradeEvent()
    {
        Debug.Log("��ư����");

        Debug.Log(item.Money);

        if (item.Money >= currentCost)
        {
            item.Money -= currentCost;
            weapon++;//��ȭ��ġ ����

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
            StartCoroutine(NoticeVisible());// �ȳ����� �����ֱ�
        }

        PlayerPrefs.SetInt("Weapon", weapon);
        PlayerPrefs.SetInt("Cost", currentCost);



        PlayerPrefs.SetFloat("Wapon_Damage", damage);
        costText.text = $"��ȭ : {currentCost}";
        weaponText.text = $"+{weapon}��";
        damageText.text = $"Damage : {damage}";
    }
    /// <summary>
    /// �ȳ����� �����ִ� �ڷ�ƾ
    /// </summary>
    /// <returns></returns>
    IEnumerator NoticeVisible()
    {
        notice.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        notice.gameObject.SetActive(false);
    }
}
