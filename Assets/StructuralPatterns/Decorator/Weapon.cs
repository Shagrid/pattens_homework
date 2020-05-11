using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


namespace Decorator
{
    public sealed class Weapon : MonoBehaviour
    {
        [SerializeField] private float _shotVolume;
        [SerializeField] private Transform _placeForMuffler;
        [SerializeField] private Transform _placeForOptic;

        private Dictionary<ModificationWeaponType,GameObject> _modifications;

        private void Start()
        {
            _modifications = new Dictionary<ModificationWeaponType, GameObject>();
        }

        public void SetShotVolume(float shotVolume)
        {
            _shotVolume -= shotVolume;
        }

        public Vector3 MufflerPosition()
        {
            return _placeForMuffler.position;
        }
        public Vector3 OpticPosition()
        {
            return _placeForOptic.position;
        }

        public void RemoveModification(ModificationWeaponType type)
        {
            if (_modifications.ContainsKey(type))
            {
                Destroy(_modifications[type]);
                _modifications.Remove(type);
            }
        }

        public void AddModification(ModificationWeaponType type, GameObject modification)
        {
            RemoveModification(type);
            _modifications.Add(type, modification);
        }
        
        
        
        
    }
}
