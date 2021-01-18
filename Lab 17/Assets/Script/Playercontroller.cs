using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{

    public float speed;
    public float rotation;

    public GameObject Bulletprefads;
    public GameObject bulletSpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalinput = Input.GetAxis("Vertical");
        float horizontalinput = Input.GetAxis("Horizontal");



        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            transform.Rotate(-Vector3.up * rotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(Vector3.right * Time.deltaTime * speed);
            transform.Rotate(Vector3.up * rotation * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bulletprefads, bulletSpawn.transform.position, transform.rotation);
        }
    }
}
