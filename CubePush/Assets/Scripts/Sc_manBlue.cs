using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_manBlue : MonoBehaviour
{
    public Rigidbody rb;
    void Update()
    {
        rb.velocity = transform.forward*2 * transform.position.y;

        if (transform.position.z >= 12)
        {
            Destroy(this.gameObject);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Cube*2")
        {
            if (gameObject.name == "man_blue(Clone)")
            {
                Instantiate(this.gameObject, new Vector3(transform.position.x+0.5f, transform.position.y, transform.position.z+0.5f), Quaternion.identity);
            }
        }
        if (other.gameObject.name == "Cube*3")
        {
            if (gameObject.name == "man_blue(Clone)")
            {
                Instantiate(this.gameObject, new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z + 0.5f), Quaternion.identity);
                Instantiate(this.gameObject, new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z + 0.5f), Quaternion.identity);
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "man_red")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    
}
