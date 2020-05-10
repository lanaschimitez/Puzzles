using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdemPedaco : MonoBehaviour
{
    public int orderPedaco;
    public Vector3 posicaoLugar;
    private Vector3 posicaoPedaco;
    private Vector3 posicaoLugar2;
    private bool lugarCorreto = false;

    private void Update()
    {
        posicaoLugar2 = posicaoLugar;
        posicaoPedaco = transform.position;
        posicaoLugar2.x = (posicaoLugar.x < 0) ? (posicaoLugar.x * (-1)) : posicaoLugar.x;
        posicaoLugar2.y = (posicaoLugar.y < 0) ? (posicaoLugar.y * (-1)) : posicaoLugar.y;
        posicaoPedaco.x = (transform.position.x < 0) ? (transform.position.x * (-1)) : transform.position.x;
        posicaoPedaco.y = (transform.position.y < 0) ? (transform.position.y * (-1)) : transform.position.y;

        if ((posicaoPedaco.x - posicaoLugar2.x < 0.2f) && (posicaoPedaco.y - posicaoLugar2.y < 0.2f))
        {
            transform.position = posicaoLugar;
            lugarCorreto = true;
        }
        else
        {
            lugarCorreto = false;
        }
        GameObject.Find("Bandeja").GetComponent<MovimentacaoPeca>().lugarCorreto[orderPedaco - 1] = lugarCorreto;
    }
}
