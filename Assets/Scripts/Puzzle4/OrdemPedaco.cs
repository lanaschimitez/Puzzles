using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdemPedaco : MonoBehaviour
{
    public int orderPedaco;
    public bool organizar = false;
    public Vector3 posicaoLugar;
    public bool mudarLugar;

    private void Update()
    {
        if (mudarLugar)
        {
            transform.position = posicaoLugar;
        }
    }
}
