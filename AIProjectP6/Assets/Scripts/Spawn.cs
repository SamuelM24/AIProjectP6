using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{
    public GameObject patientPrefab;
    public int numPatients;

    void Start()
    {
        Invoke("SpawnPatient", 5.0f);
    }

    void SpawnPatient() {

        Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        Invoke("SpawnPatient", Random.Range(2.0f, 10.0f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
