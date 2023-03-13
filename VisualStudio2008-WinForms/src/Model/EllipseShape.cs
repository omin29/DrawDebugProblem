using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    public class EllipseShape : Shape
    {
		#region Constructor

		public EllipseShape(RectangleF rect) : base(rect)
		{
		}

		public EllipseShape(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion

		public override bool Contains(PointF point)
		{
			//You gotta use the LAAG formula yourself to determine if the point is inside the ellipse. Override this.
			if (base.Contains(point))
				return true;
			else
				return false;

			//doesnt work
			/*float ellipseFormula = ((point.X / Width) * (point.X / Width)) + ((point.Y / Height) * (point.Y / Height)) - 1;

			if(ellipseFormula < 0)
            {
				return true;
            }

			return false;*/
		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

		}
	}
}
