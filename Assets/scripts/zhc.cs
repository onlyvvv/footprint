using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhc : MonoBehaviour
{
    bool isShow;
    // Start is called before the first frame update
    void Start()
    {
        bool isShow = false;
    }

    // Update is called once per frame
    void OnMouseEnter()
    {
        isShow = true;
    }

    void OnMouseExit()
    {
        isShow = false;
    }
    private void OnGUI()
    {
        if (isShow)
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 40;
            style.normal.textColor = Color.white;
            // ������ɫ����Texture2D����ָ��Ϊ��ʽ�ı���
            Texture2D texture = new Texture2D(1, 1);
            texture.SetPixel(0, 0, Color.gray);
            texture.Apply();
            style.normal.background = texture;
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 700, 500), "\n\t         �л���\n\n" +
                "  �ǽ����Ρ�������������֡����С�\n  Ʒ������Ϊһ�壬�����������Ѹ���\n  �ĽǶȹ��������ģ������ִ�������\n  �����������ҵ���ġ�\n\n  ����ʡ������˼����·153��", style);
        }
    }
}