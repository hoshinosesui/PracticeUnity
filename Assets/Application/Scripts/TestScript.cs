using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //
    public int hp = 100;
    public int attack = 70;
    public int defence = 40;

    // Start is called before the first frame update
    void Start()
    {
        CalcHp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //HP���v�Z����֐�
    public int CalcHp() 
    {
        hp = hp - (attack - defence);

        return hp;
    }
}
