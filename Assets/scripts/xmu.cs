using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xmu : MonoBehaviour
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
            texture.SetPixel(0, 0, Color.grey);
            texture.Apply();
            style.normal.background = texture;
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 600, 600), "\n\t   ���Ŵ�ѧ\n\n" +
                "   �ɰ�����������¼θ�������\n   1921�괴�죬\n   ���й���������ʷ�ϵ�һ����\n   �ȴ���Ĵ�ѧ��\n   ����ʡ���������ص㹲����У\n\n   �̶�¥Ϊ�������\n\n   ������˼����·422��", style);
        }
    }
}
