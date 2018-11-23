﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MO.SystemInvader
{
    public class Enemy
    {
        //Parametre///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        int _health;
        int _currentHealth;
        int _price;
        int _enemyWidth;
        int _enemyHeight;
        int _strength;
        int i;
        int _frame = 0;
        int _type;

        bool _atTheEnd = false;
        bool _inGame = true;

        float _speed;
        float _baseSpeed;
        float _percent;
        float _negativePercent;
        float _timeChangeSprite;

        Texture2D _texture;
        Vector2 _position;
        Vector2 _oldPosition;
        Vector2 _velocity;
        Vector2 _supplement;
        List<Texture2D> _lifeBar;
        Queue<Vector2> _waypoints = new Queue<Vector2>();
        Point _spritesEnemy = new Point(0, 0);
        Point _limitSprites = new Point(3, 4);
        Player _player;

        int _slowDown = 0;
        int _frozen = 0;
        bool _psn = false;
        bool _golden = false;

        //Fonctions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Enemy(Texture2D texture, Vector2 position, int health, int bountyGiven, int strength, float speed, int type, int enemyWidth, int enemyHeight, Player player, List<Texture2D> lifeBar)
        {
            _position = position;
            _texture = texture;
            _health = health;
            _currentHealth = _health;
            _price = bountyGiven;
            _strength = strength;
            _speed = speed;
            _type = type;
            _enemyWidth = enemyWidth;
            _enemyHeight = enemyHeight;
            _baseSpeed = speed;
            _player = player;
            _lifeBar = lifeBar;
            _supplement = new Vector2(1, 1) * (enemyHeight / 4);
        }

        public void SetWaypoints()
        {
            if(_type == 1) // Way 1
            {
                _waypoints.Enqueue(new Vector2(4, 3) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(4, 4) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 4) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 12) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(13, 12) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(13, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(10, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(10, 23) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(11, 23) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(11, 24) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(49, 24) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(49, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(53, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(53, 5) * 32 - _supplement);
            }
            else if(_type == 2) // Way 2
            {
                _waypoints.Enqueue(new Vector2(4, 3) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(4, 4) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 4) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 9) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(3, 9) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(3, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(21, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(21, 24) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(49, 24) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(49, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(53, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(53, 5) * 32 - _supplement);
            }
            else if (_type == 3) // Way 3
            {
                _waypoints.Enqueue(new Vector2(4, 3) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(4, 4) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 4) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 9) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(25, 9) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(25, 20) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(36, 20) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(36, 24) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(49, 24) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(49, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(53, 19) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(53, 5) * 32 - _supplement);
            }
            else if(_type == 4) // Flying
            {
                _waypoints.Enqueue(new Vector2(4, 3) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(18, 30) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(30, 2) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(48, 30) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(53, 5) * 32 - _supplement);
            }


            _position = _waypoints.Dequeue();
        }

        public void SetWaypointsSnow()
        {
            if (_type == 1) // Way 1
            {
                _waypoints.Enqueue(new Vector2(0, 15) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 15) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 2) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(13, 2) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(13, 12) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(11, 12) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(11, 28) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(19, 28) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(19, 5) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(33, 5) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(33, 16) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(54, 16) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(54, 0) * 32 - _supplement);
            }
            else if (_type == 2) // Way 2
            {
                _waypoints.Enqueue(new Vector2(0, 15) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 15) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 2) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(13, 2) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(13, 12) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(11, 12) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(11, 28) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(19, 28) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(19, 16) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(54, 16) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(54, 0) * 32 - _supplement);
            }
            else if (_type == 3) // Way 3
            {
                _waypoints.Enqueue(new Vector2(0, 15) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 15) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(6, 22) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(28, 22) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(28, 27) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(54, 27) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(54, 0) * 32 - _supplement);
            }
            else if (_type == 4) // Flying
            {
                _waypoints.Enqueue(new Vector2(0, 15) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(18, 30) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(30, 2) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(48, 30) * 32 - _supplement);
                _waypoints.Enqueue(new Vector2(54, 0) * 32 - _supplement);
            }


            _position = _waypoints.Dequeue();
        }

        public int BountyGiven => _price;
        public int GiveHealth => _health;
        public int GiveStrength => _strength;
        public int GiveType => _type;
        public int GiveWidth => _enemyWidth;
        public int GiveHeight => _enemyHeight;

        public float DistanceToDestination => Vector2.Distance(_position, _waypoints.Peek());
        public float GiveSpeed => _speed;

        public Texture2D GiveTexture => _texture;
        public Vector2 GetPos() => _position;

        public bool InGame
        {
            get { return _inGame; }
            set { _inGame = value; }
        }

        public void Deal(int damages, int type)
        {
            _currentHealth -= damages;
            if(type == 2)
            {
                if(_slowDown < 2)
                {
                    _speed -= _baseSpeed / 5;
                    _slowDown++;
                }
            }
            else if(type == 3)
            {
                if(_frozen == 0 || _frame >= _frozen + 180)
                {
                    _frozen = _frame;
                }
            }
            else if(type == 4)
            {
                _psn = true;
            }
            else if(type == 5)
            {
                if(_golden == false)
                {
                    _price = _price * 2;
                    _golden = true;
                }
            }
        }

        public void AtTheEnd()
        {
            _atTheEnd = true;
        }

        public List<Texture2D> LifeBar
        {
            get { return _lifeBar; }
        }

        public Texture2D Sprite
        {
            get { return _texture; }
        }

        public void SpritesUpdate()
        {
            if (_spritesEnemy.X < _limitSprites.X - 1)
                _spritesEnemy.X += 1;
            else
                _spritesEnemy.X = 0;
                _timeChangeSprite = 0;
        }
        public void MoveDirection(Vector2 oldPosition, Vector2 newPosition)
        {
            if (newPosition.X > oldPosition.X)//Left to Right
            {
                _spritesEnemy.Y = 2;
            }
            else if (newPosition.X < oldPosition.X)//Right to Left
            {
                _spritesEnemy.Y = 1;
            }
            else if (newPosition.Y > oldPosition.Y)//Down
            {
                _spritesEnemy.Y = 0;
            }
            else if (newPosition.Y < oldPosition.Y)//Up
            {
                _spritesEnemy.Y = 3;
            }
        }

        //Update///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Update(GameTime gameTime)
        {
            MoveDirection(_oldPosition, _position);
            _timeChangeSprite += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (_timeChangeSprite > 0.1)
            {
                SpritesUpdate();
            }

            if (_currentHealth <= 0 && _inGame)
            {
                _player.Score += ((((int) _speed * 10) + (_strength * 10) + (_health / 10)) / 2) * _player.Difficulty;
                _player.CurrentGold += _price;
                _inGame = false;
            }
            else if (_atTheEnd && _inGame)
            {
                _player.Hurt(_strength);
                _inGame = false;
            }

            if(_frozen == 0 || _frozen + 120 < _frame)
            {
                if (_waypoints.Count > 0)
                {
                    if (DistanceToDestination < _speed)
                    {
                        _position = _waypoints.Peek();
                        _waypoints.Dequeue();
                    }

                    else
                    {
                        Vector2 direction = _waypoints.Peek() - _position;
                        direction.Normalize();

                        _velocity = Vector2.Multiply(direction, _speed);

                        _oldPosition = _position;
                        _position += _velocity;
                    }
                }
            }
            if(_psn == true && _frame % 30 == 0)
            {
                _currentHealth -= _health / 200;
            }
            _frame++;
        }

        //Draw///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Draw(SpriteBatch spriteBatch)
        {
            if (_inGame)
            {
                if (_frozen != 0 && _frozen + 120 >= _frame)
                {
                    spriteBatch.Draw(_texture,
                        new Rectangle((int)GetPos().X, (int)GetPos().Y, _enemyWidth, _enemyHeight),
                        new Rectangle(_spritesEnemy.X * _enemyWidth, _spritesEnemy.Y * _enemyHeight, _enemyWidth, _enemyHeight),
                        Color.DeepSkyBlue);
                }
                else if (_slowDown == 1)
                {
                    spriteBatch.Draw(_texture,
                        new Rectangle((int)GetPos().X, (int)GetPos().Y, _enemyWidth, _enemyHeight),
                        new Rectangle(_spritesEnemy.X * _enemyWidth, _spritesEnemy.Y * _enemyHeight, _enemyWidth, _enemyHeight),
                        Color.LightGray);
                }
                else if (_slowDown == 2)
                {
                    spriteBatch.Draw(_texture,
                        new Rectangle((int)GetPos().X, (int)GetPos().Y, _enemyWidth, _enemyHeight),
                        new Rectangle(_spritesEnemy.X * _enemyWidth, _spritesEnemy.Y * _enemyHeight, _enemyWidth, _enemyHeight),
                        Color.Gray);
                }
                else if (_slowDown == 3)
                {
                    spriteBatch.Draw(_texture,
                       new Rectangle((int)GetPos().X, (int)GetPos().Y, _enemyWidth, _enemyHeight),
                       new Rectangle(_spritesEnemy.X * _enemyWidth, _spritesEnemy.Y * _enemyHeight, _enemyWidth, _enemyHeight),
                        Color.DarkGray);
                }
                else if (_psn == true)
                {
                    spriteBatch.Draw(_texture,
                        new Rectangle((int)GetPos().X, (int)GetPos().Y, _enemyWidth, _enemyHeight),
                        new Rectangle(_spritesEnemy.X * _enemyWidth, _spritesEnemy.Y * _enemyHeight, _enemyWidth, _enemyHeight),
                        Color.Purple);
                }
                else if (_golden == true)
                {
                    spriteBatch.Draw(_texture,
                        new Rectangle((int)GetPos().X, (int)GetPos().Y, _enemyWidth, _enemyHeight),
                        new Rectangle(_spritesEnemy.X * _enemyWidth, _spritesEnemy.Y * _enemyHeight, _enemyWidth, _enemyHeight),
                        Color.Gold);
                }
                else
                {
                    spriteBatch.Draw(_texture,
                        new Rectangle((int)GetPos().X, (int)GetPos().Y, _enemyWidth, _enemyHeight),
                        new Rectangle(_spritesEnemy.X * _enemyWidth, _spritesEnemy.Y * _enemyHeight, _enemyWidth, _enemyHeight),
                        Color.White);
                }

                _percent = ((float)_currentHealth / (float)_health) * 100;
                for (int n = 0; n < _percent; n++)
                {
                    if (_percent < 10)
                    {
                        spriteBatch.Draw(_lifeBar[2], new Rectangle((int)GetPos().X + (_enemyWidth / 2) - 50 + n, (int)GetPos().Y, _lifeBar[2].Width, _lifeBar[2].Height), Color.White);
                    }
                    else if (_percent < 50)
                    {
                        spriteBatch.Draw(_lifeBar[1], new Rectangle((int)GetPos().X + (_enemyWidth / 2) - 50 + n, (int)GetPos().Y, _lifeBar[1].Width, _lifeBar[1].Height), Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(_lifeBar[0], new Rectangle((int)GetPos().X + (_enemyWidth / 2) - 50 + n, (int)GetPos().Y, _lifeBar[0].Width, _lifeBar[0].Height), Color.White);
                    }
                    i = n;
                }
                _negativePercent = 100 - _percent;
                if(_negativePercent > 100)
                {
                    _negativePercent = 100;
                }
                for (int n = 0; n < _negativePercent; n++)
                {
                    spriteBatch.Draw(_lifeBar[3], new Rectangle((int)GetPos().X + (_enemyWidth / 2) - 50 + n + i, (int)GetPos().Y, _lifeBar[3].Width, _lifeBar[3].Height), Color.White);
                }
            }
        }
    }
}
