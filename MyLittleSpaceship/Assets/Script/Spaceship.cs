using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Part;

/*
 * UI에서 선택된 Parts를 관리해줄게 필요
 */

public class Spaceship : MonoBehaviour
{
    [SerializeField]
    PartsCore corePrefab;
    [SerializeField]
    PartsArmour armourPrefab;
    [SerializeField]
    PartsWeapon weaponPrefab;
    [SerializeField]
    PartsBooster boosterPrefab;

    Parts _core;
    List<PartsArmour> _armourParts = new List<PartsArmour>();
    List<PartsWeapon> _weaponParts = new List<PartsWeapon>();
    List<PartsBooster> _boosterParts = new List<PartsBooster>();
    
    public int _rotationSpeed;
    Rigidbody _rigidbody;

    /// <summary>
    /// 기본적으로 코어를 생성해줌
    /// </summary>
    void Awake()
    {
        _core = Instantiate(corePrefab);
        _rigidbody = GetComponent<Rigidbody>();
    }

    int GetPartsCount()
    {
        return this.transform.childCount;
    }

    /// <summary>
    /// 파츠를 붙임 // UI에서 끌어다 쓸 예정
    /// </summary>
    /// <param name="target">주체</param>
    /// <param name="parts">객체</param>
    /// <param name="direction"> 주체에 객체가 붙는 방향</param>
    public void DokingParts(PartsCore target, Parts parts, Direction direction)
    {
        if (parts.type == PartsType.Armour)
            _armourParts.Add((PartsArmour)parts);
        else if (parts.type == PartsType.Booster)
            _boosterParts.Add((PartsBooster)parts);
        else if(parts.type == PartsType.Armour)
            _weaponParts.Add((PartsWeapon)parts);
        //NOTE:전체parts에 추가 해줘야함


    }

    /// <summary>
    /// 파츠를 선택하면 해당 파츠를 반환
    /// </summary>
    /// <returns></returns>
    public Parts SelectParts()
    {


        return null;
    }

    /// <summary>
    /// 코어 또는 아머 옆에 아머가 있다면 자동으로 연결
    /// </summary>
    void AroundLink(PartsCore parts)
    {
        Position position = parts.position;
        
        for(int i = 0; i < _armourParts.Count; i++)
        {

        }
    }
}
