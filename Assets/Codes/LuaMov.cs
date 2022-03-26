using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaMov : MonoBehaviour
{

    public GameObject Terra;
    public float trans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.RotateAround(Terra.transform.position, Vector3.up, trans);
    }
}
