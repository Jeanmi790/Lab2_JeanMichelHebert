using System.Collections.Generic;
using UnityEngine;

public class ZonePieges : MonoBehaviour
{
    // Start is called before the first frame update
    bool actif = false;
    [SerializeField] List<GameObject> _Listepieges = new List<GameObject>();
    [SerializeField] float intensiteForce = 500;
    List<Rigidbody> _rbPiege = new List<Rigidbody>();

    void Start()
    {
        foreach(var piege in _Listepieges) { 
            _rbPiege.Add(piege.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((!actif) && (other.gameObject.tag == "Player"))
        {
            foreach(var rb in _rbPiege) { 
            rb.useGravity = true;
            rb.AddForce(Vector3.down * intensiteForce, ForceMode.Force);
            }
        }
    }



    //// Update is called once per frame
    //void Update()
    //{

    //}
}
