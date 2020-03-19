using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camada1Scr : MonoBehaviour
{
    public int EletronsMax;
    public int QuantEletrons;

    public int ProtonsMax;
    public int QuantProtons;

    public int NeutronsMax;
    public int QuantNeutrons, quantParticulas;

    public GameObject Camada2;
    public GameObject EletronObj;
    public GameObject ProtonObj;
    public GameObject NeutronObj;

    private List<GameObject> Eletrons, Particulas;

    public int DistribuicaoS;
    public int DistribuicaoP;
    public int DistribuicaoD;

    void Start(){
        Eletrons = new List<GameObject>();
        Particulas = new List<GameObject>();
    }

    public void CreateNewEletron(){
        if(QuantEletrons == EletronsMax){
            Camada2.GetComponent<Camada2Scr>().CreateNewEletron();
            return;
        }

        GameObject newEletron = Instantiate(EletronObj, Vector3.zero, Quaternion.identity) as GameObject;
        newEletron.transform.SetParent(gameObject.transform);
        Eletrons.Add(newEletron);
        QuantEletrons++;

        float radius = 1.5f;

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
    
    public void CreateNewProton(){
        if(QuantProtons == ProtonsMax){
            return;
        }

        GameObject newProton = Instantiate(ProtonObj, Vector3.zero, Quaternion.identity) as GameObject;
        newProton.transform.SetParent(gameObject.transform);
        Particulas.Add(newProton);
        QuantProtons++;

        quantParticulas = Particulas.Count;

        float radius = 0f;
        List<GameObject> lista = new List<GameObject>();

        if(quantParticulas > 1 && quantParticulas <= 8){

            radius = 0.15f;
            lista = Particulas.GetRange(1, quantParticulas-1);

        }else if(quantParticulas > 8 && quantParticulas <= 21){

            radius = 0.30f;
            lista = Particulas.GetRange(8, quantParticulas-8);

        }else if(quantParticulas > 21 && quantParticulas <= 50){

            radius = 0.45f;
            lista = Particulas.GetRange(21, quantParticulas-21);

        }else if(quantParticulas > 50 && quantParticulas <= 90){

            radius = 0.6f;
            lista = Particulas.GetRange(50, quantParticulas-50);

        }

        for(int i = 0; i < lista.Count; i++){
            float angle = i * Mathf.PI*2f / lista.Count+1;
            Vector3 newPosition = new Vector3(Mathf.Cos(angle)*radius, Mathf.Sin(angle)*radius, 0f);
            lista[i].GetComponent<ParticulaScr>().posicao = newPosition;
        }
        
    }

    public void CreateNewNeutron(){
        if(QuantNeutrons == NeutronsMax){
            return;
        }

        GameObject newNeutron = Instantiate(NeutronObj, Vector3.zero, Quaternion.identity) as GameObject;
        newNeutron.transform.SetParent(gameObject.transform);
        Particulas.Add(newNeutron);
        QuantNeutrons++;

        quantParticulas = Particulas.Count;

        float radius = 0f;
        List<GameObject> lista = new List<GameObject>();

        if(quantParticulas > 1 && quantParticulas <= 8){

            radius = 0.15f;
            lista = Particulas.GetRange(1, quantParticulas-1);

        }else if(quantParticulas > 8 && quantParticulas <= 21){

            radius = 0.30f;
            lista = Particulas.GetRange(8, quantParticulas-8);

        }else if(quantParticulas > 21 && quantParticulas <= 50){

            radius = 0.45f;
            lista = Particulas.GetRange(21, quantParticulas-21);

        }else if(quantParticulas > 50 && quantParticulas <= 90){

            radius = 0.6f;
            lista = Particulas.GetRange(50, quantParticulas-50);

        }

        for(int i = 0; i < lista.Count; i++){
            float angle = i * Mathf.PI*2f / lista.Count+1;
            Vector3 newPosition = new Vector3(Mathf.Cos(angle)*radius, Mathf.Sin(angle)*radius, 0f);
            lista[i].GetComponent<ParticulaScr>().posicao = newPosition;
        }
        
    }
}