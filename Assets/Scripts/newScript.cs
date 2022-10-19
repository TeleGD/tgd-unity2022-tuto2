using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript : MonoBehaviour
{
    public float speed;
    private Vector3 vecteurCube;

    public GameObject cam;
    private Vector3 direction = new Vector3(1,0,0);

    private shooter shoot;

    // Start is called before the first frame update
    void Start()
    {
        vecteurCube = cam.transform.position - transform.position;
        shoot = GetComponent<shooter>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = transform.position + vecteurCube;

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0,0)*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0,0,-speed)*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += new Vector3(0,0,speed)*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            shoot.Shoot();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Touché");
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
        }
        
    }

    public Vector3 GetDirection()
    {
        return direction;
    }
}
