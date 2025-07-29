using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
    void Start()
    {
        
            float yasamSuresi = GetComponent<ParticleSystem>().main.duration;
            Destroy(gameObject, yasamSuresi);
        
    }

    
}
