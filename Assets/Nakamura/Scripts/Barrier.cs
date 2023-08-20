using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject Effect;
    [SerializeField] GameObject count;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SuperDrug")
        {
            Instantiate(Effect,other.gameObject.transform.position, Quaternion.identity);
            other.gameObject.SetActive(false);

            if(count.GetComponent<Text>().text=="0")
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}
