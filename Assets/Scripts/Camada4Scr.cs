﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camada4Scr : MonoBehaviour
{
    public int EletronsMax;
    public int QuantEletrons;

    public GameObject Camada3;
    public GameObject EletronObj;

    private List<GameObject> Eletrons;

    public int DistribuicaoS;
    public int DistribuicaoP;
    public int DistribuicaoD;

    void Start(){
        Eletrons = new List<GameObject>();
    }

    void Update(){
        //transform.Rotate(0,0,-1);
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

        GameObject newEletron = Instantiate(EletronObj, Vector3.zero, Quaternion.identity) as GameObject;
        newEletron.transform.SetParent(gameObject.transform);
        Eletrons.Add(newEletron);
        QuantEletrons++;

        float radius = 6f;

        for(int i = 0; i < QuantEletrons; i++){
            float angle = i * Mathf.PI*2f / QuantEletrons+1;
            Vector3 newPosition = new Vector3(Mathf.Cos(angle)*radius, Mathf.Sin(angle)*radius, 0f);
            Eletrons[i].GetComponent<ParticulaScr>().posicao = newPosition;
        }

        if(DistribuicaoS < 2){
            DistribuicaoS++;
        }else if(DistribuicaoP < 6){
            DistribuicaoP++;
        }else if(DistribuicaoD < 10){
            DistribuicaoD++;
        }
    }
}