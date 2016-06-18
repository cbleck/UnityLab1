using UnityEngine;
using System.Collections;

public class Transformer2 : MonoBehaviour {

    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {

        //Rotamos el objeto
        transform.Rotate(
            rotationSpeed * Time.deltaTime,
            0f,
            0f,
            Space.Self);
    }
}
