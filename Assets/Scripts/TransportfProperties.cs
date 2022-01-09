
using UnityEngine;
using UnityEngine.UI;

public class TransportfProperties: MonoBehaviour
{
    [Header("Масса Транспорта")]
    public float _weight;
    [Header("Вместимость Транспорта")]
    public int _capacity;
    [Header("Макс. скорость Транспорта")]
    public float _maxSpeed;
    [Header("Название Транспорта")]
    public string _titleTransport;
    [Header("Уникаольное свойство Транспорта")]
    public string _uniqueProperty;
    [Header("Название уникаольного свойство Транспорта")]
    public string _uniquePropertyTitle;
    [Header("Масса ТекстUI")]
    public Text _weightText;
    [Header("Вместимость ТекстUI")]
    public Text _capacityText;
    [Header("Макс. скорость ТекстUI")]
    public Text _maxSpeedText;
    [Header("Название транспорта ТекстUI")]
    public Text _titleTransportText;
    [Header("Уникальное свойство ТекстUI")]
    public Text _uniquePropertyText;
    [Header("Название уникального свойства ТекстUI")]
    public Text _uniquePropertyTitleText;
        

    private void Start()
    {
        _weightText.text = "" + _weight;
        _capacityText.text = "" + _capacity;
        _maxSpeedText.text = "" + _maxSpeed;
        _titleTransportText.text = _titleTransport;
        _uniquePropertyText.text = "" +_uniqueProperty;
        _uniquePropertyTitleText.text = _uniquePropertyTitle+"-";
    }

   
}
