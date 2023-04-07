using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulidscript : MonoBehaviour
{
    // Save 2 obj. red and blue in array
    public GameObject[] matArray = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        // call Puff every 2 seconds
        InvokeRepeating("Puff", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Pop random blocks in random location and make them toward to player
    void Puff()
    {
        // Random # generator 0 or 2
        int newC = (Random.Range(0, 100) % 3);
        // Boundary for obj. spawning.
        float newx = Random.Range(-2.0f, 2.0f);
        float newy = Random.Range(10f, 20f);
        float newz = Random.Range(-2f, 2f);

        GameObject CubeM = Instantiate(matArray[newC]);
        CubeM.transform.position = new Vector3(newx, newy, newz);

        Rigidbody rb = CubeM.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, -2f, 0);
    }
}
