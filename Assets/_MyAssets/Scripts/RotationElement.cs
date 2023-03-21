using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationElement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rotation = 0.54f;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotation*Time.deltaTime, 0f);
    }
}
