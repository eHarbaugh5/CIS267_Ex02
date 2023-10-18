using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    //  drag and drop prefab
    public GameObject bullet;
    //  the tip of the gun
    public Transform muzzle;

    private float timeBetweenShots;

    public float fireingRate;

    private bool canFire = true;


    private void Start()
    {
        
    }

    private void Update()
    {
        if (timeBetweenShots <= 0)
        {
            //  resset time back to the fire rate
            timeBetweenShots = fireingRate;
            canFire = true;

        }
        else
        {

            timeBetweenShots -= Time.deltaTime;

        }

        if (Input.GetButtonDown("Fire1"))
        {

            if (canFire)
            {
                //  after fire wait time

                canFire = false;
                shootGun();


            }

        }


    }

    public void shootGun()
    {

        Instantiate(bullet, muzzle.position, transform.rotation);

    }


}
