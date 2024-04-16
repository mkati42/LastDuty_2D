using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOneOpen : MonoBehaviour
{
    private GameObject boss;
    private Rigidbody2D rbBoss;
    private EnemyControll bossControl;

    void Start()
    {
        boss = GameObject.Find("boss");
        rbBoss = boss.GetComponent<Rigidbody2D>();
        bossControl = rbBoss.GetComponent<EnemyControll>();
    }

    void Update()
    {
        if (bossControl.isDeadBoss == true)
            gateOpen();
    }

    private void gateOpen()
    {
        Destroy(gameObject);
    }
}
