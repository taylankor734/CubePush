using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_manRed : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * -2 * transform.position.y;

        if (transform.position.z<=-14.5)
        {
            Destroy(this.gameObject);
        }
    }
}
