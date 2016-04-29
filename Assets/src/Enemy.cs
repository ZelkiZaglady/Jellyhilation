using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    private int _hp; //ilość życia
    private int _hud; //szybkość porrusznia się
    private int _fireSpeed; //szybkość strzelania
    private int _hurt; //rany jakie zadaje
    Enemy(int hp, int hud, int fireSpeed, int hurt)
    {
        _hp = hp;
        _hud = hud;
        _fireSpeed = fireSpeed;
        _hurt = hurt;
    }
}