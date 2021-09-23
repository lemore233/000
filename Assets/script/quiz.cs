using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{
    public int ID, IdLimite,pontos;
    public string[] Pergunta;
    public string[] RespostaCerta;
    public string[] RespostaBT1;
    public string[] RespostaBT2;

    public Text TextoBT1;
    public Text TextoBT2;
    public Text TextoNuCerto;
    public Text TextoNuTotal;


    // Start is called before the first frame update
    void Start()
    {
        ID = 0;
        pontos = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ID <= (IdLimite-1))
        {

            GetComponentInChildren<Text>().text = Pergunta[ID];

            TextoBT1.text = RespostaBT1[ID];
            TextoBT2.text = RespostaBT2[ID];
        }
        else
        {
            TerminouJogo();

        }

    }

    public void VerificaResposta(string num)
    {
        if (num == "1" && RespostaCerta[ID] == RespostaBT1[ID])
        {
            Acertou();
        }
        else if (num == "2" && RespostaCerta[ID] == RespostaBT2[ID])
        {
            Acertou();

        }
        else
        {
            Errou();
        }
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

    void TerminouJogo() {
        ID = 0;
       
        TextoNuCerto.text = pontos.ToString();
        TextoNuTotal.text = IdLimite.ToString();

        GetComponentInParent<Animator>().Play("Terminou");
    }
}
