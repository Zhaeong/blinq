﻿using UnityEngine;
using System.Collections;

public class ParticleDeath : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	var part = GetComponent<ParticleSystem>();
		Destroy(gameObject, part.duration+part.startLifetime);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

