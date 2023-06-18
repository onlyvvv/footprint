using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject Cake;
    public GameObject Book;
    public GameObject Vase;
    public GameObject Flowerpot;
    public GameObject CameraC;
    private Transform transformCamra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transformCamra = CameraC.GetComponent<Transform>();
    }
    public void SpawnCake()
    {
        
        Vector3 a = new Vector3(-2.183f, 1.787f, -10.638f);
        
        Cake.transform.position = a;
        Instantiate(Cake);

    }
    public void Spawnflowerpot()
    {

        Vector3 b = new Vector3(-1.906f, 1.721f, -3.386f);

        Flowerpot.transform.position = b;
        Instantiate(Flowerpot);

    }
    public void Spawnvase()
    {

        Vector3 c = new Vector3(-0.534f, 0.287f, -3.412f);

        Vase.transform.position = c;
        Instantiate(Vase);

    }
    public void Spawnbook()
    {

        Vector3 d = new Vector3(-0.193f, 1.52f, -1.942f);

        Book.transform.position = d;
        Instantiate(Book);

    }
}
