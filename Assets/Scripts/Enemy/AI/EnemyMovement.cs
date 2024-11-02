using Configs.Enemy.Movement;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
   [SerializeField] private EnemyMovementCfg _movementCfg;
   [SerializeField] private NavMeshAgent _agent;
   [SerializeField] private Transform[] _points;

   [SerializeField] private int _currentPointIndex = 0;
   
   private void Awake()
   {
      _agent.speed = _movementCfg.Speed;
      _agent.SetDestination(_points[0].position);
   }

   private void Update()
   {
      if(_agent.remainingDistance >= 1f)
         return;
      if (_currentPointIndex >= _points.Length - 1)
         _currentPointIndex = 0;
      else
         _currentPointIndex++;
      _agent.SetDestination(_points[_currentPointIndex].position);
   }
}
