using System.Collections;
using UnityEngine;

public class UsingInstatiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.up * 350);
        }
    }
}
