using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System;
using UnityEngine;

public class Hovl_Laser2 : MonoBehaviour
{
    [SerializeField] private float laserScale = 1;
    [SerializeField] private Color laserColor = new Vector4(1, 1, 1, 1);
    [SerializeField] private GameObject HitEffect;
    [SerializeField] private GameObject FlashEffect;
    [SerializeField] private float HitOffset = 0;
    [SerializeField] private float _force;

    [SerializeField] private float MaxLength;

    private bool UpdateSaver = false;
    private ParticleSystem laserPS;
    private ParticleSystem[] Flash;
    private ParticleSystem[] Hit;
    private Material laserMat;
    private int particleCount;
    private ParticleSystem.Particle[] particles;
    private Vector3[] particlesPositions;
    private float dissovleTimer = 0;
    private bool startDissovle = false;
    private float _angleZ = 10f;
    private int _damage = 1;
    private float _speedRotation = 0.1f;

    void Start()
    {
        laserPS = GetComponent<ParticleSystem>();
        laserMat = GetComponent<ParticleSystemRenderer>().material;
        Flash = FlashEffect.GetComponentsInChildren<ParticleSystem>();
        Hit = HitEffect.GetComponentsInChildren<ParticleSystem>();
        laserMat.SetFloat("_Scale", laserScale);
    }

    void Update()
    {
        Vector3 mause = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _angleZ));
        //Quaternion rotation = Quaternion.LookRotation(mause);
        //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, _speedRotation);
        transform.LookAt(mause);

        RaycastHit hit;
        var raycast = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, MaxLength);

        if (laserPS != null && UpdateSaver == false)
        {
            //Set start laser point
            laserMat.SetVector("_StartPoint", transform.position);
            //Set end laser point

            if (raycast)
            {
                particleCount = Mathf.RoundToInt(hit.distance / (2 * laserScale));
                if (particleCount < hit.distance / (2 * laserScale))
                {
                    particleCount += 1;
                }
                particlesPositions = new Vector3[particleCount];
                AddParticles();

                laserMat.SetFloat("_Distance", hit.distance);
                laserMat.SetVector("_EndPoint", hit.point);
                if (Hit != null)
                {
                    if (hit.collider.TryGetComponent<Enemy>(out Enemy enemy))
                    {
                        enemy.TakeDamage(_damage);
                    }
                    if (hit.collider.TryGetComponent<Corpse>(out Corpse corpse))
                    {
                        corpse.AddForce(_force);
                    }
                    if (hit.collider.TryGetComponent<Crate>(out Crate crate))
                    {
                        crate.InstantiateCrate();
                    }
                    if (hit.collider.TryGetComponent<BoxOne>(out BoxOne boxOne))
                    {
                        boxOne.InstantiateSpot(hit.point);
                    }

                    HitEffect.transform.position = hit.point + hit.normal * HitOffset;
                    HitEffect.transform.LookAt(hit.point);
                    foreach (var AllHits in Hit)
                    {
                        if (!AllHits.isPlaying) AllHits.Play();
                    }
                    foreach (var AllFlashes in Flash)
                    {
                        if (!AllFlashes.isPlaying) AllFlashes.Play();
                    }
                }
            }
            else
            {
                //End laser position if doesn't collide with object
                var EndPos = transform.position + transform.forward * MaxLength;

                var distance = Vector3.Distance(EndPos, transform.position);
                particleCount = Mathf.RoundToInt(distance / (2 * laserScale));

                if (particleCount < distance / (2 * laserScale))
                {
                    particleCount += 1;
                }

                particlesPositions = new Vector3[particleCount];
                AddParticles();

                Vector3 endPosition = new Vector3(EndPos.x, EndPos.y - 5f, EndPos.z);

                laserMat.SetFloat("_Distance", distance);
                laserMat.SetVector("_EndPoint", endPosition);
                if (Hit != null)
                {
                    HitEffect.transform.position = EndPos;

                    foreach (var AllPs in Hit)
                    {
                        if (AllPs.isPlaying) AllPs.Stop();
                    }
                }
            }
        }

        if (startDissovle)
        {
            dissovleTimer += Time.deltaTime;
            laserMat.SetFloat("_Dissolve", dissovleTimer * 5);
        }
        else
        {
            return;
        }
    }

    void AddParticles()
    {
        //Old particles settings

        //var normalDistance = particleCount;
        //var sh = LaserPS.shape;
        //sh.radius = normalDistance;
        //sh.position = new Vector3(0, 0, normalDistance);
        //LaserPS.emission.SetBursts(new[] { new ParticleSystem.Burst(0f, particleCount + 1) });


        particles = new ParticleSystem.Particle[particleCount];

        for (int i = 0; i < particleCount; i++)
        {

            particlesPositions[i] = new Vector3(0f, 0f, 0f) + new Vector3(0f, 0f, i * 2 * laserScale);
            particles[i].position = particlesPositions[i];
            particles[i].startSize3D = new Vector3(0.1f, 0.1f, 2 * laserScale);
            particles[i].startColor = laserColor;
        }
        laserPS.SetParticles(particles, particles.Length);
    }

    public void DisablePrepare()
    {
        transform.parent = null;
        dissovleTimer = 0;
        startDissovle = true;
        UpdateSaver = true;
        if (Flash != null && Hit != null)
        {
            foreach (var AllHits in Hit)
            {
                if (AllHits.isPlaying) AllHits.Stop();
            }
            foreach (var AllFlashes in Flash)
            {
                if (AllFlashes.isPlaying) AllFlashes.Stop();
            }
        }
    }
}
