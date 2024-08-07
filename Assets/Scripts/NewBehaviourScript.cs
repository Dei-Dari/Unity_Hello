using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Light _light;
    public Color newColor = Color.magenta;
    void Start()
    {
        _light = GetComponent<Light>();

        if (_light != null)
        {
            _light.color = newColor;
        }
    }
    void Update()   //FixedUpdate
    {
        transform.Rotate(1 * Time.deltaTime, 0, 0);
        //Instantiate
    }
    
}
