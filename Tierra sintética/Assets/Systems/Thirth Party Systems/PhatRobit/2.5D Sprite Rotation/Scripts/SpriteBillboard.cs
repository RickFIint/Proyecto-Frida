using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace PhatRobit
{
	public class SpriteBillboard : MonoBehaviour
	{
		public CameraDirection cameraDirection;

		// I don't recommend using a list like this, it's just for example
		public List<Animator> animations = new List<Animator>();

		private SpriteRenderer _sprite;
		private Animator _animator;
		private Transform _billboard;
		private Facing _facing = Facing.Down;

		private Transform _t;

		void Start()
		{
			_t = transform;
			_sprite = GetComponentInChildren<SpriteRenderer>();
			_animator = GetComponentInChildren<Animator>();
			_billboard = _sprite.transform;
		}

		void Update()
		{
			_sprite.flipX = false;
			int offset = _facing - cameraDirection.Facing;

			if(offset < 0)
			{
				offset += 8;
			}

			Facing direction = (Facing)offset;

			switch(direction)
			{
				case Facing.DownRight:
					direction = Facing.DownLeft;
					_sprite.flipX = true;
					break;
				case Facing.Right:
					direction = Facing.Left;
					_sprite.flipX = true;
					break;
				case Facing.UpRight:
					direction = Facing.UpLeft;
					_sprite.flipX = true;
					break;
			}

			Vector3 targetPoint = new Vector3(cameraDirection.transform.position.x, _t.position.y, cameraDirection.transform.position.z) - transform.position;
			_billboard.rotation = Quaternion.LookRotation(-targetPoint, Vector3.up);

			// Change this with your own sprite animation stuff
			Debug.Log(direction);
			switch(direction)
			{
				case Facing.Down:
					_animator.SetFloat("Horizontal", 0.0f);
					_animator.SetFloat("Vertical", -1.0f);
					break;
				case Facing.Up:
					_animator.SetFloat("Horizontal", 0.0f);
					_animator.SetFloat("Vertical", 1.0f);
					break;
				case Facing.DownLeft:
					_animator.SetFloat("Horizontal", -0.66f);
					_animator.SetFloat("Vertical", -0.66f);
					break;
				case Facing.DownRight:
					_animator.SetFloat("Horizontal", 0.66f);
					_animator.SetFloat("Vertical", -0.66f);
					break;
				case Facing.Left:
					_animator.SetFloat("Horizontal", -1.0f);
					_animator.SetFloat("Vertical", 0.0f);
					break;
				case Facing.Right:
					_animator.SetFloat("Horizontal", 1.0f);
					_animator.SetFloat("Vertical", 0.0f);
					break;
				case Facing.UpLeft:
					_animator.SetFloat("Horizontal", -0.66f);
					_animator.SetFloat("Vertical", 0.66f);
					break;
				case Facing.UpRight:
					_animator.SetFloat("Horizontal", 0.66f);
					_animator.SetFloat("Vertical", 0.66f);
					break;
			}
		}
	}
}