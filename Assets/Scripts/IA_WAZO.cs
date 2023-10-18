using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_WAZO : MonoBehaviour
{
    public NavMeshAgent ai;
    public Transform player;
    public Animator aiAnim;
    Vector3 dest;

    // Update is called once per frame
    void Update()
    {
        dest = player.position;
        ai.destination = dest;
        if(ai.remainingDistance <=ai.stoppingDistance)
        {
            aiAnim.ResetTrigger("walk");
            aiAnim.SetTrigger("idle");
        }
        else
        {
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("walk");
        }
    }
}
