using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("toMove", false);
    }
    void Update()
    {
        //la apasarea tastei Enter(din Numpad) parametrul toMove este setat true
        //ceea ce permite tranzitia catre starea Grab si implicit activarea animatiei
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("enter key was pressed");
           animator.SetBool("toMove", true);
            
        }
        //La apasarea tastei Space parametrul toMove este setat false 
        //ceea ce blocheaza animatia in starea Do_nothing
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        animator.SetBool("toMove", false);
        
        }
        
    }
}
