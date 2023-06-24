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
        DrugText.text = drug.ToString();

        if (SceneManager.GetActiveScene().name == "Stage1" && drug==0)
        {
            SceneManager.LoadScene("GameClearSceneStage1");
        }
        if (SceneManager.GetActiveScene().name == "Stage2" && drug == 0)
        {
            SceneManager.LoadScene("GameClearSceneStage2");
        }

        if (SceneManager.GetActiveScene().name == "Bos" && drug == 0)
        {
            float time =0.0f;
            time +=Time.deltaTime;
            if(time >=3.0f)
            {
                SceneManager.LoadScene("GameOverScene");
            }
            
        }
    }
}
