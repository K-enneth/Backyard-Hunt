using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstracZone : MonoBehaviour
{

  public List<GameObject> enemyList;
  public List<GameObject> allyList;
  public float timeRemaining;
  public Vector3 position;

  public void getMajorPopulation()
  {
  }

  public void addEnemy(GameObject enemy)
  {
  }

  public void addAlly(GameObject ally)
  {
  }

  public void deleteEnemy(GameObject enemy)
  {
  }

  public void spreadLooser()
  {
  }

  public abstract Vector3 GetForce();


}
