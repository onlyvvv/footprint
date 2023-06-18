using UnityEngine;
using UnityEngine.SceneManagement;
public class Skip : MonoBehaviour
{
    public void GotonewScene()
    {
        SceneManager.LoadScene(5);
    }
    public void GoindoorScene()
    {
        SceneManager.LoadScene(3);
    }
}
