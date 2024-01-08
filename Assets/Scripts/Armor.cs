using UnityEngine;

public abstract class Armor : MonoBehaviour
{
    [SerializeField] float _defAgainstSlash;
    [SerializeField] float _defAgainstPierce;
    [SerializeField] float _defAgainstBlunt;
    [SerializeField] float _defAgainstFire;
    [SerializeField] float _defAgainstIce;
}