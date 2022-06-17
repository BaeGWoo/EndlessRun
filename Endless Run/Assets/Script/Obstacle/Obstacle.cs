using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Animator animator;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            animator.enabled = true;
        }
    }


    //OnBecameInvisible은 Render와 관련되어있는 함수이기 때문에
    //MeshRenderer를 추가해야합니다.
    //화면 밖으로 나가게 되면 게임 오브젝트를 삭제합니다.
  
}
