using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class enemy : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�ǂ�������Ώ�")]
    private GameObject player;

    private NavMeshAgent navMeshAgent;

    public float speed = 3;
    public enum ENEMY_TYPE
    {
        LINE,//�܂������i��
        CURVE,//�㉺�ɃJ�[�u
        TRACKING
    }
    public ENEMY_TYPE type = ENEMY_TYPE.CURVE;
    public float cycleCount = 1;    // �P�b�Ԃɉ��������
    public float curveLength = 2;   // �J�[�u�̍ő勗��
    float cycleRadian = 0;          // �T�C���ɓn���l
    float centerY;                  // Y���W�̒��S
    // Start is called before the first frame update
    void Start()
    {
        centerY = transform.position.y;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        // �㉺�ɃJ�[�u
        if (type == ENEMY_TYPE.CURVE)
        {
            if (cycleCount > 0)
            {
                cycleRadian += (cycleCount * 2 * Mathf.PI) / 50;
                pos.y = Mathf.Sin(cycleRadian) * curveLength + centerY;
            }
        }
        pos += -transform.right * speed * Time.fixedDeltaTime;

        transform.position = pos;

        if (type == ENEMY_TYPE.TRACKING)
        {
            navMeshAgent.destination = player.transform.position;
        }
    }
}
