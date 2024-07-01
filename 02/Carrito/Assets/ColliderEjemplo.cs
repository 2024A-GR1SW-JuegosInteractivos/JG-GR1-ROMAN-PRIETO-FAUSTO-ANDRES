using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class ColliderEjemplo : MonoBehaviour
{    
    // Start is called before the first frame update
    [SerializeField] float delayDestroy = 0.5f;
    private bool tieneMotosierra; //false
    [SerializeField] Color32 tieneMotosierraColor = new  Color32(255, 255, 0, 255);
    [SerializeField] Color32 noTieneMotosierraColor = new  Color32(255, 255, 255, 255);
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
       Debug.Log("Zurdos hijos de puta!"); 
    }
    void OnTriggerEnter2D(Collider2D other)
    {        
        if(other.tag == "Paquete" && !tieneMotosierra)
        {
             Debug.Log("Tienes el plan motosierra");
             tieneMotosierra = true;
             spriteRenderer.color = tieneMotosierraColor;
             Destroy(other.gameObject, delayDestroy);
             
        }
        if(other.tag == "Cliente" && tieneMotosierra)
        {
            tieneMotosierra = false;
            spriteRenderer.color = noTieneMotosierraColor;
            Debug.Log("Estas salvando argentina");
            Destroy(other.gameObject, delayDestroy);
        }        
    }

}
