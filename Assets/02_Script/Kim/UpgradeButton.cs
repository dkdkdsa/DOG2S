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
            weapon++;//��ȭ��ġ ����
            switch (weapon)//��ȭ �ܰ躰 ��� ����
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
            item.Money -= currentCost;
        }
        else
        {
            StartCoroutine(NoticeVisible());// �ȳ����� �����ֱ�
        }

        PlayerPrefs.SetInt("Weapon", weapon);
        PlayerPrefs.SetInt("Cost", currentCost);

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
