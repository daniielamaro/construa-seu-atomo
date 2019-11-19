using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EletronScr : MonoBehaviour
{
    public Vector3 posicao;

    void Start(){

    }

    void Update()
    {
        float step =  5 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, posicao, step);
    }
}
