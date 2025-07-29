using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [Header("Elementler")]
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawn;

    [Header("Ayarlar")]
    [SerializeField] float moveSpeed=5f;
    [SerializeField] float minX=-4f;
    [SerializeField] float maxX=4f; 
    [SerializeField] float minY=-7f; 
    [SerializeField] float maxY=2f; 

    private void Update()
    {
        HareketFNC();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MermiFirlat(); 
        }
    }

    private void HareketFNC()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(h, v, 0);
        moveVector = moveVector.normalized;
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);


        Vector3 clampPos = transform.position;
        clampPos.x = Mathf.Clamp(clampPos.x, minX, maxX);
        clampPos.y = Mathf.Clamp(clampPos.y, minY, maxY);
        transform.position = clampPos;
    }
    void MermiFirlat()
    {
        Instantiate(bulletPrefab,bulletSpawn.position,Quaternion.identity);
    }
}
