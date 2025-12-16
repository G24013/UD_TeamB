using UnityEngine;
using UnityEngine.SceneManagement;

public class titlebutton : MonoBehaviour
{
    public void ChangeScene(string Title)
    {
        SceneManager.LoadScene(Title);
    }
}

