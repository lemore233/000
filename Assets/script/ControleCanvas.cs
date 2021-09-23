using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControleCanvas : MonoBehaviour
{
    
    public GameObject[] BotaoSom;
    public GameObject[] ObjAudio;


    Animator ani;
    public AudioSource Efeito, Fundo;
    public AudioClip[] SonsJogo;

    

    void Start()
    {
        ani = GetComponent<Animator>();
     
    }

    public void VerificaBotao(int num)
    {
        switch (num)
        {
            case 0:
                TocaEfeito1();
              ani.Play("Ani_F_I_0");
                break;
            case 1:
                TocaEfeito1();
                ani.Play("Ani_F_O_0");
                break;
            case 2:
                TocaEfeito1();
                SceneManager.LoadScene("quiz");
                break;
            case 3:
                TocaEfeito1();
                SceneManager.LoadScene("main");
                break;
            case 4:
                TocaEfeito1();
                SceneManager.LoadScene("ar");
                break;
            case 5:
                TocaEfeito1();
                BotaoSom[0].SetActive(false);
                BotaoSom[1].SetActive(true);
                ObjAudio[0].SetActive(false);
                break;
            case 6:
                TocaEfeito1();
                BotaoSom[0].SetActive(true);
                BotaoSom[1].SetActive(false);
                ObjAudio[0].SetActive(true);
                break;
            case 7:
                TocaEfeito1();
                BotaoSom[2].SetActive(false);
                BotaoSom[3].SetActive(true);
                ObjAudio[1].SetActive(false);

                break;
            case 8:
                TocaEfeito1();
                BotaoSom[2].SetActive(true);
                BotaoSom[3].SetActive(false);
                ObjAudio[1].SetActive(true);
                break;
            case 9:
                Application.Quit();
                break;
        }

    }
    public void TocaEfeito1()
    {
        Efeito.clip = SonsJogo[1];
        Efeito.Play();
    }

}


