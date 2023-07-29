using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WeaponInfo : MonoBehaviour
{
    [SerializeField] private WeaponConfig _weaponConfig;
    [SerializeField] private Image _weaponImage;
    [SerializeField] private TMP_Text _weaponText;


    // Start is called before the first frame update
    void Start()
    {
        _weaponImage.sprite = _weaponConfig.Icon;
        _weaponText.text = $"{_weaponConfig.Name}\nDamage: {_weaponConfig.Damage}";
    }

}
