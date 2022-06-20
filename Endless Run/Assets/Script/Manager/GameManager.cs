using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //게임매니저의 인스턴스를 담는 전연변수
    //이 게임 내에서 게임 매니저 인스턴스는 이 instance에 담긴 오브젝트만 존재 할 수 있다.
    public static GameManager instance;

    public float speed = 10.0f;
    public int crashCount = 1;
    public bool condition=true;


    private void Awake()
    {
        if(instance==null)
        {
            instance = this;


            //씬이 전환되더라도 파괴되지 않고 유지할 수 있도록 설정
            DontDestroyOnLoad(instance);
        }

        else
        {
            //만약 씬을 이동했을 때 그 씬에도 게임 매니저가 존재하게 되면 자기 자신을 삭제
            Destroy(instance);
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        condition = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
