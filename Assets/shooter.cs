using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private newScript lanceur;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        lanceur = GetComponent<newScript>();
        direction = lanceur.GetDirection();
    }

    // Update is called once per frame
    void Update()
    {
        direction = lanceur.GetDirection();
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, this.transform.position + direction, Quaternion.identity);
    }
}
