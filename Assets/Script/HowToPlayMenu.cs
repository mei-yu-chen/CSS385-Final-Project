using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayMenu : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScenes");
    }
}

