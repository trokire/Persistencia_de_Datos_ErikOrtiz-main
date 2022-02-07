using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSave : MonoBehaviour
{
    public float posX;
    public float posY=0.5f;
    public float posZ;

    public string checkpoint;

    public Vector3 Posicion;


    void Start()
    {
        LoadPos();
    }

    void Update()
    {
       checkpoint = PlayerPrefs.GetString("Collider");
    }

    public void SavePos()
    {
       PlayerPrefs.SetFloat("PosX", transform.position.x);
       PlayerPrefs.SetFloat("PosY", transform.position.y);
       PlayerPrefs.SetFloat("PosZ", transform.position.z);


    }

    public void LoadPos()
    {
       posX = PlayerPrefs.GetFloat("PosX");
       posY = PlayerPrefs.GetFloat("PosY");
       posZ = PlayerPrefs.GetFloat("PosZ");

       Posicion.x = posX;
       Posicion.y = posY;
       Posicion.z = posZ;

       transform.position = Posicion;

        checkpoint = PlayerPrefs.GetString("Collider");

    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "checkpoint")
        {
           PlayerPrefs.SetString("Collider", other.gameObject.name);
           SavePos();
        }
    }
}
