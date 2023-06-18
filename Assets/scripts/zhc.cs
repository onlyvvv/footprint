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
            // 创建蓝色填充的Texture2D，并指定为样式的背景
            Texture2D texture = new Texture2D(1, 1);
            texture.SetPixel(0, 0, Color.gray);
            texture.Apply();
            style.normal.background = texture;
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 700, 500), "\n\t         中华城\n\n" +
                "  是将旅游、购物、餐饮、娱乐、休闲、\n  品读集合为一体，从消费者消费感受\n  的角度构建起来的，符合现代消费者\n  消费理念的商业中心。\n\n  福建省厦门市思明南路153号", style);
        }
    }
}
