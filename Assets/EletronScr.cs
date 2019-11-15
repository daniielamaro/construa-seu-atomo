using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EletronScr : MonoBehaviour
{
    public GameObject CentroRotacao;
    private Transform transform;
    public float DistanciaCentro;

    void Start(){
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.RotateAround(CentroRotacao.transform.position, Vector3.forward, Time.deltaTime * 100);
        transform.position = (transform.position - CentroRotacao.transform.position).normalized * DistanciaCentro + CentroRotacao.transform.position;
    }
}
