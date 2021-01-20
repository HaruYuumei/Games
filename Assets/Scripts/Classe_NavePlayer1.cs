using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classe_NavePlayer1 : Classe_NavePadrão
{
    


    public Classe_NavePlayer1(float VelocidadeMax,float MultiplicadordeVelocidade,Rigidbody Corpo, float Torque,float Desaceleração,float GasosaMaxima,float GasosaAtual,float MuniçãoMaxima,float MuniçãoAtual)
    {
        SetMaxVelocidade(VelocidadeMax);
        SetMultVelocidade(MultiplicadordeVelocidade);
        SetNaveRigidbody(Corpo);
        SetNaveTorque(Torque);
        SetDesaceleração(Desaceleração);
        SetGasolinaMaxima(GasosaMaxima);
        SetGasolinaNave(GasosaAtual);
        SetMuniçãoMaxima(MuniçãoMaxima);
        SetMuniçãoNave(MuniçãoAtual);
    }





}
