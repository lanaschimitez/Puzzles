using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.Experimental.Rendering.Universal;
using Light2D = UnityEngine.Experimental.Rendering.Universal.Light2D;

public class LightsControl : MonoBehaviour
{
    public bool lightsOn;
    public Light2D luz;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lightsOn)
        {
            luz.enabled = true;
        }
        else
        {
            luz.enabled = false;
        }
    }
}
