using UnityEngine;

[CreateAssetMenu(fileName ="WeaponConfig", menuName = "Configs/Weapon", order = 0)]
public class WeaponConfig : ScriptableObject
{
    public Sprite Icon;
    public string Name;
    public float Damage;
}
