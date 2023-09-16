using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New SAAnim", menuName = "Data/SAAnim")]
public class SAAnim : ScriptableObject
{
    public enum Part
    {
        Unknown,
        LeftHand,
        LeftElbow,
        RightHand,
        RightElbow,
        LeftKnee,
        LeftFoot,
        RightKnee,
        RightFoot,
        Head,
        Belly,
        Ass,
        Groin,
        Other
    }
    public enum Side
    {
        Unknown,
        Left,
        Right,
        Other
    }

    [Header("Basic Properties")]
	[Tooltip("Must be same name of animation in controller  / ")]
	public string title;
	public AnimationClip anim;
	[SerializeField]
	[Range(1, 5)]
	public float animQuality;

    [Header("Fighting Style Properties")]
	[Tooltip("Whether the animation belongs to a fighting style / has fighting style properties.")]
	public bool hasFightingStyle;
    public bool isBoxingMove;
    public bool isKickboxingMove;
    public bool isStreetfightingMove;

    [Header("Gender Properties")]
	[Tooltip("Whether the animation is gendered / should have gendered properties.")]
	public bool isGendered;
    public bool isHyperFem;
	public bool isFem;
	public bool isAndro;
    public bool isMasc;
    public bool isHyperMasc;

	[Header("Strike Properties")]
	[Tooltip("Whether the animation is a strike / should use strike properties.")]
	public bool isStrike;
	[Tooltip ("The minimum effective distance of an attack, assuming a 2 meter tall character.")]
    public float strikeMinDistance;
	[Tooltip("The maximum effective distance of an attack, assuming a 2 meter tall character.")]
	public float strikeMaxDistance;
	public Side strikeSide; // Which side the attack is coming from.
    public Part strikePart; // The part of the body the strike impact is coming from.
    public bool strikeUsesWeapon; // Whether or not the attack uses a weapon.
	[Tooltip("How long until strike is fully extended.")]
	public float strikeTimeToExtension;

}
