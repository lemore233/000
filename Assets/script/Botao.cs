using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Android;
using UnityEngine.Events;


public class Botao : MonoBehaviour
{
    public UnityEvent BT;

    private void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (Input.touchCount < 2))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray,out hit))
            {
                if ((hit.transform.name == gameObject.name))
                {
                    BT.Invoke();

                }
            }

        }
    }
}
