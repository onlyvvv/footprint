using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Jump : MonoBehaviour
{
    public void GotonewScene()
    {
        SceneManager.LoadScene("Note");
    }
    public void GotoroomScene()
    {
        SceneManager.LoadScene("Room");
    }
}
