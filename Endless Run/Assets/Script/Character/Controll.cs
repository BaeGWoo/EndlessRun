using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{

    public int count = 0;

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
}
