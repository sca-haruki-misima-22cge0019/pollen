using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHp : MonoBehaviour
{
    public static int hp;
    private int maxhp = 5;
    private float nowhp;
    [SerializeField] Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        hp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SuperDrug")
        {
            other.gameObject.SetActive(false);
            StartCoroutine(DecreaseHPAnimation(maxhp, --hp));
            if (slider.value <= 0.0f)
            {
                SceneManager.LoadScene("GameClearSceneFinal");
            }
        }
    }
    IEnumerator DecreaseHPAnimation(int oldHP, int newHP)
    {
        nowhp = (float)newHP / (float)oldHP;
        Debug.Log(nowhp);
        while (slider.value >= nowhp)
        {
            slider.value -= 0.001f;
            yield return null;
        }
       
        Debug.Log(slider.value);
    }
}
