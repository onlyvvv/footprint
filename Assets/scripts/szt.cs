using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class szt: MonoBehaviour
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
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 860, 500), "\n\t\t双子塔\n\n" +
                "   是集酒店、写字楼、SOHO办公，以及观光\n   旅游、购物、休闲、娱乐、餐饮等于一体的\n   城市综合体\n   封顶时是厦门市第一高楼\n\n   思明区演武西路180-188号", style);
        }
    }
}
