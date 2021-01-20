using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classe_NavePlayer1 : Classe_NavePadrão
{
    


    public Classe_NavePlayer1(float VelocidadeMax,float MultiplicadordeVelocidade,Rigidbody Corpo, float Torque,float Desaceleração)
    {
        SetMaxVelocidade(VelocidadeMax);
        SetMultVelocidade(MultiplicadordeVelocidade);
        SetNaveRigidbody(Corpo);
        SetNaveTorque(Torque);
        SetDesaceleração(Desaceleração);
    }





}
