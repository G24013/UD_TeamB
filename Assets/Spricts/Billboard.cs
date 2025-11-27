using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    void LateUpdate()
    {
        Vector3 camPos = Camera.main.transform.position;
        Vector3 dir = camPos - transform.position;

        dir.y = 0; // © c•ûŒü‚Ì‰ñ“]‚ğ‹Ö~

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }
    }


}