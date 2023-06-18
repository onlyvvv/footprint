using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class AreaBlock : MonoBehaviour
{
    private MeshRenderer render;
    private int lv = 0;
    public GameObject[] buildLv;
    public TextMeshPro txt;
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        FreshBuild();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1) && txt != null)
            txt.gameObject.SetActive(false);
    }

    private void FreshBuild()
    {
        for (int i = 0; i < buildLv.Length; i++)
        {
            buildLv[i].SetActive(i == lv);
        }
    }

    void OnMouseOver()
    {
        render.material.EnableKeyword("_EMISSION");
        render.material.SetColor("_EmissionColor", MapManager.Ins.lvHighColors[lv]);
    }

    private void OnMouseExit()
    {
        render.material.DisableKeyword("_EMISSION");
    }

    private void OnMouseDown()
    {
        num += 1;
        if(txt != null)
        {
            txt.gameObject.SetActive(true);
            txt.text = "browse:" + num;
        }
        
        if (lv >= MapManager.Ins.lvColors.Length - 1)
        {
            MoveCamera();
            return;
        }
        lv += 1;
        render.material.color = MapManager.Ins.lvColors[lv];
        FreshBuild();
        MoveCamera();

    }

    private void MoveCamera()
    {
        if (buildLv.Length == 0) return;
        var targetGameObject = buildLv[lv];
        var dir = targetGameObject.transform.position - MapManager.Ins.oriPos;
        dir.y = -3f;
        Camera.main.transform.DOMove(targetGameObject.transform.position - dir *0.2f, 1);
        Camera.main.transform.DORotate(Quaternion.LookRotation(dir).eulerAngles, 1);

    }
}
