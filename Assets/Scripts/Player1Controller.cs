using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Controller : MonoBehaviour
{
    public Rigidbody Player;
    public Camera Player1Camera;

    Classe_NavePlayer1 Navezinha1;

    


    public float velocidade;

    public GameObject PrefabBala;
    GameObject CloneBala,CloneBala2;

    public GameObject Arma1, Arma2;


    public Slider ContadorMunição;
    public GameObject SliderFill;
    public Text SliderMuniçãoContador;

    public float ammo, maxammo;


    public Slider ContadorGasosa;
    public GameObject SliderGasosaFill;
    public Text SliderGasosaContador;

    public float GasosaAtual, MaxGasosa;


    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.GetComponent<Rigidbody>();
        Navezinha1 = new Classe_NavePlayer1(10,250,Player,180,25,100,100,50,50);
        Player1Camera = Camera.main;

       
        ContadorMunição.maxValue = Navezinha1.GetMuniçãoMaxima();
        ContadorMunição.minValue = 0;
        ContadorMunição.value = Navezinha1.GetMuniçãoNave();



        ContadorGasosa.maxValue = Navezinha1.GetGasolinaMaxima();
        ContadorGasosa.minValue = 0;
        ContadorGasosa.value = Navezinha1.GetGasolinaNave();

    }

    // Update is called once per frame
    void Update()
    {

        velocidade = Player.velocity.magnitude;
        ammo = Navezinha1.GetMuniçãoNave();
        maxammo = Navezinha1.GetMuniçãoMaxima();

        GasosaAtual = Navezinha1.GetGasolinaNave();
        MaxGasosa = Navezinha1.GetGasolinaMaxima();

        Player1Camera.transform.position =
            new Vector3(
                transform.position.x,
                transform.position.y + 13,
                transform.position.z
                );

        
        if (Navezinha1.GetGasolinaNave() > 0)
        {
            if (Input.GetButton("Player1Foward"))
            {
                
                Player.AddForce(Player.transform.forward * Navezinha1.GetMultVelocidade() * Time.deltaTime, ForceMode.Acceleration);
                if (Player.velocity.magnitude > Navezinha1.GetMaxVelocidade())
                {
                    Player.velocity = Player.velocity.normalized * Navezinha1.GetMaxVelocidade();
                }
            }
            

            if (Input.GetButton("Player1Backward"))
            {
               
                Player.AddForce(-Player.transform.forward * Navezinha1.GetMultVelocidade() * Time.deltaTime, ForceMode.Acceleration);
                if (Player.velocity.magnitude > Navezinha1.GetMaxVelocidade())
                {
                    Player.velocity = Player.velocity.normalized * Navezinha1.GetMaxVelocidade();
                }
            }
        }

        if (Input.GetButtonUp("Player1Foward"))
        {
            StopCoroutine(GasolinaMove());
        }

        if (Input.GetButton("Player1Left"))
        {
            Player.AddTorque(-Player.transform.up * Navezinha1.GetTorquenave() * Time.deltaTime, ForceMode.Acceleration);
        }

        if (Input.GetButton("Player1Right"))
        {
            Player.AddTorque(Player.transform.up * Navezinha1.GetTorquenave() * Time.deltaTime, ForceMode.Acceleration);
        }


        if (Navezinha1.GetMuniçãoNave() > 0)
        {
            if (Input.GetButtonDown("Player1Tiro"))
            {
                Navezinha1.AddMuniçãoNave(-1);
                CloneBala = Instantiate(PrefabBala, Arma1.transform);
                CloneBala.GetComponent<Classe_Tiro>().setParent(gameObject);
                CloneBala.GetComponent<Classe_Tiro>().Move();

                CloneBala2 = Instantiate(PrefabBala, Arma2.transform);
                CloneBala2.GetComponent<Classe_Tiro>().setParent(gameObject);
                CloneBala2.GetComponent<Classe_Tiro>().Move();
            }
        }
        SliderMuniçãoContador.text = Navezinha1.GetMuniçãoNave().ToString();
        SliderGasosaContador.text = Navezinha1.GetGasolinaNave().ToString();

        if(ContadorMunição.value > Navezinha1.GetMuniçãoMaxima() / 2 && ContadorMunição.value <= Navezinha1.GetMuniçãoMaxima())
        {
            SliderFill.GetComponent<Image>().color = Color.green;
        }
        if(ContadorMunição.value >= ((Navezinha1.GetMuniçãoMaxima()/2) /2) && ContadorMunição.value < Navezinha1.GetMuniçãoMaxima() / 2)
        {
            SliderFill.GetComponent<Image>().color = Color.yellow;
        }
        if(ContadorMunição.value < (Navezinha1.GetMuniçãoMaxima() / 2) /2)
        {
            SliderFill.GetComponent<Image>().color = Color.red;
        }

        ContadorMunição.value = Navezinha1.GetMuniçãoNave();




        if (ContadorGasosa.value > Navezinha1.GetGasolinaMaxima() / 2 && ContadorGasosa.value <= Navezinha1.GetGasolinaMaxima())
        {
            SliderGasosaFill.GetComponent<Image>().color = Color.green;
        }
        if (ContadorGasosa.value >= ((Navezinha1.GetGasolinaMaxima() / 2) / 2) && ContadorGasosa.value < Navezinha1.GetGasolinaMaxima() / 2)
        {
            SliderGasosaFill.GetComponent<Image>().color = Color.yellow;
        }
        if (ContadorGasosa.value < (Navezinha1.GetGasolinaMaxima() / 2) / 2)
        {
            SliderGasosaFill.GetComponent<Image>().color = Color.red;
        }





        ContadorGasosa.value = Navezinha1.GetGasolinaNave();


        IEnumerator GasolinaMove()
        {
            if(Navezinha1.GetGasolinaNave() > 0)
            {
                Navezinha1.AddGasolinaNave(-1);
                yield return new WaitForSeconds(1);
            }
        }
    }



      



}
