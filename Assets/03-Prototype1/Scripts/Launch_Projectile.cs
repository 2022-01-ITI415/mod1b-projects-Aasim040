using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch_Projectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("Fire1"))
        {
            GameObject Cannon_Ball = Instantiate(projectile, transform.position,
                                                     transform.rotation);
            Cannon_Ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
       (0, launchVelocity, 0));
        }
    }
}
