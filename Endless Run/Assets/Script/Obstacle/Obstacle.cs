using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5.0f;
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
      
    }


    //OnBecameInvisible은 Render와 관련되어있는 함수이기 때문에
    //MeshRenderer를 추가해야합니다.
    //화면 밖으로 나가게 되면 게임 오브젝트를 삭제합니다.
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0, 5);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }
}
