using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
  public class ResourceBank : MonoBehaviour
  {
    private Dictionary<GameResource, ObservableInt> _resourcesInfo = new Dictionary<GameResource, ObservableInt>()
    {
      { GameResource.Humans, new ObservableInt(0) },
      { GameResource.Food, new ObservableInt(0) },
      { GameResource.Wood, new ObservableInt(0) },
      { GameResource.Stone, new ObservableInt(0) },
      { GameResource.Gold, new ObservableInt(0) },
      { GameResource.HumansProdLvl, new ObservableInt(0) },
      { GameResource.FoodProdLvl, new ObservableInt(0) },
      { GameResource.WoodProdLvl, new ObservableInt(0) },
      { GameResource.StoneProdLvl, new ObservableInt(0) },
      { GameResource.GoldProdLvl, new ObservableInt(0) },
    };

    public void ChangeResource(GameResource r, int v)
    {
      _resourcesInfo[r].Value += v;
    }

    public ObservableInt GetResource(GameResource r)
    {
      return _resourcesInfo[r];
    }

    public ObservableInt GetProdLvl(GameResource r)
    {
      if (r == GameResource.Humans)
      {
        return _resourcesInfo[GameResource.HumansProdLvl];
      }

      if (r == GameResource.Food)
      {
        return _resourcesInfo[GameResource.HumansProdLvl];
      }
      
      if (r == GameResource.Wood)
      {
        return _resourcesInfo[GameResource.WoodProdLvl];
      }
      
      if (r == GameResource.Stone)
      {
        return _resourcesInfo[GameResource.StoneProdLvl];
      }
      if (r == GameResource.Gold)
      {
        return _resourcesInfo[GameResource.GoldProdLvl];
      }
      return new ObservableInt(0);
    }
  }
}