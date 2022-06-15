using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject road;
    List<GameObject> roadlist;
    //위치값 설정 
    Vector3 nextRoad = Vector3.zero;//(0,0,0)
    public float speed = 0f;
    int firstRoad, lastRoad=0;

    void Start()
    {
        roadlist = new List<GameObject>();

        for(int i=0;i<3;i++)
        {
            roadlist.Add(Instantiate(road, nextRoad, Quaternion.identity));
            nextRoad += Vector3.forward * 36f;
        }
    }

   
    void Update()
    {
        if (GameManager.instance.condition == false) return;
        RoadMove();
    }
    
    void RoadMove()
    {
        for(int i=0;i<roadlist.Count;i++)
        {
            roadlist[i].transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if (roadlist[lastRoad].transform.position.z <= -36)
        {
            firstRoad = lastRoad - 1;

            if (firstRoad < 0)
            {
                firstRoad = roadlist.Count - 1;
            }


            roadlist[lastRoad].transform.position = roadlist[firstRoad].transform.position+Vector3.forward*36;
            
            lastRoad++;

            if (lastRoad >= roadlist.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
