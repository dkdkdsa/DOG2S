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
                questString.text = "����� ����ȸ���Դϴ�, EŰ�� ���� â�� �ݰų� �ǹ��� ���� ��, ���� ��ȣ�ۿ��� �� �� �ֽ��ϴ�. �������� ������ �ü��� ���� �˷��帮�ڽ��ϴ�.";
                SP.sprite = SP1;
                return;
            case 1:
                questString.text = "����ȸ�������� �󸶵��� Ʃ�丮�� ���� ������ ���� �� �ֽ��ϴ�. ���� �ȿ��� �칰�� �����ϴµ� �칰�� �ڽ��� ������ �ִ� '��ھ�'�� �־� �������� ��ȯ�Ͽ� Ÿ���� �����̰� ���ִ� Ÿ���� �����Դϴ�. ��ھ�� ä�� �������� �翡 ���� Ÿ���� �̵��ӵ��� �޶����ϴ�.";
                SP.sprite = SP2;
                return;
            case 2:
                questString.text = "���尣������ �ڽ��� ���⸦ ��ȭ�Ͽ� ü�°� ���ݷ��� �ø� �� �ֽ��ϴ�. ��ȭ�Ҽ��� ������ ������ϴ�.";
                SP.sprite = SP3;
                return;
            case 3:
                questString.text = "������������ ���� ���İ� ���� �����Ͽ� ���� ������ ���� �� �ֽ��ϴ�. ������ ü�°� ���ݷ��� �ð�, ���� �ӵ��� �ٰ� ������ �þ�� ��Ҽ��� ������ �þ ���� �ӵ��� ���� �þ�ϴ�. ������ �������� ��� �� ȿ���� ������ϴ�.";
                SP.sprite = SP4;
                return;
            case 4:
                questString.text = "���������� ������ �糪�� ���͵��� ����� ���Դϴ�. ������ ó���� ������ ���� �� �� ������ ������ ���� Ŭ���� �Ҷ����� ��ھ ���� �� �ֽ��ϴ�.";
                SP.sprite = SP5;
                return;
            case 5:
                questString.text = "���� ������ �������� ������ ����ּ���!";
                SP.sprite = null;
                return;
        }
    }
}
