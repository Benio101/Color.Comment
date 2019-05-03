namespace Color.Comment
{
	using Color = System.Windows.Media.Color;

	internal static class Default
	{
		internal static class Colors
		{
			private  static readonly Color Gray          = Color.FromRgb(128, 128, 128);
			private  static readonly Color GrayDark      = Color.FromRgb( 80,  80,  80);
			private  static readonly Color WhiteDark     = Color.FromRgb(176, 176, 176);

			private  static readonly Color Blue          = Color.FromRgb(128, 176, 224);
			private  static readonly Color BlueDark      = Color.FromRgb( 96, 128, 224);
			private  static readonly Color Green         = Color.FromRgb(176, 224, 128);
			private  static readonly Color Red           = Color.FromRgb(224, 128, 128);
			private  static readonly Color Yellow        = Color.FromRgb(224, 224, 128);
			private  static readonly Color RedDark       = Color.FromRgb(224,  96,  96);
			private  static readonly Color GreenDark     = Color.FromRgb(128, 176,  96);
			private  static readonly Color GreenVeryDark = Color.FromRgb( 80,  96,  64);
			private  static readonly Color Orange        = Color.FromRgb(224, 176, 128);
			private  static readonly Color Pink          = Color.FromRgb(224, 128, 224);
			private  static readonly Color Purple        = Color.FromRgb(176, 128, 224);

			internal static readonly Color Comment       = Gray;
			internal static readonly Color CommentPunct  = GrayDark;
			internal static readonly Color String        = GreenDark;
			internal static readonly Color StringDark    = GreenVeryDark;
			internal static readonly Color Plain         = WhiteDark;
			internal static readonly Color Flow          = BlueDark;
			internal static readonly Color Effect        = Blue;
			internal static readonly Color Note          = Yellow;
			internal static readonly Color Todo          = Pink;
			internal static readonly Color See           = Green;
			internal static readonly Color Bug           = RedDark;
			internal static readonly Color Return        = Flow;
			internal static readonly Color Spare         = Green;
			internal static readonly Color Throw         = Red;
			internal static readonly Color Param         = Orange;
			internal static readonly Color TParam        = Purple;
		}
	}
}