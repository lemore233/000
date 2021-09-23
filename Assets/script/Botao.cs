using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Android;


public class Botao : MonoBehaviour
{
    bool SeleObj;
   
    // Update is called once per frame
    void Update()
    {
        if (SeleObj == true) {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("quiz");
            }
        }
    }

    private void OnMouseEnter()
    {
        SeleObj = true;
    }
    private void OnMouseExit()
    {
        SeleObj = false;
    }
}
