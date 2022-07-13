using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    float money;//��
    float damage = 1;
    int weapon;//���� ����
    float currentCost = 1500;// ��ȭ�� �ʿ��� ��
    [SerializeField] Text notice; // ������ �ȳ� �ؽ�Ʈ
    [SerializeField] Text costText; // ��ȭ��ư �ؽ�Ʈ
    [SerializeField] Text damageText; //���ݷ� �ؽ�Ʈ
    [SerializeField] Text weaponText; //��ȭ ��ġ �ؽ�Ʈ
    private void Start()
    {
        damage = 1;//������ �ʱⰪ ����
        notice.gameObject.SetActive(false); // �ȳ� �ؽ�Ʈ �ʱⰪ �Ⱥ��̰�
        currentCost = PlayerPrefs.GetFloat("Cost"); //��ȭ�� �ʿ��� �� �ʱ⼳��
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
        if (money >= currentCost)
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
            money -= currentCost;
        }
        else
        {
            StartCoroutine(NoticeVisible());// �ȳ����� �����ֱ�
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
        costText.text = $"��ȭ : {currentCost}";
        weaponText.text = $"+{weapon}��";
        damageText.text = $"Damage : {damage}";
    }
    /// <summary>
    /// �ȳ����� �����ִ� �ڷ���
    /// </summary>
    /// <returns></returns>
    IEnumerator NoticeVisible()
    {
        notice.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        notice.gameObject.SetActive(false);
    }
}
