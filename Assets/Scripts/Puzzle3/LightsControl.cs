using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.Experimental.Rendering.Universal;
using Light2D = UnityEngine.Experimental.Rendering.Universal.Light2D;
using UnityEngine.UI;

public class LightsControl : MonoBehaviour
{
    public int idButton;
    public GameObject game;
    public int[] idLightsO = new int[9];

    RaycastHit hit; //Armazena informação que pegou o objeto
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                game = hit.collider.gameObject; //mudar para varios objetos
                game.GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }
}
