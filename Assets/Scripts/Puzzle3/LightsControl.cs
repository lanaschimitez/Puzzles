using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.Experimental.Rendering.Universal;
using Light2D = UnityEngine.Experimental.Rendering.Universal.Light2D;
using UnityEngine.UI;

public class LightsControl : MonoBehaviour
{
    public bool lightsOn;
    public Light2D luz;
    public Button button;
    void Start()
    {

    }
    void Update()
    {
        luz.enabled = (lightsOn) ? true :  false; //boolean para ativar a luz
        button.GetComponent<Image>().color = Color.red;

    }
}
