using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;
    [SerializeField] int maxSaglik = 100;
    int gecerliSaglik;

    [SerializeField] Image healthFill;

    private void Awake()
    {
        Instance = this; 
    }
    private void Start()
    {
        gecerliSaglik = maxSaglik;
        HealthBarUpdate();
    }
    public void HasalAl(int hasarMikari)
    {
        gecerliSaglik -= hasarMikari;
        gecerliSaglik = Mathf.Clamp(gecerliSaglik, 0, maxSaglik);
        HealthBarUpdate();
        if (gecerliSaglik <= 0)
        {
            UIManager.Instance.GameOverPanelAc();
            gameObject.SetActive(false);
        }
    }

    void HealthBarUpdate()
    {
        float canMiktari = (float)gecerliSaglik / maxSaglik;
        healthFill.fillAmount=canMiktari;
    }
}
