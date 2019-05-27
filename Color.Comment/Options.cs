using System;
using System.ComponentModel;
using System.Globalization;
using Microsoft.VisualStudio.Shell;

namespace Color.Comment
{
	public enum Option_ReferenceType
	{
		No     = 0,
		Triple = 2,
		All    = 3,
	};

	#region EnumConverter

	public class Option_ReferenceType_Converter
		: EnumConverter
	{
		public Option_ReferenceType_Converter()
			: base(typeof(Option_ReferenceType))
		{}

		public override bool CanConvertFrom(
			ITypeDescriptorContext Context,
			Type Type
		){
			return Type == typeof(string) || base.CanConvertFrom(Context, Type);
		}

		public override object ConvertFrom(
			ITypeDescriptorContext Context,
			CultureInfo Culture,
			object Value
		){
			if (!(Value is string String))
			return base.ConvertFrom(Context, Culture, Value);

			switch (String)
			{
				case "No":
					return Option_ReferenceType.No;

				case "Yes, but in triple slash comments only":
					return Option_ReferenceType.Triple;

				case "Yes, in all comments":
					return Option_ReferenceType.All;

				default:
					return base.ConvertFrom(Context, Culture, Value);
			}
		}

		public override object ConvertTo(
			ITypeDescriptorContext Context,
			CultureInfo Culture,
			object Value,
			Type DestinationType
		){
			if (DestinationType != typeof(string))
			return base.ConvertTo(Context, Culture, Value, DestinationType);

			// ReSharper disable once PossibleNullReferenceException
			switch ((int) Value)
			{
				case (int) Option_ReferenceType.No:
					return "No";

				case (int) Option_ReferenceType.Triple:
					return "Yes, but in triple slash comments only";

				case (int) Option_ReferenceType.All:
					return "Yes, in all comments";

				default:
					return base.ConvertTo(Context, Culture, Value, DestinationType);
			}
		}
	}

	#endregion

	public sealed class OptionsPage
		: DialogPage
	{
		[Category("Color.Comment")]
		[DisplayName("​​​​​Color parameter references")]
		[Description("Color parameter references in comments (prefixed by `$`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorParamRef { get; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​​​​Color template parameter references")]
		[Description("Color template parameter references in comments (prefixed by `^`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorTParamRef { get; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​​​Color member references")]
		[Description("Color non static member references in comments (prefixed by `.`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorMemberRef { get; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​​Color static references")]
		[Description("Color static references in comments (prefixed by `!`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorStaticRef { get; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​Color local references")]
		[Description("Color local references in comments (prefixed by `@`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorLocalRef { get; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("Color macro references")]
		[Description("Color macro references in comments (prefixed by `%`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorMacroRef { get; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("Color line–wide quotes")]
		[Description("Color quotes in comments (prefixed by `>`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorQuote { get; } = Option_ReferenceType.Triple;

		[Category("Color.Comment")]
		[DisplayName("Color line–wide code")]
		[Description("Color line–wide code in comments (prefixed by `//`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorCode { get; } = Option_ReferenceType.Triple;

		[Category("Color.Comment")]
		[DisplayName("Color inline code")]
		[Description("Color inline code in comments (surrounded by U+0060 ` GRAVE ACCENT symbol).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorInlineCode { get; } = Option_ReferenceType.All;
	}

	internal static class Options
	{
		internal static Option_ReferenceType ColorParamRef
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorParamRef ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorTParamRef
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorTParamRef ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorMemberRef
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorMemberRef ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorStaticRef
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorStaticRef ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorLocalRef
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorLocalRef ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorMacroRef
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorMacroRef ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorQuote
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorQuote ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorCode
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorCode ?? Option_ReferenceType.No;
			}
		}

		internal static Option_ReferenceType ColorInlineCode
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page?.ColorInlineCode ?? Option_ReferenceType.No;
			}
		}
	}
}