﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace tutoMonoGame
{
    class BgMenu
    {
        private Texture2D menuTexture;

        private Rectangle menuRect;
        private string _assetName;

        public string AssetName
        {
            get { return _assetName; }
            set { _assetName = value; }
        }

        public delegate void ElementClicked(string element);
        public event ElementClicked clickEvent;



        public BgMenu(string assetName)
        {
            _assetName = assetName;
        }

        public void LoadContent(ContentManager content)
        {
            menuTexture = content.Load<Texture2D>(AssetName);
            menuRect = new Rectangle(0, 0, menuTexture.Width, menuTexture.Height);
        }

        public void Update()
        {
            if (menuRect.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y)) && Mouse.GetState().LeftButton == ButtonState.Pressed )
            {
                clickEvent(_assetName); 
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(menuTexture, menuRect, Color.White);
        }

        public void CenterElement(int height, int width)
        {
            menuRect = new Rectangle((width / 2) - (menuTexture.Width / 2), (height / 2) - (menuTexture.Height / 2), menuTexture.Width, menuTexture.Height);
        }

        public void MoveElement(int x, int y)
        {
            menuRect = new Rectangle(menuRect.X += x, menuRect.Y += y, menuRect.Width, menuRect.Height);

        }

        
    }
}
