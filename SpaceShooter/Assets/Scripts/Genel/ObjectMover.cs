using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] float speed = -3f;
    [SerializeField] float speedAzalisMiktari = -0.2f; // Negatif ��nk� yukar�dan a�a��ya hareket ediyor
    [SerializeField] float maxHiz = -8f;
    private void Update()
    {
        transform.Translate(Vector2.up*speed*Time.deltaTime);
    }
    private void Start()
    {
        StartCoroutine(HizlandirRoutine());
    }
    IEnumerator HizlandirRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f); // Her 10 saniyede bir
            if (speed > maxHiz) // H�z, belirli bir s�n�ra kadar azalacak
            {
                speed += speedAzalisMiktari;
            }
        }
    }
}
