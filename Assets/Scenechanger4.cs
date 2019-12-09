using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger4 : MonoBehaviour
{
    public void GotoMMenuScene()
    {
        SceneManager.LoadScene("MMenu");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}