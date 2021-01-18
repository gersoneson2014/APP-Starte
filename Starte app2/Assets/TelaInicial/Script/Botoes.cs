using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour
{
    public GameObject museu, escultura, grafiti, mapa, checkin, meumuseus, loja, moedas, rank;

    public void BotaoMuseus()
    {
        moedas.SetActive(false);
        museu.SetActive(true);
        escultura.SetActive(false);
        grafiti.SetActive(false);
        meumuseus.SetActive(false);
        mapa.SetActive(false);
        checkin.SetActive(false);
        loja.SetActive(false);
        rank.SetActive(false);
    }
    public void BotaoMaps()
    {
        mapa.SetActive(true);
        museu.SetActive(false);
        escultura.SetActive(false);
        grafiti.SetActive(false);
        meumuseus.SetActive(false);
        checkin.SetActive(false);
        loja.SetActive(false);
        moedas.SetActive(false);
        rank.SetActive(false);
    }

    public void BotaoEsculturas()
    {
        museu.SetActive(false);
        escultura.SetActive(true);
        grafiti.SetActive(false);
        mapa.SetActive(false);
        meumuseus.SetActive(false);
        checkin.SetActive(false);
        loja.SetActive(false);
        moedas.SetActive(false);
        rank.SetActive(false);
    }

    public void BotaoGrafiti()
    {
        museu.SetActive(false);
        escultura.SetActive(false);
        grafiti.SetActive(true);
        mapa.SetActive(false);
        meumuseus.SetActive(false);
        checkin.SetActive(false);
        loja.SetActive(false);
        moedas.SetActive(false);
        rank.SetActive(false);
    }

    public void BotaoCheckin()
    {
        museu.SetActive(false);
        escultura.SetActive(false);
        grafiti.SetActive(false);
        mapa.SetActive(false);
        meumuseus.SetActive(false);
        checkin.SetActive(true);
        loja.SetActive(false);
        moedas.SetActive(false);
        rank.SetActive(false);
    }

    public void BotaoMeusMuseus()
    {
        museu.SetActive(false);
        escultura.SetActive(false);
        grafiti.SetActive(false);
        mapa.SetActive(false);
        checkin.SetActive(false);
        meumuseus.SetActive(true);
        loja.SetActive(false);
        moedas.SetActive(false);
        rank.SetActive(false);
    }

    public void BotaoLoja()
    {
        museu.SetActive(false);
        escultura.SetActive(false);
        grafiti.SetActive(false);
        mapa.SetActive(false);
        checkin.SetActive(false);
        meumuseus.SetActive(false);
        loja.SetActive(true);
        moedas.SetActive(false);
        rank.SetActive(false);
    }

    public void BotaoMoedas()
    {
        museu.SetActive(false);
        escultura.SetActive(false);
        grafiti.SetActive(false);
        mapa.SetActive(false);
        checkin.SetActive(false);
        meumuseus.SetActive(false);
        loja.SetActive(false);
        moedas.SetActive(true);
        rank.SetActive(false);
    }

    public void BotaoRank()
    {
        museu.SetActive(false);
        escultura.SetActive(false);
        grafiti.SetActive(false);
        mapa.SetActive(false);
        checkin.SetActive(false);
        meumuseus.SetActive(false);
        loja.SetActive(false);
        moedas.SetActive(false);
        rank.SetActive(true);
    }
}
