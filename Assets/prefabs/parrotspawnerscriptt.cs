using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parrotspawnerscriptt : MonoBehaviour
{


    public GameObject parrot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 newparrotpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newparrotpos.z = 0;
            GameObject newparrot = Instantiate(parrot, newparrotpos,Quaternion.identity);
            Rigidbody2D rb = newparrot.GetComponent<Rigidbody2D>();
            rb.velocity = rb.velocity - new Vector2(-20, 0);
        }
    }
}
