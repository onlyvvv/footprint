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
            // 创建蓝色填充的Texture2D，并指定为样式的背景
            Texture2D texture = new Texture2D(1, 1);
            texture.SetPixel(0, 0, Color.grey);
            texture.Apply();
            style.normal.background = texture;
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 600, 600), "\n\t   厦门大学\n\n" +
                "   由爱国华侨领袖陈嘉庚先生于\n   1921年创办，\n   是中国近代教育史上第一所华\n   侨创办的大学。\n   福建省和厦门市重点共建高校\n\n   颂恩楼为其代表建筑\n\n   厦门市思明南路422号", style);
        }
    }
}
