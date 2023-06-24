
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotCre : MonoBehaviour
{
    [SerializeField] GameObject Shot;
    [SerializeField] GameObject superShot;
    [SerializeField] Image Drug;
    [SerializeField] GameObject DrugCount;
    public List<Sprite> DrugList = new List<Sprite>();
    private int drug = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0&&Input.GetKeyDown(KeyCode.Space))
        {
            drug--;
           

            if (drug == -1)
            {
                drug = 10;
            }
            Text DrugText = DrugCount.GetComponent<Text>();
            DrugText.text = drug.ToString();
            Instantiate(Shot, new Vector3(-7.8f, 0.0f), Quaternion.identity);
        }
        Drug.sprite = DrugList[drug];

        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(superShot, new Vector3(-7.8f, 0.0f), Quaternion.identity);
        }
    }

}
