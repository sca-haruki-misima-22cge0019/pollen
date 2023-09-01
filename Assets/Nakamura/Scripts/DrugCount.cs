using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrugCount : MonoBehaviour
{
    [SerializeField] GameObject DrugObject;
    public int drug;
    private float Bostime = 0.0f;
    private float Normaltime = 0.0f;
    private int count= 0;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Bos")
        {
            drug = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Bos" && drug == 0)
        {
            Bostime +=Time.deltaTime;
            if(Bostime >=7.0f)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }

        Text DrugText = DrugObject.GetComponent<Text>();
        DrugText.text = drug.ToString();

        if (SceneManager.GetActiveScene().name == "Stage1" && drug==0)
        {
            Normaltime += Time.deltaTime;
            if(Normaltime >=0.3f)
            {
                SceneManager.LoadScene("GameClearSceneStage1");
                Normaltime = 0.0f;
            }
            
        }
        if (SceneManager.GetActiveScene().name == "Stage2" && drug == 0)
        {
            Normaltime += Time.deltaTime;
            if (Normaltime >= 0.2f)
            {
                SceneManager.LoadScene("GameClearSceneStage2");
                Normaltime = 0.0f;
            }
                
        }

        if(Item.drug)
        {
            count++;
            if(count == 2)
            {
                drug--;
                count = 0;
            }
           
            Item.drug = false;
        }
        if(Input.GetKeyDown(KeyCode.M)&& SceneManager.GetActiveScene().name == "Bos")
        {
            if(drug >0)
            {
                drug--;
            }
        }
    }
}
