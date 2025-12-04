using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public GameObject popUp, range;
    public Transform player;
    public string objectName;


    void Update()
    {
        popUp.transform.LookAt(player);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(objectName))
        {
            Debug.Log("‚Ó‚ê");
            popUp.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(objectName))
        {
            Debug.Log("‚Í‚È‚ê");
            popUp.SetActive(false);
        }
    } 
}