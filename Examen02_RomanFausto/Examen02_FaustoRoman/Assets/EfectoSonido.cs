using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoSonido : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    private void Start()
    {
        audioSource =  GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Carrito"))
        {
            audioSource.Play();
        }
        
    }
}
