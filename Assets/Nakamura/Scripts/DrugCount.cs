using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrugCount : MonoBehaviour
{
    [SerializeField] GameObject DrugObject;
    private int drug = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text DrugText = DrugObject.GetComponent<Text>();
        DrugText.text = "Žc‚è" + drug+"ƒR";
    }
}
