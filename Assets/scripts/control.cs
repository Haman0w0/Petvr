using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isCollision = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollision)
        {
            Vector3 cam = GameObject.Find("ARCamera").GetComponent<Transform>().position;
            this.GetComponent<Transform>().position = new Vector3(cam.x, 0, cam.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isCollision)
            {
                isCollision = false;
            }
            else
            {
                isCollision = true;
            }
        }
    }
}
