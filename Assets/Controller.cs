﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Text DistribuicaoTxt;
    public GameObject Camada1, Camada2, Camada3, Camada4;

    void Start(){
        DistribuicaoTxt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        int S1, P1, D1;
        int S2, P2, D2;
        int S3, P3, D3;
        int S4, P4, D4;

        S1 = Camada1.GetComponent<Camada1Scr>().DistribuicaoS;
        S2 = Camada2.GetComponent<Camada2Scr>().DistribuicaoS;
        S3 = Camada3.GetComponent<Camada3Scr>().DistribuicaoS;
        S4 = Camada4.GetComponent<Camada4Scr>().DistribuicaoS;

        P2 = Camada2.GetComponent<Camada2Scr>().DistribuicaoP;
        P3 = Camada3.GetComponent<Camada3Scr>().DistribuicaoP;
        P4 = Camada4.GetComponent<Camada4Scr>().DistribuicaoP;

        D3 = Camada3.GetComponent<Camada3Scr>().DistribuicaoD;


        if(S1 > 0){
            DistribuicaoTxt.text = "1S"+S1;
            if(S2 > 0){
                DistribuicaoTxt.text += "-2S"+S2;
                if(P2 > 0){
                    DistribuicaoTxt.text += "-2P"+P2;
                    if(S3 > 0){
                        DistribuicaoTxt.text += "-3S"+S3;
                        if(P3 > 0){
                            DistribuicaoTxt.text += "-3P"+P3;
                            if(S4 > 0){
                                DistribuicaoTxt.text += "-4S"+S4;
                                if(D3 > 0){
                                    DistribuicaoTxt.text += "-3D"+D3;
                                    if(P4 > 0){
                                        DistribuicaoTxt.text += "-4P"+P4;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
