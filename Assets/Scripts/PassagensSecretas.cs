using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassagensSecretas : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent <Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision2D) {
    if (collision2D.gameObject.CompareTag("Player")) {
    		anim.Play("Passagem-Enter");
    	}
    }
    	
    void OnTriggerExit2D(Collider2D collision2D) {
    if (collision2D.gameObject.CompareTag("Player")) {
    		anim.Play("Passagem-Exit");
    	} 	
    }
}
