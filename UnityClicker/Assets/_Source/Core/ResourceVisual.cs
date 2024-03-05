using UnityEngine;
using TMPro;

namespace _Source.Core
{
  public class ResourseVisual : MonoBehaviour
  {
    public GameResource _resourceType;
    public ResourceBank _resourceBank;
    public TextMeshProUGUI _text;

    void Start()
    {
      //_resourceBank = FindObjectOfType<ResourceBank>();
      if (_resourceBank != null)
      {
        int newValue = _resourceBank.GetResource(_resourceType).Value;
        _resourceBank.GetResource(_resourceType).OnClick += UpdateText;
        UpdateText(newValue);
      }
    }

    private void UpdateText(int newValue)
    {
      _text.text = _resourceType.ToString() + ": " + newValue.ToString();
    }
  }
}