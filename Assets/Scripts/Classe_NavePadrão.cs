﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classe_NavePadrão 
{
    [SerializeField]
    float MultVelocidade, VelocidadeMaximaNave,MultTorque,VelocidadeDesaceleração,MuniçãoMaxima,MuniçãoAtual;

    [SerializeField]
    float GasolinaMaximaNave, GasolinaAtual;

    [SerializeField]
    Rigidbody NaveBody;


    //Funções Gets e Sets


    //pegando o rigidbody
     public Rigidbody GetRigidbodyNave()
    {
        return NaveBody;
    }
    //settando o rigidbody
    public void SetNaveRigidbody(Rigidbody Nave)
    {
        NaveBody = Nave;
    }


    //pegando o torque da nave
    public float GetTorquenave()
    {
        return MultTorque;
    }
    //Mudando o torque da nave
    public void SetNaveTorque(float novoTorque)
    {
        MultTorque = novoTorque;
    }
    //Aumentando/Diminuindo o torque da nave
    public void AddNaveTorque(float NovoTorque)
    {
        MultTorque += NovoTorque;
    }




    //pegando a desaceleração da nave
    public float GetDesaceleração()
    {
        return VelocidadeDesaceleração;
    }
    //Mudando a desaceleração da nave
    public void SetDesaceleração(float novaDesaceleração)
    {
        VelocidadeDesaceleração = novaDesaceleração;
    }
    //Aumentando/Diminuindo a desaceleração da nave
    public void AddDesaceleração(float novaDesaceleração)
    {
        VelocidadeDesaceleração += novaDesaceleração;
    }




    //retorna o multiplicador da velocidade
    public float GetMultVelocidade()
    {
        return MultVelocidade;
    }

    //retorna velocidade maxima da nave
    public float GetMaxVelocidade()
    {
        return VelocidadeMaximaNave;
    }

    //muda o valor do multiplicador de velocidade
    public void SetMultVelocidade(float novoMultVelocidade)
    {
        MultVelocidade = novoMultVelocidade;
    }

    //muda o valor da velocidade maxima
    public void SetMaxVelocidade(float novoVelocidademax)
    {
        VelocidadeMaximaNave = novoVelocidademax;
    }

    //adiciona/subtrai o valor do multiplicador de velocidade
    public void AddMultVelocidade(float AddMultVelocidade)
    {
        MultVelocidade += AddMultVelocidade;
    }

    //adiciona/subtrai o valor da velocidade maxima
    public void AddVelocidadeMax(float AddVelocidadeMax)
    {
        VelocidadeMaximaNave += AddVelocidadeMax;
    }

    //muda o valor maximo de munição da nave
    public void SetMuniçãoMaxima(float NovaMuniçãoMax)
    {
        MuniçãoMaxima = NovaMuniçãoMax;
    }

    //retorna o valod da munição maxima da nave
    public float GetMuniçãoMaxima()
    {
        return MuniçãoMaxima;
    }

    //adiciona/diminui o valor da munição maxima da nave
    public void AddMuniçãoMaxima(float NovaMuniçãoMaxima)
    {
        MuniçãoMaxima += NovaMuniçãoMaxima;
    }



    //muda o valor da munição da nave
    public void SetMuniçãoNave(float NovaMunição)
    {
        MuniçãoAtual = NovaMunição;
    }

    //retorna o valod da munição da nave
    public float GetMuniçãoNave()
    {
        return MuniçãoAtual;
    }

    //adiciona/diminui o valor da munição da nave
    public void AddMuniçãoNave(float NovaMunição)
    {
        MuniçãoAtual += NovaMunição;
    }

    //muda o valor da GasolinaMaxima da nave
    public void SetGasolinaMaxima(float NovaGasosaMax)
    {
        GasolinaMaximaNave = NovaGasosaMax;
    }

    //retorna o valor da Gasolina Maxima da nave
    public float GetGasolinaMaxima()
    {
        return GasolinaMaximaNave;
    }

    //adiciona/diminui o valor da Gasolina Maxima da nave
    public void AddGasolinaMax(float NovaGasolinaMaxima)
    {
        GasolinaMaximaNave += NovaGasolinaMaxima;
    }


    //muda o valor da Gasolina da nave
    public void SetGasolinaNave(float NovaGasosa)
    {
        GasolinaAtual = NovaGasosa;
    }

    //retorna o valor da Gasolina Maxima da nave
    public float GetGasolinaNave()
    {
        return GasolinaAtual;
    }

    //adiciona/diminui o valor da Gasolina Maxima da nave
    public void AddGasolinaNave(float NovaGasosa)
    {
        GasolinaAtual += NovaGasosa;
    }


}
