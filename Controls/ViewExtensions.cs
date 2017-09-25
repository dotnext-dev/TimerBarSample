
using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Controls
{
	public static class ViewExtensions
	{
        static string WIDTH_NAME = "WidthTo";
        public static Task<bool> WidthTo(this VisualElement self, double toWidth, uint length = 250, Easing easing = null)
		{
			easing = easing ?? Easing.Linear;
			var taskCompletionSource = new TaskCompletionSource<bool>();

			var animation = new Animation(
				callback: d => AbsoluteLayout.SetLayoutBounds(self, new Rectangle(0, 0, d, self.Height)),
                start: self.Width,
				end: toWidth,
				easing: easing);

            var offset = 100;
			animation.Commit(self, WIDTH_NAME,
							 rate: Convert.ToUInt32(offset),
							 length: length,
							 finished: (v, c) => taskCompletionSource.SetResult(c)
							);

			return taskCompletionSource.Task;
		}

		public static void CancelWidthToAnimation(this VisualElement self)
		{
            if(self.AnimationIsRunning(WIDTH_NAME))
                self.AbortAnimation(WIDTH_NAME);
		}
	}
}