using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulidscript1 : MonoBehaviour
{
    // Save 2 obj. red and blue in array
    public GameObject[] matArray = new GameObject[1];

    // Start is called before the first frame update
    void Start()
    {
        // call Puff every 2 seconds
        InvokeRepeating("Puff", 11, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Pop random blocks in random location and make them toward to player
    void Puff()
    {
   
        GameObject CubeM = Instantiate(matArray[0]);
    }
}
