using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tiaozhuan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�������Ҽ��л�����
        if (Input.GetMouseButtonDown(0))
        {
            //  Application.LoadLevel("SampleScene");
            SceneManager.LoadScene(1);
        }

    }
}