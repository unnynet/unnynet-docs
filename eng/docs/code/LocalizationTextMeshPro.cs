using TMPro;
using UnityEngine;
using UnnyNet;

[RequireComponent(typeof(TMP_Text))]
public class LocalizationTextMeshPro : LocalizationUI
{
    private TMP_Text _component;

    private void Awake()
    {
        _component = GetComponent<TMP_Text>();
        SetTextValue();
    }

    protected override void OnLocalizationChanged(string localizationCode)
    {
        SetTextValue();
    }

    void SetTextValue()
    {
        if (_component != null)
            _component.text = GetLocalization();
    }
}
