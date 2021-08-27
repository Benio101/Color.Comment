namespace Color.Comment
{
	using Color = System.Windows.Media.Color;

	internal static class Default
	{
		internal static class Colors
		{
			private  static readonly Color White         = Color.FromRgb(224, 224, 224);
			private  static readonly Color WhiteDark     = Color.FromRgb(176, 176, 176);
			private  static readonly Color Gray          = Color.FromRgb(128, 128, 128);
			private  static readonly Color GrayDark      = Color.FromRgb( 80,  80,  80);
			private  static readonly Color Yellow        = Color.FromRgb(224, 224, 128);
			private  static readonly Color Red           = Color.FromRgb(224, 128, 128);
			private  static readonly Color RedDark       = Color.FromRgb(176,  80,  80);
			private  static readonly Color Lime          = Color.FromRgb(176, 224, 128);
			private  static readonly Color Green         = Color.FromRgb(128, 224, 128);
			private  static readonly Color Blue          = Color.FromRgb(128, 176, 224);
			private  static readonly Color Violet        = Color.FromRgb(128, 128, 224);
			private  static readonly Color Pink          = Color.FromRgb(224, 128, 224);
			private  static readonly Color Purple        = Color.FromRgb(200, 176, 224);
			private  static readonly Color Cyan          = Color.FromRgb(176, 224, 224);

			internal static readonly Color Comment       = Gray;
			internal static readonly Color CommentPunct  = GrayDark;
			internal static readonly Color String        = Red;
			internal static readonly Color StringDark    = RedDark;
			internal static readonly Color Plain         = WhiteDark;
			private  static readonly Color Flow          = Violet;
			internal static readonly Color Effect        = Blue;
			internal static readonly Color Note          = Yellow;
			internal static readonly Color Todo          = Pink;
			internal static readonly Color See           = Green;
			internal static readonly Color Bug           = RedDark;
			internal static readonly Color Return        = Flow;
			internal static readonly Color Spare         = Lime;
			internal static readonly Color Throw         = Red;
			internal static readonly Color Param         = Cyan;
			internal static readonly Color TParam        = Green;
			internal static readonly Color Member        = Yellow;
			internal static readonly Color Static        = Red;
			internal static readonly Color Local         = White;
			internal static readonly Color Macro         = Purple;
		}
	}
}