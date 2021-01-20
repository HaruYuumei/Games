using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classe_NavePadrão 
{
    [SerializeField]
    float MultVelocidade, VelocidadeMaximaNave,MultTorque,VelocidadeDesaceleração;

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


}
