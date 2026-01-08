using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Pressbutton : MonoBehaviour
{
    public GameObject Chair_Panel;
    public GameObject kanban_Panel;
    public GameObject manhoru_Panel;
    public GameObject TraffiClight_Panel;
    public GameObject informationBoard_Panel;
    public GameObject tesuri_Panel;
    void Start()
    {
        bacek_zukan();
    }

    public void Chair_Clk()
    {
        Chair_Panel.SetActive(true);
    }

    public void kanban_Clk()
    {
        kanban_Panel.SetActive(true);
    }

    public void manhoru_Clk()
    {
        manhoru_Panel.SetActive(true);
    }

    public void TraffiClight_Clk()
    {
        TraffiClight_Panel.SetActive(true);
    }

    public void InformationBoard_Clk()
    {
        informationBoard_Panel.SetActive(true);

    }

    public void tesuri_Clk()
    {
        tesuri_Panel.SetActive(true);
    }

    public void bacek_zukan()
    {
        Chair_Panel.SetActive(false);
        kanban_Panel.SetActive(false);
        manhoru_Panel.SetActive(false);
        TraffiClight_Panel.SetActive(false);
        informationBoard_Panel.SetActive(false);
        tesuri_Panel.SetActive(false);
    }
}
