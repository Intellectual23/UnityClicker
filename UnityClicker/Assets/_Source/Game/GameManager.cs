using _Source.Core;
using UnityEngine;

namespace _Source.Game
{
  public class GameManager : MonoBehaviour
  {
    public ResourceBank _resourceBank;

    public void Awake()
    {
      _resourceBank.ChangeResource(GameResource.Humans, 10);
      _resourceBank.ChangeResource(GameResource.Food, 5);
      _resourceBank.ChangeResource(GameResource.Wood, 5);
    }
  }
}