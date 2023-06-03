using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrugCount : MonoBehaviour
{
    [SerializeField] GameObject DrugObject;
    public int drug;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text DrugText = DrugObject.GetComponent<Text>();
        DrugText.text = "Ç†Ç∆" + drug+"ÉR";

        if(drug == 0)
        {
            SceneManager.LoadScene("ClearScene1");
        }
    }
}
