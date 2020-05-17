using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsID : MonoBehaviour
{
    public int[] idLightsB = new int[9];
    void Start()
    {
        //mudar e pegar pelo banco de dados
        for(int i = 0; i>9; i ++)
        {
            idLightsB[i] = i + 1;
        }
    }
    void Update()
    {
        
    }
}
