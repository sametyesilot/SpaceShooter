using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] EnemySpawner[] leveller;
    [SerializeField] float levelSüre = 10f;
    private int levelSayisi = 0;

    private void Start()
    {
        StartCoroutine(LevelSpawner());
    }
    IEnumerator LevelSpawner()
    {
        while (levelSayisi < leveller.Length)
        {
            leveller[levelSayisi].BaslatFNC();

            if (leveller[levelSayisi].bittiMi)
            {
                leveller[levelSayisi].bittiMi = false;
                levelSayisi++;
            }
            yield return new WaitForSeconds(levelSüre);
        }
    }

}
