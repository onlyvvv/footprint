using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mj : MonoBehaviour
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
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 750, 500), "\n\t             猫街\n\n" +
                "   一条以猫为主题的特色街区\n\n   休闲、品读集合为一体\n   涂鸦、雕塑都很精美\n   猫咪博物馆中的车厢构建、创意绘画、\n   猫瓶等都具有极高的欣赏价值。", style);
        }
    }
}
