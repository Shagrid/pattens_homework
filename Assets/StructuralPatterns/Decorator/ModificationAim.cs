using UnityEngine;

namespace Decorator
{
    public sealed class ModificationAim : ModificationWeapon
    {
        public override void AddModification(Weapon weapon)
        {
            var aim = Object.Instantiate(Resources.Load<GameObject>(AssetPath.Modifications[ModificationWeaponType.Aim]),
                weapon.OpticPosition(), Quaternion.identity, weapon.transform);
            weapon.AddModification(ModificationWeaponType.Aim, aim);
        }

       
    }
}