using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SAAnimList", menuName = "Data/SAAnimList")]
public class SAAnimList : ScriptableObject
{
	public List<SAAnim> anims;
}
