using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class love : MonoBehaviour
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
            style.normal.textColor = Color.white  ;
            // 创建蓝色填充的Texture2D，并指定为样式的背景
            Texture2D texture = new Texture2D(1, 1);
            texture.SetPixel(0, 0, Color.grey);
            texture.Apply();
            style.normal.background = texture;
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 860, 500), "\n\t   鼓浪屿（原名“圆沙洲”）\n\n" +
                "   代表景点有：日光岩、菽庄花园、皓月园、\n   毓园、鼓浪石\n\n   此为日光岩的标志建筑八卦楼\n\n   国家5A级旅游景区、全国重点文物保护单位、\n   中国最美五大城区", style);
        }
    }
}
