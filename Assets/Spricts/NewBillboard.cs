//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
using UnityEngine;

public class NewBillboard : MonoBehaviour
{
    public Camera cam;
    public GameObject popUp, range, explain;
    //public string objectName;
    public bool hyouji,shori;
    //Vector3 camPos;

    void Start()
    {
        //popUp.SetActive(false);
        hyouji = false;
        shori = false;
    }

    void Update()
    {
        Vector3 camPos = cam.transform.position;
        camPos.y = transform.position.y;
        transform.LookAt(camPos);
        transform.Rotate(0, 180, 0);

        Or();
    }

    private void OnTriggerEnter(Collider other)
    {
        hyouji = true;
        shori = true;

        //popUp.SetActive(true);
        Debug.Log("‚Ó‚ê");
        
    }

    private void OnTriggerExit(Collider other)
    {
        hyouji = false;
        shori = true;

        Debug.Log("‚Í‚È‚ê");
        //popUp.SetActive(false);
    }

    void Or()
    {
        if (shori)
        {
            if (hyouji)
            {
                popUp.SetActive(true);
            }
            else
            {
                popUp.SetActive(false);
            }
            shori = false;
        }
    }
}