using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private void Awake()
    {
        Instance = this; 
    }
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    bool oyunDurduMu=false;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PauseDurum();
        }
    }

    private void PauseDurum()
    {
        oyunDurduMu=!oyunDurduMu;

        if (oyunDurduMu)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void PausePanelAc()
    {
        if (!oyunDurduMu)
        {
            PauseDurum();
        }
            
    }
    public void PausePanelKapa()
    {
        if (oyunDurduMu)
        {
            PauseDurum();
        }
    }
    public void GameOverPanelAc()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void TekrarOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void AnaMenuyeDon()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("AnaMenu");
    }
}
