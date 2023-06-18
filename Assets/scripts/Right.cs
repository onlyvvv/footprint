using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private float speed = 1.5f;
    private bool isRun;
    public GameObject camera;
    public float xRotation = 0f;

    void Update()
    {
        if (isRun && !Input.GetKey(KeyCode.LeftAlt))
        {
            Move();
        }
        if (isRun && Input.GetKey(KeyCode.LeftAlt))
        {
            Rotate();
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
        camera.transform.position += camera.transform.right * speed * Time.deltaTime;
    }

    public void Rotate()
    {
        Vector3 rotation = camera.transform.localEulerAngles;
        xRotation = 25.0f;
        rotation += Vector3.up * Time.deltaTime * xRotation;
        camera.transform.localEulerAngles = rotation;
    }
}
