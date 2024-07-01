using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float velocidadRapido = 45f;
    [SerializeField] float velocidadLento = 1f;
    // Start is called before the first frame update
    void Start()
    {       
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);        
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Entrando en trigger!");
        if (other.tag == "Rapido")
        {
            Debug.Log("Viva la libertad carajo!");   
            moveSpeed = velocidadRapido;         
        }
        if (other.tag == "Lento")
        {
            Debug.Log("Zurdos choros!"); 
            moveSpeed = velocidadLento; 

        }
    }
    
}
