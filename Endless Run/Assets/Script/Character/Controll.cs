using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{

    public int count = 0;
    public Animator animator;



    void Update()
    {
       

    if(Input.GetKeyDown(KeyCode.LeftArrow)&&count>-2)
        {
            transform.position +=Vector3.left;
            count--;
        }

    if (Input.GetKeyDown(KeyCode.RightArrow)&&count<2)
        {
            transform.position +=Vector3.right;
            count++;
        }


    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Tire")
        {
            animator.SetTrigger("Death");
        }
    }
  
    //물체가 충돌했을 경우
   /* private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Tire Stack")
        {
            animator.SetTrigger("Death");
        }
    }*/
}
