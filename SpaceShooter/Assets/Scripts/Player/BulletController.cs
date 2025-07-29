using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] GameObject effect;
    private void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        
        Destroy(gameObject); 
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Meteor"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
