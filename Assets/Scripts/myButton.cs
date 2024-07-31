using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myButton : MonoBehaviour
{
    [SerializeField] private GameObject myButtonPrefab;
    public void Hello()
    {
        Destroy(myButtonPrefab);
    }
}
