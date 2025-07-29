using UnityEngine;

public class DamageControl : MonoBehaviour
{
    public int hasarMiktari=10;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.Instance.HasalAl(hasarMiktari);
            Destroy(gameObject);
        }
    }
}
