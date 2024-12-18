using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public int velocidad;
    public Vector3 direccion1;
    public Vector3 direccion2;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    
    // Start is called before the first frame update
    void Start()
    {
        player1.transform.position = new Vector3(-2, 0, 0); //Movemos de (0,0) a la posicion q le decimos
        player2.transform.position = new Vector3(2, 0, 0); //Movemos de (0,0) a la posicion q le decimos
    }

    // Update is called once per frame
    void Update()
    {
        direccion1 = new Vector3(0, 0, 0); 
        direccion2 = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direccion1 += Vector3.right;
            direccion2 += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direccion1 += Vector3.left;
            direccion2 += Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direccion1 += Vector3.up;
            direccion2 += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direccion1 += Vector3.down;
            direccion2 += Vector3.down;
        }


        if (Input.GetKey(KeyCode.D))
        {
            direccion1 += Vector3.left;
            direccion2 += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direccion1 += Vector3.right;
            direccion2 += Vector3.left;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direccion1 += Vector3.down;
            direccion2 += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direccion1 += Vector3.up;
            direccion2 += Vector3.down;
        }

        if (direccion1.x != 0 || direccion1.y != 0)
        {
            direccion1 = direccion1.normalized;
        }

        if (direccion2.x != 0 || direccion2.y != 0)
        {
            direccion2 = direccion2.normalized;
        }


        player1.transform.position += direccion1 * velocidad * Time.deltaTime;
        player2.transform.position += direccion2 * velocidad * Time.deltaTime;

    }
}

