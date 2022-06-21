using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject popUp;
    public bool condition;

    private void Start()
    {
        instance = this;
        condition = true;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)&&condition)
        {
            Time.timeScale = 0;
            popUp.SetActive(true);
            condition = false;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && !condition)
        {
            Time.timeScale = 1;
            popUp.SetActive(false);
            condition = true;
        }

        
        
    }

    public void UIDisable()
    {
        Time.timeScale = 1;
        popUp.SetActive(false);
    }

    public void UIActive()
    {
        Invoke("InvokeActive", 1f);
    }


    public void InvokeActive()
    {
        popUp.SetActive(true);
    }
}
