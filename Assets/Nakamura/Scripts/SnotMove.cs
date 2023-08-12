using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnotMove : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite nose2;
    [SerializeField] private GameObject front2;
    [SerializeField] private Sprite nose3;
    [SerializeField] private GameObject front3;
    [SerializeField] private GameObject GaneOver;
    [SerializeField] private GameObject HitOb;
    float rndtime;
    [SerializeField] float SnotMinTime;
    [SerializeField] float SnotMaxTime;
    private Animator NoseAnim;
    private Animator GameOverAnim;
    private float elapsetime;
    public bool GameOverRoll = false;
    // Start is called before the first frame update
    void Start()
    {
        NoseAnim = gameObject.GetComponent<Animator>();
        GameOverAnim = GaneOver.GetComponent<Animator>();
        rndtime = Random.Range(SnotMinTime, SnotMaxTime);
    }

    // Update is called once per frame
    void Update()
    {
        hit damage;
        damage = HitOb.GetComponent<hit>();
        if(damage.energy == 0)
        {
            NoseAnim.SetBool("DieBL", true);
        }
        
        if(spriteRenderer.sprite == nose2)
        {
            Debug.Log("BBB");
            front2.SetActive(true);
            elapsetime += Time.deltaTime;
            if(elapsetime >= rndtime)
            {
                NoseAnim.SetBool("SnotMoveBL", true);
            }
        }

        if (spriteRenderer.sprite == nose3)
        {
            Debug.Log("AAA");
            front2.SetActive(false);
            front3.SetActive(true);
            Debug.Log(front3.activeSelf);
            elapsetime += Time.deltaTime;
            if (elapsetime >= rndtime)
            {
                NoseAnim.SetBool("SnotMoveBL2", true);
            }
        }
    }

    public void SnotStop()
    {
        Debug.Log("S");
        NoseAnim.SetBool("SnotMoveBL", false);
        rndtime = Random.Range(SnotMinTime, SnotMaxTime);
        elapsetime = 0.0f;
    }

    public void SnotStop2()
    {
        Debug.Log("S");
        NoseAnim.SetBool("SnotMoveBL2", false);
        rndtime = Random.Range(SnotMinTime, SnotMaxTime);
        elapsetime = 0.0f;
    }

    public void Die()
    {
        GameOverAnim.SetBool("GameOverBL", true);
        GameOverRoll = true;
    }
}
