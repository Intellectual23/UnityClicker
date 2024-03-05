using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
  public class ProductionBuilding : MonoBehaviour
  {
    public GameResource _resource;
    public ResourceBank _resourceBank;
    public float _productionTime = 4;
    private bool isBlocked = false;

    private IEnumerator Coroutine()
    {
      isBlocked = true;
      yield return new WaitForSeconds(_productionTime);
      _resourceBank.ChangeResource(_resource, 1);
      isBlocked = false;
    }
    public void ButtonClick()
    {
      if (!isBlocked)
      {
        StartCoroutine(Coroutine());
      }
    }
  }
}