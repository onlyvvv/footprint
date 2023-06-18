using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;

public class Up : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private float speed = 1.5f;
    private bool isRun;
    public GameObject camera;

    void Update()
    {
        if (isRun)
        {
            Move();
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isRun = false;
        Debug.Log("鼠标抬起");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isRun = true;
        Debug.Log("鼠标按下");
    }

    public void Move()
    {
        camera.transform.position += camera.transform.up * speed * Time.deltaTime;
    }
}
