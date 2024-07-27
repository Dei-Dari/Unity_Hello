using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Update()   //FixedUpdate
    {
        transform.Rotate(1 * Time.deltaTime, 0, 0);
        //Instantiate
    }
}
