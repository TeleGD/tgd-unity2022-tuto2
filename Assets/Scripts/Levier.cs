using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier : MonoBehaviour
{
    public GameObject ennemy;
    public GameObject keyCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("test trigger");
        if(other.gameObject.name == keyCube.gameObject.name)
        {
            Debug.Log("Piège retiré.");
            Destroy(ennemy);
        }
    }
}
