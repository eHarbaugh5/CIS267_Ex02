using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{


    public float bulletDamge;
    public float bulletSpeed;
    public float bulletLife;


    // Start is called before the first frame update
    void Start()
    {
        //  call the destroybullet function after bulletlife seconds
        Invoke("destroyBullet", bulletLife);
    }

    // Update is called once per frame
    void Update()
    {
        //  you can still use translate to move the bullet as long as the bulet or the enemy contains a rigidbody
        //  you cannot detect collisioins unless one of the game objects
        transform.Translate(transform.right * bulletSpeed * Time.deltaTime);
    }

    void destroyBullet()
    {


        Destroy(this.gameObject);
    }

}
