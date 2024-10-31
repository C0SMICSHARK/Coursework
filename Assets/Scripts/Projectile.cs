using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectile_speed;
    public GameObject projectile;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector3(projectile_speed, 3, 0), ForceMode2D.Impulse);

        OnMouseDown instantiate = bullet.GetComponent<OnMouseDown>();
        
          
            
    }
}
