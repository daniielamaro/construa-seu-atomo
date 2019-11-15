using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camada4Scr : MonoBehaviour
{
    public int EletronsMax;
    public int QuantEletrons;

    public GameObject Camada3;
    public GameObject EletronObj;

    private Transform transform;

    public int DistribuicaoS;
    public int DistribuicaoP;
    public int DistribuicaoD;

    void Start(){
        transform = GetComponent<Transform>();
    }

    public void CreateNewEletron(){
        if(QuantEletrons == EletronsMax){
            if(EletronsMax < 8){
                Camada3.GetComponent<Camada3Scr>().EletronsMax = 18;
                Camada3.GetComponent<Camada3Scr>().CreateNewEletron();
                return;
            }
            return;
        }

        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + 6, transform.position.z);

        GameObject newEletron = Instantiate(EletronObj, newPosition, Quaternion.identity) as GameObject;
        newEletron.GetComponent<EletronScr>().CentroRotacao = gameObject;
        newEletron.GetComponent<EletronScr>().DistanciaCentro = 6;

        if(DistribuicaoS < 2){
            DistribuicaoS++;
        }else if(DistribuicaoP < 6){
            DistribuicaoP++;
        }else if(DistribuicaoD < 10){
            DistribuicaoD++;
        }

        QuantEletrons++;
    }
}