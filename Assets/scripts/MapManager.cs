using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MapManager : MonoBehaviour
{
    public static MapManager Ins;
    public Transform shuangzitaContainer;
    public Color[] lvColors;
    public Color[] lvHighColors;
    [HideInInspector]
    public Vector3 oriPos;
    [HideInInspector]
    public Quaternion oriRot;
    // Start is called before the first frame update
    void Start()
    {
        Ins = this;
        oriPos = Camera.main.transform.position;
        oriRot = Camera.main.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Camera.main.transform.DOMove(oriPos, 1);
            Camera.main.transform.DORotate(oriRot.eulerAngles, 1);
        }

    }

}
