using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy�̗̑͗p�ϐ�
    private int enemyHP;
    void Start()
    {
        //�������ɑ̗͂��w�肵�Ă���
        enemyHP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //�����̗͂�0�ȉ��ɂȂ�����
        if(enemyHP <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
        }
        
    }

    public void Damage()
    {
        enemyHP = enemyHP - 1;
    }
}
