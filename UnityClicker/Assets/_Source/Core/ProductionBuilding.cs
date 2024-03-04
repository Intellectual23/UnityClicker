using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
  public class ProductionBuilding : MonoBehaviour
  {
    public GameResource _resource;
    public ResourceBank _resourceBank;

    public void ButtonClick()
    {
      _resourceBank.ChangeResource(_resource, 1);
    }
  }
}