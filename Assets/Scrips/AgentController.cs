using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AgentController : MonoBehaviour
{
    // Start is called before the first frame update
  UnityEngine.AI.NavMeshAgent myNavMeshAgent;
  public Transform target;
    void Start()
    {
        myNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
      myNavMeshAgent.SetDestination(target.position);  
    }

}
