using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_Hp = 5;     //몬스터 Hp 선언

    public void Damanged(int Damage)
    {
        Monster_Hp -= Damage;

        if(Monster_Hp < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
