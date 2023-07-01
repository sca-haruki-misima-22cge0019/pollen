
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShotCre : MonoBehaviour
{
    [SerializeField] Image Drug;
    [SerializeField] GameObject DrugCount;
    public List<Sprite> DrugList = new List<Sprite>();
    private int drug = 10;
    public static int superdrug = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text DrugText = DrugCount.GetComponent<Text>();
        DrugText.text = drug.ToString();
        if (Time.timeScale != 0&&Input.GetKeyDown(KeyCode.Space))
        {
            if (drug >0)
            {
                drug --;
            }

        }

        if (drug == 0 && Input.GetKeyDown(KeyCode.R))
        {
            drug = 10;

        }
        Drug.sprite = DrugList[drug];
    }

}
