using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoSonido2 : MonoBehaviour
{
    [SerializeField] private AudioClip Motosierra;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Carrito"))
        {
            ControladorSonido.Instance.EjecutarSonido(Motosierra);
        }
        
    }
}




