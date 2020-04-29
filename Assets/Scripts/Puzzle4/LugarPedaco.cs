using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LugarPedaco : MonoBehaviour
{
    public int orderLugar;
    public GameObject imagem;

    public Vector3 posicao { get; private set; }

    void Start()
    {
        posicao = transform.position;
        Debug.Log(posicao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        imagem = collision.gameObject;
        if ( imagem.GetComponent<OrdemPedaco>().orderPedaco == orderLugar)
        {
            //fazer comparacao da distancia de um para o outro
            imagem.GetComponent<OrdemPedaco>().posicaoLugar = posicao;
        }
    }
}
