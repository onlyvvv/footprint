using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene1");
    }

    public void startGame1()
    {
        SceneManager.LoadScene("Switch");
    }

    public void Back()
    {
        SceneManager.LoadScene("SampleScene1");
    }
}
