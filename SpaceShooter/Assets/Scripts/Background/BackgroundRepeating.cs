using UnityEngine;

public class BackgroundRepeating : MonoBehaviour
{
    [SerializeField] float yükseklik;
    private void Update()
    {
        if (transform.position.y < -yükseklik)
        {
            PozisyonuGüncelle();
        }
    }

    private void PozisyonuGüncelle()
    {
        Vector2 pozisyon = new Vector2(0,yükseklik*2);
        transform.position = (Vector2)transform.position + pozisyon;
    }
}
