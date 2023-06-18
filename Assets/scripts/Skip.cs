using UnityEngine;
using UnityEngine.SceneManagement;
public class Skip : MonoBehaviour
{
    public void GotonewScene()
    {
        SceneManager.LoadScene("Note");
    }
    public void GoindoorScene()
    {
        SceneManager.LoadScene("indoor");
    }
}
