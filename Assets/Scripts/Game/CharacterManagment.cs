using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterManagment {

	private static int p1Char, p2Char;
	// Use this for initialization
	public static void SetP1Char(int x) {
		p1Char = x;
	}
	public static int getP1Char()
	{
		return p1Char;
	}
	public static void SetP2Char(int x) {
		p2Char = x;
	}
	public static int getP2Char()
	{
		return p2Char;
	}
}
