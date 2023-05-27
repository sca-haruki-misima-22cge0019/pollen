using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrugCount : MonoBehaviour
{
    [SerializeField] GameObject DrugObject;
    public int drug;

    [SerializeField] GameObject Bos;
    private float speed= 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text DrugText = DrugObject.GetComponent<Text>();
        DrugText.text = "Ç†Ç∆" + drug+"ÉR";

        if(drug == 5)
        {
            Bos.transform.position -= new Vector3(Time.deltaTime * speed, 0.0f);
        }
        if(Bos.transform.position.x <6.0f)
        {
            speed = 0.0f;
        }
    }
}
