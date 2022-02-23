using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEvents
{
    public delegate void OnWeaponEquippedEvent(WeaponComponent weaponComponent);

    public static event OnWeaponEquippedEvent OnWeaponEquipeed;
    
    public static void InvokeOnWEaponEquipped(WeaponComponent weaponComponent)
    {
        OnWeaponEquipeed?.Invoke(weaponComponent);
    }
}
