using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_startBlue : MonoBehaviour
{
    public Sc_Manager manager;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Box"|| other.gameObject.name == "Box1"||other.gameObject.name == "Box2")
        {
            Destroy(other.gameObject);
            manager.GetComponent<Sc_Manager>().score--;
            manager.GetComponent<Sc_Manager>().destroyCount++;
        }
    }
}
