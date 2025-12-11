using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemaneger : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("GameMain");
    }
    public void albumScene()
    {
        SceneManager.LoadScene("album");
    }
    public void configScene()
    {
        SceneManager.LoadScene("config");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
