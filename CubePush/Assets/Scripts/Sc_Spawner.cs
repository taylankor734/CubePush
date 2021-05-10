using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Spawner : MonoBehaviour
{
    private Vector3 screenPoint;

    public GameObject blueman;

    // Start is called before the first frame update
    void Start()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = new Vector3(Mathf.Clamp(curPosition.x,-4.5f,4.5f), 1, -15);
        
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(blueman, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }

    }
}
