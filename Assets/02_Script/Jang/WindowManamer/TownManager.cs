using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownManager : MonoBehaviour
{
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
                questString.text = "����� ����ȸ���Դϴ�, EŰ�� ���� â�� �ݰų� �ǹ��� ���� ��, ���� ��ȣ�ۿ��� �� �� �ֽ��ϴ�. �������� ������ �ü��� ���� �˷��帮�ڽ��ϴ�.";
                return;
            case 1:
                questString.text = "���尣������ �ڽ��� ���⸦ ��ȭ�Ͽ� ü�°� ���ݷ��� �ø� �� �ֽ��ϴ�. ��ȭ�Ҽ��� ������ ������ϴ�.";
                return;
            case 2:
                questString.text = "������������ ���� ���İ� ���� �����Ͽ� ���� ������ ���� �� �ֽ��ϴ�. ������ ü�°� ���ݷ��� �ð�, ���� �ӵ��� �ٰ� ������ �þ�� ��Ҽ��� ������ �þ ���� �ӵ��� ���� �þ�ϴ�. ������ �������� ��� �� ȿ���� ������ϴ�.";
                return;
            case 3:
                questString.text = "�칰�� �ڽ��� ������ �ִ� '��ھ�'�� �־� �������� ��ȯ�Ͽ� Ÿ���� �����̰� ���ִ� Ÿ���� �����Դϴ�. ��ھ�� ä�� �������� �翡 ���� Ÿ���� �̵��ӵ��� �޶����ϴ�.";
                return;
            case 4:
                questString.text = "���������� ������ �糪�� ���͵��� ����� ���Դϴ�. ������ ó���� ������ ���� �� �� ������ ������ ���� Ŭ���� �Ҷ����� ��ھ ���� �� �ֽ��ϴ�.";
                return;
            case 5:
                questString.text = "���� ������ �������� ������ ����ּ���!";
                return;
        }
    }
}
