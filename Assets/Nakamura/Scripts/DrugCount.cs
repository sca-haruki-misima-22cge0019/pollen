using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrugCount : MonoBehaviour
{
    [SerializeField] GameObject DrugObject;
    [SerializeField] GameObject Nose;
    hit hp;
    public int drug;
    private float Bostime = 0.0f;
    private float Normaltime = 0.0f;
    private int count= 0;
    [SerializeField]Fade fade;
    // Start is called before the first frame update
    void Start()
    {
        hp = Nose.GetComponent<hit>();
        if (SceneManager.GetActiveScene().name == "Bos")
        {
            drug = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(hp.energy>=0)
        {
            if (SceneManager.GetActiveScene().name == "Bos" && drug == 0)
            {
                Bostime += Time.deltaTime;
                if (Bostime >= 7.0f)
                {
                    SceneManager.LoadScene("GameOverScene");
                }
            }

            Text DrugText = DrugObject.GetComponent<Text>();
            DrugText.text = drug.ToString();

            if (SceneManager.GetActiveScene().name == "Stage1" && drug == 0)
            {
                Normaltime += Time.deltaTime;
                if (Normaltime >= 0.3f)
                {
                    fade.FadeIn(0.5f, () => print("フェードイン完了"));
                    Invoke("Clear", 0.6f);
                    Normaltime = 0.0f;
                }

            }
            if (SceneManager.GetActiveScene().name == "Stage2" && drug == 0)
            {
                Normaltime += Time.deltaTime;
                if (Normaltime >= 0.2f)
                {
                    fade.FadeIn(0.5f, () => print("フェードイン完了"));
                    Invoke("Clear", 0.6f);
                    Normaltime = 0.0f;
                }

            }

            if (Item.drug)
            {
                count++;
                if (count == 2)
                {
                    drug--;
                    count = 0;
                }

                Item.drug = false;
            }
        }
    }

    void Clear()
    {
        if(SceneManager.GetActiveScene().name == "Stage1")
        {
            SceneManager.LoadScene("GameClearSceneStage1");
        }
        else
        {
            SceneManager.LoadScene("GameClearSceneStage2");
        }
        
    }
}
