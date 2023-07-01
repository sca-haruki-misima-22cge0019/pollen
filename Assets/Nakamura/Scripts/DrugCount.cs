using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrugCount : MonoBehaviour
{
    [SerializeField] GameObject DrugObject;
    public int drug;
    private float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text DrugText = DrugObject.GetComponent<Text>();
        DrugText.text = drug.ToString();

        if (SceneManager.GetActiveScene().name == "Stage1" && drug==0)
        {
            SceneManager.LoadScene("GameClearSceneStage1");
        }
        if (SceneManager.GetActiveScene().name == "Stage2" && drug == 0)
        {
            SceneManager.LoadScene("GameClearSceneStage2");
        }

        if (SceneManager.GetActiveScene().name == "Bos")
        {
            drug = ShotCre.superdrug;
            if(drug <=0)
            {
                
                time += Time.deltaTime;
                Debug.Log(time);
                if (time >= 2.0f)
                {
                    SceneManager.LoadScene("GameOverScene");
                }
            }
        }
        else
        {
            if(Item.drug)
            {
                drug--;
                Item.drug = false;
            }
            
        }
    }
}
