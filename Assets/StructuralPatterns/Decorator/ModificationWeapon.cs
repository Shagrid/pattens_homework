using UnityEngine;

namespace Decorator
{
    public abstract class ModificationWeapon
    {
        public abstract void AddModification(Weapon weapon);
        public virtual void RemoveModification(Weapon weapon, ModificationWeaponType type)
        {
            weapon.RemoveModification(type);
        }
    }
}
