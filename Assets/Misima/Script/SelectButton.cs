using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SelectButton : MonoBehaviour
{
    [SerializeField] List<Button>buttons;
    [SerializeField] List<bool>keys;

    public int Selected
    {
        get
        {
            for(int i = 0; i < keys.Count; i++)
            {
                if(keys[i])
                    return i;
            }

            return -1;
        }
    }

    public IEnumerator CorGetInput()
    {
        {
            //keys�����ׂ�false�ɂ���
            for (int i = 0; i < keys.Count; i++)
            {
                keys[i] = false;
            }

            //�Q�[���I�u�W�F�N�g��\��
            gameObject.SetActive(true);

            //�����ꂩ�̃{�^�����������܂őҋ@
            yield return new WaitWhile(() => Selected == -1);

            //�Q�[���I�u�W�F�N�g���\��
            gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //keys��buttons�Ɠ���������
        keys = Enumerable.Repeat(false, buttons.Count).ToList();


        //�e�{�^���ɏ��������蓖�Ă�
        for (int i = 0; i < buttons.Count; i++)
        {
            //��U�ʂ̕ϐ��Ɋi�[���Ȃ��ƃG���[����
            int a = i;

            //button�������ƊY������key��true��
            buttons[a].onClick.AddListener(() => keys[a] = true);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
