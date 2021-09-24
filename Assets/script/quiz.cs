using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{
    public int ID, IdLimite, pontos;
    public Perguntas[] Perguntas;

    public Text TextoBT1;
    public Text TextoBT2;
    public Text TextoNuCerto;
    public Text TextoNuTotal;


    // Start is called before the first frame update
    void Start()
    {
        ID = 0;
        pontos = 0;
        AtualizaQuiz();
    }

    // Update is called once per frame

    public void VerificaResposta(string num)
    {
        if (num == "1" && Perguntas[ID].RespostaCerta == Perguntas[ID].RespostaBT1)
        {
            Acertou();
            
        }
        else if (num == "2" && Perguntas[ID].RespostaCerta== Perguntas[ID].RespostaBT2)
        {
            Acertou();
            
        }
        else
        {
            Errou();
        }
        AtualizaQuiz();
    }

    void Acertou()
    {
        ID++;
        pontos++;
    }

    void Errou()
    {
        ID++;
    }

    void TerminouJogo()
    {
        ID = 0;

        TextoNuCerto.text = pontos.ToString();
        TextoNuTotal.text = IdLimite.ToString();

        GetComponentInParent<Animator>().Play("Terminou");
    }
    void AtualizaQuiz()
    {
        if (ID <= (IdLimite - 1))
        {

            GetComponentInChildren<Text>().text = Perguntas[ID].Pergunta;

            TextoBT1.text = Perguntas[ID].RespostaBT1;
            TextoBT2.text = Perguntas[ID].RespostaBT2;
        }
        else
        {
            TerminouJogo();

        }

    }


}
[System.Serializable]
public class Perguntas
{
   
    public string Pergunta;
    public string RespostaCerta;
    public string RespostaBT1;
    public string RespostaBT2;

}

