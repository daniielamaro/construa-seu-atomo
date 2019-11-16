﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camada1Scr : MonoBehaviour
{
    public int EletronsMax;
    public int QuantEletrons;

    public GameObject Camada2;
    public GameObject EletronObj;

    private Transform transform;
    private List<GameObject> Eletrons;

    public int DistribuicaoS;
    public int DistribuicaoP;
    public int DistribuicaoD;

    void Start(){
        transform = GetComponent<Transform>();
        Eletrons = new List<GameObject>();
    }

    public void CreateNewEletron(){
        if(QuantEletrons == EletronsMax){
            Camada2.GetComponent<Camada2Scr>().CreateNewEletron();
            return;
        }

        GameObject newEletron = Instantiate(EletronObj, Vector3.zero, Quaternion.identity) as GameObject;
        newEletron.GetComponent<EletronScr>().CentroRotacao = gameObject;
        newEletron.GetComponent<EletronScr>().DistanciaCentro = 1.5f;
        Eletrons.Add(newEletron);
        QuantEletrons++;

        float radius = 1.5f;

        for(int i = 0; i < QuantEletrons; i++){
            float angle = i * Mathf.PI*2f / QuantEletrons+1;
            Vector3 newPosition = new Vector3(Mathf.Cos(angle)*radius, Mathf.Sin(angle)*radius, 0f);

            Eletrons[i].GetComponent<Transform>().position = newPosition;
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