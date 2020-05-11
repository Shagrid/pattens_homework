using UnityEngine;


namespace Decorator
{
    
    /// <summary>
    /// Добавить прицел и удалить прицел и глушитель
    /// </summary>
    public sealed class DecoratorTest : MonoBehaviour
    {
        [SerializeField] private Weapon _weapon;
        private ModificationMuffler _modificationMuffler;
        private ModificationAim _modificationAim;
        
        private void Start()
        {
            _modificationMuffler = new ModificationMuffler();
            _modificationAim = new ModificationAim();
            
            _modificationMuffler.AddModification(_weapon);
            _modificationAim.AddModification(_weapon);
            
            Invoke(nameof(RemoveModifications), 5.0f);
        }

        private void RemoveModifications()
        {
            _weapon.RemoveModification(ModificationWeaponType.Aim);
            _weapon.RemoveModification(ModificationWeaponType.Muffler);
        }
    }
}
