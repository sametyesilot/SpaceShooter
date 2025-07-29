using System.Collections;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    [Header("Ayarlar")]
    [SerializeField] float minX = -3f;
    [SerializeField] float maxX = 3f;
    [SerializeField] float sabitY = 12f;
    [SerializeField] float firlatmaS�resi = 1.5f;
    [SerializeField] float minFirlatmaS�resi = 0.3f; // en d���k s�n�r
    [SerializeField] float firlatmaAzalmaHizi = 0.01f;
    [SerializeField] float firlatmaAzaltmaPeriyodu = 10f;

    [Header("Elements")]
    [SerializeField] GameObject[] gezegenPrefabs;

    private void Start()
    {
        StartCoroutine(GezegenFirlatRoutine());
        StartCoroutine(FirlatmaSuresiAzaltRoutine());
    }

    IEnumerator GezegenFirlatRoutine()
    {
        while (true) 
        { 
            float rasgeleX=Random.Range(minX, maxX);
            Vector3 firlatmaPos = new Vector3(rasgeleX, sabitY, 0);

            int rasgeleIndex = Random.Range(0,gezegenPrefabs.Length);
            GameObject gezegenPrefab = Instantiate(gezegenPrefabs[rasgeleIndex], firlatmaPos, Quaternion.identity);
            Destroy(gezegenPrefab , 30 );
            yield return new WaitForSeconds(firlatmaS�resi);
        }
          
    }
    IEnumerator FirlatmaSuresiAzaltRoutine()
    {
        while (firlatmaS�resi > minFirlatmaS�resi)
        {
            yield return new WaitForSeconds(firlatmaAzaltmaPeriyodu);
            firlatmaS�resi -= firlatmaAzalmaHizi;
        }
    }
}
