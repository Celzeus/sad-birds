using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class parrotspawnerscriptt : MonoBehaviour
{


    public GameObject parrot;
    public GameObject parrotslefttext;

    bool parrotdragging = false;

    public float forcemulti = 10;
    public float forcemaxi = 20;

    public int noparrots = 3;


    TextMeshProUGUI TMpro;
    // Start is called before the first frame update
    void Start()
    {
        TMpro = parrotslefttext.GetComponent<TextMeshProUGUI>();
        TMpro.text = " parrots left " + noparrots;
    }

    // Update is called once per frame
    void Update()
    {
        
        
       


        if (Input.GetMouseButtonUp(0) && parrotdragging && noparrots > 0)    
        {
            parrotdragging = false;

            noparrots--;
            TMpro.text = " parrots left " + noparrots;

            GameObject newparrot = Instantiate(parrot, transform.position, Quaternion.identity);
            Rigidbody2D rb = newparrot.GetComponent<Rigidbody2D>();
            

            Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousepos.z = 0;

            rb.velocity = (transform.position - mousepos) * forcemulti;
            if (rb.velocity.magnitude > forcemaxi)
            {
                rb.velocity = rb.velocity.normalized * forcemaxi;
            }


            
            
        }


        

    }

    private void OnMouseDown()
    {
        if (noparrots > 0)
        {
            
            parrotdragging = true;
        }
       


    }
  
}
