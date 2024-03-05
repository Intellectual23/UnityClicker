using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

namespace _Source.Core
{
  public class ProductionBuilding : MonoBehaviour
  {
    public GameResource _resource;
    public ResourceBank _resourceBank;
    public Button _button;
    public Slider _slider;
    public float _productionTime;

    private IEnumerator Coroutine()
    {
      _button.interactable = false;
      //yield return new WaitForSeconds(_productionTime);
      float curTime = 0;
      ObservableInt prodLvl = _resourceBank.GetProdLvl(_resource);
      float improvedProductionTime = _productionTime * (1 - prodLvl.Value / 100f);
      while (curTime < improvedProductionTime)
      {
        curTime += Time.deltaTime;
        _slider.value = (curTime / improvedProductionTime);
        yield return null;
      }

      _resourceBank.ChangeResource(_resource, 1);
      _button.interactable = true;
    }

    public void ButtonClick()
    {
      if (_button.interactable)
      {
        StartCoroutine(Coroutine());
      }
    }
  }
}