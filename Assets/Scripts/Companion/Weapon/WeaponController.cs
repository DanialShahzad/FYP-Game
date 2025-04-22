using System.Linq;
using BlazeAISpace;
using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.UIElements;

namespace TheUntamedWorld
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] Weapon[] _playerWeapons;
        public Weapon[] PlayerWeapons => _playerWeapons;  // contains hand and back weapons
        [SerializeField] WeaponType _requiredWeaponType;



        private void Start()
        {
            foreach (var weapon in _playerWeapons) weapon.HideWeapon();

            // bind the method
            TryGetComponent<AttackStateBehaviour>(out var component);

            if (component == null) return;

            component.PlayerEngagementEvent += (isEngaging) =>
            {
                SetWeapon(_requiredWeaponType, isEngaging);
            };
        }

        public void SetWeapon(WeaponType weaponType, bool visibility = true)
        {
            foreach (var weapon in _playerWeapons) weapon.HideWeapon();

            // we need to filter the weapon based on this weapon type
            Weapon filteredWeapon = PlayerWeapons.Where(weapon => weapon.PlayerWeaponType == _requiredWeaponType)?.FirstOrDefault();
            filteredWeapon.SetWeaponVisibility(visibility);



        }


    }

}