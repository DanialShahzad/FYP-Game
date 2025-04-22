using UnityEngine;

namespace TheUntamedWorld
{
    public enum WeaponType
    {
        // define your weapons type here
        Madcan, Gun, Knife
    }
    public class Weapon : MonoBehaviour
    {
        [SerializeField] WeaponType _weaponType;
        public WeaponType PlayerWeaponType => _weaponType;

        [SerializeField] Transform _handWeapon;
        [SerializeField] Transform _backWeapon;


        /// <summary>
        /// If isVisible is true then we're using the hand weapon
        /// </summary>
        /// <param name="isVisible"></param>
        public void SetWeaponVisibility(bool isVisible = true)
        {
            // you can either set your weapon visible or invisible
            _handWeapon.gameObject.SetActive(isVisible);
            _backWeapon.gameObject.SetActive(!isVisible);
        }

        public void HideWeapon()
        {
            _handWeapon.gameObject.SetActive(false);
            _backWeapon.gameObject.SetActive(false);
        }
    }
}
