using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAreaWeaponInfo : MonoBehaviour
{
    //ĳ���� �����տ� �ִ� weapon�� �ٷ� collider�� ������, �ֵθ������� collider�� ���� ������ �� ���̴� ���̵��� ����ع���.
    //�׷��ٰ� weapon�� ������ ��������, ĳ���� �տ� ����ִ°� ���� �ʾƼ� ��ô ���ڿ�����������.
    //player������Ʈ �����ڼ� ������Ʈ�� collider�� �ְ�, ����� weapon��ũ��Ʈ�� �״�� player�����տ� ��ġ�ϵ��� ��.
    //enemy ��ũ��Ʈ���� trigger�� weapon��ũ��Ʈ�� ������ �䱸�ϱ� ������, �� ��ũ��Ʈ�� player�����տ� ����ִ� ���⿡ �ٿ��� weapon��ũ��Ʈ�� ������.
    //�̷��� �ϸ�, collider�� �������� �����鼭, ������ ������ ���� ���������� ��.

    //����� ���: player�� �����ڼտ�����Ʈ�� �ش� ��ũ��Ʈ ����ġ, �ν����� â���� player�����տ� ��ġ�س��� ���� ������Ʈ ����� ����.

    //�� ��� ���� �ٸ� ����� �ִ��� ��� ����غ� ��.

    //�� ��ũ��Ʈ�� ���� ������Ʈ�� tag �� �����ϱ�. melee or chargemelee
    public GameObject matchWeaponGameObject;

}
