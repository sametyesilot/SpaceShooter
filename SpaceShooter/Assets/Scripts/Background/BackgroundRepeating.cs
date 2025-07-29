using UnityEngine;

public class BackgroundRepeating : MonoBehaviour
{
    [SerializeField] float y�kseklik;
    private void Update()
    {
        if (transform.position.y < -y�kseklik)
        {
            PozisyonuG�ncelle();
        }
    }

    private void PozisyonuG�ncelle()
    {
        Vector2 pozisyon = new Vector2(0,y�kseklik*2);
        transform.position = (Vector2)transform.position + pozisyon;
    }
}
