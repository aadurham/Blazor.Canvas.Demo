using Excubo.Blazor.Canvas;
using Excubo.Blazor.Canvas.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCanvasDemo.DrawingRoom
{
    public static class DrawOnCanvas
    {
       
        public static async void Line(Context2D context, Line line)
        {

            await context.BeginPathAsync();
            await context.MoveToAsync(line.startX, line.startY);
            await context.LineToAsync(line.endX, line.endY);
            await context.LineWidthAsync(line.thickness);

            // set line color
            await context.StrokeStyleAsync(line.color);
            await context.StrokeAsync();
        }

        public static async void Line(Canvas helper_canvas, Line line)
        {
            await using (var context = await helper_canvas.GetContext2DAsync())
            {

                await context.BeginPathAsync();
                await context.MoveToAsync(line.startX, line.startY);
                await context.LineToAsync(line.endX, line.endY);
                await context.LineWidthAsync(line.thickness);

                // set line color
                await context.StrokeStyleAsync(line.color);
                await context.StrokeAsync();
            }
        }


    }
}
