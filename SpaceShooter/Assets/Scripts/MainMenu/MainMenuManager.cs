using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void OyunaBasla()
    {
        SceneManager.LoadScene("Level1");

    }
    public void OyundanC�k()
    {
        Application.Quit(); 

    }
}
