using UnityEngine;
using UnityEngine.SceneManagement;

public class titlebutton : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Title");
    }
}

