using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera cam;
    public GameObject popUp, range;
    public string objectName;

    void Update()
    {
        Vector3 camPos = cam.transform.position;
        camPos.y = transform.position.y;
        transform.LookAt(camPos);
        transform.Rotate(0, 180, 0);
        /*
        if (range.transform.parent == null)
        {
            Debug.Log("êeÇ¢Ç»Ç¢ÇÊ(ì∆)");
        }
        else
        {
            string namae = range.transform.parent.name;
            Debug.Log("Ç†Ç†Ç†Ç†" + namae + "Ç®Ç®Ç®Ç®Ç®");
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("êeÇ¢Ç»Ç¢ÇÊ(ì∆)");
        /*
        if (range.transform.parent == null)
        {
            Debug.Log("êeÇ¢Ç»Ç¢ÇÊ(ì∆)");
        }
        else
        {
            string namae = range.transform.parent.name;
            //Debug.Log("Ç†Ç†Ç†Ç†" + namae + "Ç®Ç®Ç®Ç®Ç®");
            Debug.Log("Ç†Ç†Ç†Ç†Ç®Ç®Ç®Ç®Ç®");

            if (namae == objectName)
            {
                //popUp.SetActive(true);
                //Debug.Log("Ç”ÇÍ");
            }
        }
        */
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("ÇÕÇ»ÇÍ");
        popUp.SetActive(false);
    }
}