using UnityEngine;

public class EnemyPosition : MonoBehaviour
{

    [SerializeField] Transform[] hedefler;
    int mevcutHedefIndex = 0;
    [SerializeField] float hareketHizi = 15;
    [SerializeField] int hasarMiktari = 15;
    private void Update()
    {
        if (hedefler.Length == 0) return;

        transform.position = Vector3.MoveTowards(transform.position, hedefler[mevcutHedefIndex].position, hareketHizi * Time.deltaTime);
        if (Vector3.Distance(transform.position, hedefler[mevcutHedefIndex].position) < 0.1f)
        {
            mevcutHedefIndex++;

            if (mevcutHedefIndex >= hedefler.Length)
            {
                mevcutHedefIndex = 0;
                transform.position = hedefler[mevcutHedefIndex].position;
            }
        }
    }
    public void HedefleriAyarla(Transform[] yeniHedefler)
    {
        hedefler = yeniHedefler;
        mevcutHedefIndex = 0; // Gerekirse baþlangýcý sýfýrla
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.Instance.HasalAl(hasarMiktari);
            Destroy(gameObject);
        }
    }
}
