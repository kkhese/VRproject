using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killscript : MonoBehaviour
{
    // Save 2 obj. red and blue in array
    public GameObject[] matArray = new GameObject[2];
   
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
        // Random # generator 0 or 1
        int newC = (Random.Range(0, 100) % 2);
        // Boundary for obj. spawning.
        float newx = Random.Range(-4f, 4f);
        float newy = Random.Range(0f, 3f);
        float newz = Random.Range(0.6f, 8f);

        GameObject CubeM = Instantiate(matArray[newC]);
        CubeM.transform.position = new Vector3(newx, newy, newz);

        Rigidbody rb = CubeM.GetComponent<Rigidbody>();
        rb.velocity = new Vector3((0.0f - newx), (0.5f - newy), ((-1.0f) - newz));
    }
}
