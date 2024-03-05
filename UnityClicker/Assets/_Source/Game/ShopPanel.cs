using System.Collections;
using System.Collections.Generic;
using _Source.Core;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Game
{
  public class ShopPanel : MonoBehaviour
  {
    public ResourceBank _resourceBank;
    
    public void UpgradeHumansProdLvl()
    {
      _resourceBank.ChangeResource(GameResource.HumansProdLvl, 1);
    }

    public void UpgradeFoodProdLvl()
    {
      _resourceBank.ChangeResource(GameResource.FoodProdLvl, 1);
    }

    public void UpgradeWoodProdLvl()
    {
      _resourceBank.ChangeResource(GameResource.WoodProdLvl, 1);
    }

    public void UpgradeStoneProdLvl()
    {
      _resourceBank.ChangeResource(GameResource.StoneProdLvl, 1);
    }

    public void UpgradeGoldProdLvl()
    {
      _resourceBank.ChangeResource(GameResource.GoldProdLvl, 1);
    }
  }
}