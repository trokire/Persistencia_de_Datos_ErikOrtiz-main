using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    
    public PositionSave positionSave;
    public Text actualCheckpoint;
    


    // Start is called before the first frame update
    void Start()
    {
        positionSave = GameObject.Find("Player").GetComponent<PositionSave>();
    }

    // Update is called once per frame
    void Update()
    {
        actualCheckpoint.text = positionSave.checkpoint.ToString();
    }

    
}
