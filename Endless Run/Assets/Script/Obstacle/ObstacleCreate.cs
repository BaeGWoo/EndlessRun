using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{

    //트리거와 충돌했을 때 한번 이벤트 발생
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Character")
        {
            Debug.Log("충돌");
        }
    }
}
