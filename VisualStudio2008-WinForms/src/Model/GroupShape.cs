using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class GroupShape : Shape
    {
		#region Constructor

		public GroupShape(RectangleF rect) : base(rect)
		{
		}

		public GroupShape(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion

		public List<Shape> SubShape { get; set; } = new List<Shape>();

		public override bool Contains(PointF point)
		{
			//for every item in SubShape
			//check if point in item

			return false;
		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			//for every item in SubShape
			//Visualize
		}
	}
}
