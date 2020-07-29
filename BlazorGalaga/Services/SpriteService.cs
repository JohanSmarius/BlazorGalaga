﻿using System;
using BlazorGalaga.Models;
using Blazor.Extensions.Canvas;
using Blazor.Extensions.Canvas.Canvas2D;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Drawing;
using BlazorGalaga.Static;
using System.Linq;

namespace BlazorGalaga.Services
{
    public class SpriteService
    {
        public Canvas2DContext DynamicCtx1 { get; set; }
        public Canvas2DContext DynamicCtx2 { get; set; }
        public Canvas2DContext StaticCtx { get; set; }
        public Canvas2DContext BufferCtx { get; set; }
        public List<Canvas> BufferCanvases { get; set; }
        public ElementReference SpriteSheet { get; set; }
        public List<Sprite> Sprites = new List<Sprite>();


        public async void Init()
        {
            await DynamicCtx1.SetStrokeStyleAsync("white");
            await DynamicCtx1.SetFillStyleAsync("yellow");
            await DynamicCtx1.SetFontAsync("48px serif");
            await DynamicCtx1.SetLineWidthAsync(2);

            await DynamicCtx2.SetStrokeStyleAsync("white");
            await DynamicCtx2.SetFillStyleAsync("yellow");
            await DynamicCtx2.SetFontAsync("48px serif");
            await DynamicCtx2.SetLineWidthAsync(2);

        }

        public async void DrawSprite(Sprite sprite, PointF location, float rotationangle)
        {
            if (!sprite.IsInitialized)
                SetSpriteInfoBySpriteType(sprite);

            if (sprite.DynamicCanvas == null) return;

            if (rotationangle != 0)
            {
                await sprite.DynamicCanvas.SaveAsync();
                await sprite.DynamicCanvas.TranslateAsync(location.X, location.Y);
                await sprite.DynamicCanvas.RotateAsync((float)((rotationangle + sprite.InitialRotationOffset) * Math.PI / 180));
            }

            if (sprite.BufferCanvas != null)
            {
                await sprite.DynamicCanvas.DrawImageAsync(
                    sprite.BufferCanvas.Canvas,
                    rotationangle == 0 ? (int)location.X - sprite.SpriteDestRect.Width * .5 : (int)sprite.SpriteDestRect.Width *.5 * -1, //dest x
                    rotationangle == 0 ? (int)location.Y - sprite.SpriteDestRect.Height * .5 : (int)sprite.SpriteDestRect.Height *.5 * -1 //dest y,
                );
            }

            if (rotationangle != 0)
            {
                await sprite.DynamicCanvas.RestoreAsync();
            }
        }

        private void SetSpriteInfoBySpriteType(Sprite sprite)
        {

            switch (sprite.SpriteType)
            {
                case Sprite.SpriteTypes.Ship:
                    SetUpSprite(sprite, 0, 109, 1, 0, 0);
                    break;
                case Sprite.SpriteTypes.BlueBug:
                    SetUpSprite(sprite, 1, 109, 91, -90, 0);
                    break;
                case Sprite.SpriteTypes.RedBug:
                    SetUpSprite(sprite, 2, 109, 73, -90, 1);
                    break;
                case Sprite.SpriteTypes.GreenBug:
                    SetUpSprite(sprite, 3, 109, 37, -90, 1);
                    break;
                case Sprite.SpriteTypes.ShipMissle:
                    SetUpSprite(sprite, 4, 310, 120, 0, 0);
                    break;
                case Sprite.SpriteTypes.BlueBug_DownFlap:
                    SetUpSprite(sprite, 5, 127, 91, -90, 0);
                    break;
                case Sprite.SpriteTypes.RedBug_DownFlap:
                    SetUpSprite(sprite, 6, 127, 73, -90, 1);
                    break;
                case Sprite.SpriteTypes.GreenBug_DownFlap:
                    SetUpSprite(sprite, 7, 127, 37, -90, 1);
                    break;
                case Sprite.SpriteTypes.BugMissle:
                    SetUpSprite(sprite, 8, 310, 135, 0, 0);
                    break;
            }

            sprite.IsInitialized = true;
        }

        private async void SetUpSprite(Sprite sprite,int bufferindex, int sx, int sy, int rotationoffset,int dynamiccanvasindex)
        {
            await BufferCanvases[bufferindex].Context.DrawImageAsync(
                SpriteSheet,
                sx,
                sy,
                Constants.SpriteSourceSize,
                Constants.SpriteSourceSize,
                0,
                0,
                Constants.SpriteDestSize.Width,
                Constants.SpriteDestSize.Height
            );

            sprite.BufferCanvas = BufferCanvases[bufferindex].Context;
            sprite.DynamicCanvas = dynamiccanvasindex == 0 ? DynamicCtx1 : DynamicCtx2;
            sprite.SpriteDestRect = new RectangleF(0, 0, Constants.SpriteDestSize.Width, Constants.SpriteDestSize.Height);
            sprite.InitialRotationOffset = rotationoffset;
        }

    }
}
