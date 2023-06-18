using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public RawImage img;
    public Texture2D[] bgs;
    private int showIndex;
    // Start is called before the first frame update
    void Start()
    {
        showIndex = 0;
        ChangeBg();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            showIndex += 1;
            ChangeBg();
            if (showIndex + 1 >= bgs.Length)
                showIndex = -1;
        }
    }

    private void ChangeBg()
    {
        img.texture = bgs[showIndex];
    }

    
}
