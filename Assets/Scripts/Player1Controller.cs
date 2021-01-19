using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public Rigidbody Player;
    public Camera Player1Camera;

    Classe_NavePlayer1 Navezinha1;

    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.GetComponent<Rigidbody>();
        Navezinha1 = new Classe_NavePlayer1(10,250,Player,180,25);
        Player1Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        velocidade = Player.velocity.magnitude;



        Player1Camera.transform.position =
            new Vector3(
                transform.position.x,
                transform.position.y + 13,
                transform.position.z
                );


            if (Input.GetButton("Player1Foward"))
            {
                Player.AddForce(Player.transform.forward * Navezinha1.GetMultVelocidade() * Time.deltaTime, ForceMode.Acceleration);
                    if(Player.velocity.magnitude > Navezinha1.GetMaxVelocidade())
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


        if (Input.GetButton("Player1Left"))
        {
            Player.AddTorque(-Player.transform.up * Navezinha1.GetTorquenave() * Time.deltaTime, ForceMode.Acceleration);
        }

        if (Input.GetButton("Player1Right"))
        {
            Player.AddTorque(Player.transform.up * Navezinha1.GetTorquenave() * Time.deltaTime, ForceMode.Acceleration);
        }





    }
}
