using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class UploadTexture : MonoBehaviour
{
    public RawImage wwwTexture;
    public GameObject btn_add;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadImag()
    {
        OpenFileName ofn = new OpenFileName();
        ofn.structSize = Marshal.SizeOf(ofn);
        ofn.filter = "ͼƬ�ļ�(*.jpg*.png)\0*.jpg;*.png";
        ofn.file = new string(new char[256]);
        ofn.maxFile = ofn.file.Length;
        ofn.fileTitle = new string(new char[64]);
        ofn.maxFileTitle = ofn.fileTitle.Length;
        //Ĭ��·��
        string path = UnityEngine.Application.streamingAssetsPath;
        path = path.Replace('/', '\\');
        //Ĭ��·��
        //ofn.initialDir = "G:\\wenshuxin\\test\\HuntingGame_Test\\Assets\\StreamingAssets";
        ofn.initialDir = path;
        ofn.title = "Open Project";
        ofn.defExt = "JPG";//��ʾ�ļ�������
                           //ע�� һ����Ŀ��һ��Ҫȫѡ ����0x00000008�Ҫȱ��
        ofn.flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000200 | 0x00000008;//OFN_EXPLORER|OFN_FILEMUSTEXIST|OFN_PATHMUSTEXIST| OFN_ALLOWMULTISELECT|OFN_NOCHANGEDIR
                                                                                   //���Windows����ʱ��ʼ����ѡ�е�ͼƬ
        if (WindowDll.GetOpenFileName(ofn))
        {
            Debug.Log("Selected file with full path: " + ofn.file);
            StartCoroutine(WWW_Tex(ofn.file));
        }
 
    }
    

    IEnumerator WWW_Tex(string url)
    {
        WWW www = new WWW(url);
        yield return www;
        if (www.isDone && www.error == null)
        {
            wwwTexture.texture = www.texture;
            btn_add.SetActive(false);
        }
    }
}
