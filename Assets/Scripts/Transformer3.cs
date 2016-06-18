using UnityEngine;
using System.Collections;

public class Transformer3 : MonoBehaviour {

    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue);
    }

    // Update is called once per frame
    void Update()
    {

        //Rotamos el objeto
        transform.Rotate(
            0f,
            rotationSpeed * Time.deltaTime,
            0f,
            Space.Self);
    }
}
