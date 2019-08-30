using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Color.Comment
{
	#region Default

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Default")]
	[Name("Comment.Default")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	internal sealed class Format_Comment_Default
		: ClassificationFormatDefinition
	{
		public Format_Comment_Default()
		{
			DisplayName = "C++ Comment";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Comment;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Default.Slashes")]
	[Name("Comment.Default.Slashes")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Default")]
	internal sealed class Format_Comment_Default_Slashes
		: ClassificationFormatDefinition
	{
		public Format_Comment_Default_Slashes()
		{
			DisplayName = "C++ Comment: \"//\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	#region ParamRef

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.ParamRef.Mark")]
	[Name("Comment.ParamRef.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_ParamRef_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_ParamRef_Mark()
		{
			DisplayName = "C++ Comment: Reference: Parameter: \"$\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.ParamRef.Param")]
	[Name("Comment.ParamRef.Param")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_ParamRef_Param
		: ClassificationFormatDefinition
	{
		public Format_Comment_ParamRef_Param()
		{
			DisplayName = "C++ Comment: Reference: Parameter";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Param;
		}
	}

	#endregion
	#region TParamRef

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.TParamRef.Mark")]
	[Name("Comment.TParamRef.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_TParamRef_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_TParamRef_Mark()
		{
			DisplayName = "C++ Comment: Reference: Template Parameter: \"^\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.TParamRef.TParam")]
	[Name("Comment.TParamRef.TParam")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_TParamRef_TParam
		: ClassificationFormatDefinition
	{
		public Format_Comment_TParamRef_TParam()
		{
			DisplayName = "C++ Comment: Reference: Template Parameter";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.TParam;
		}
	}

	#endregion
	#region MemberRef

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.MemberRef.Mark")]
	[Name("Comment.MemberRef.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_MemberRef_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_MemberRef_Mark()
		{
			DisplayName = "C++ Comment: Reference: Member: \".\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.MemberRef.Member")]
	[Name("Comment.MemberRef.Member")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_MemberRef_Member
		: ClassificationFormatDefinition
	{
		public Format_Comment_MemberRef_Member()
		{
			DisplayName = "C++ Comment: Reference: Member";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	#endregion
	#region StaticRef

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.StaticRef.Mark")]
	[Name("Comment.StaticRef.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_StaticRef_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_StaticRef_Mark()
		{
			DisplayName = "C++ Comment: Reference: Static: \"!\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.StaticRef.Static")]
	[Name("Comment.StaticRef.Static")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_StaticRef_Static
		: ClassificationFormatDefinition
	{
		public Format_Comment_StaticRef_Static()
		{
			DisplayName = "C++ Comment: Reference: Static";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	#endregion
	#region LocalRef

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.LocalRef.Mark")]
	[Name("Comment.LocalRef.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_LocalRef_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_LocalRef_Mark()
		{
			DisplayName = "C++ Comment: Reference: Local: \"@\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.LocalRef.Local")]
	[Name("Comment.LocalRef.Local")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_LocalRef_Local
		: ClassificationFormatDefinition
	{
		public Format_Comment_LocalRef_Local()
		{
			DisplayName = "C++ Comment: Reference: Local";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Local;
		}
	}

	#endregion
	#region MacroRef

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.MacroRef.Mark")]
	[Name("Comment.MacroRef.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_MacroRef_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_MacroRef_Mark()
		{
			DisplayName = "C++ Comment: Reference: Macro: \"%\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.MacroRef.Macro")]
	[Name("Comment.MacroRef.Macro")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_MacroRef_Macro
		: ClassificationFormatDefinition
	{
		public Format_Comment_MacroRef_Macro()
		{
			DisplayName = "C++ Comment: Reference: Macro";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Macro;
		}
	}

	#endregion
	#region Quote

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Quote.Mark")]
	[Name("Comment.Quote.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Quote_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Quote_Mark()
		{
			DisplayName = "C++ Comment: Quote: \">\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.StringDark;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Quote.Text")]
	[Name("Comment.Quote.Text")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Quote_Text
		: ClassificationFormatDefinition
	{
		public Format_Comment_Quote_Text()
		{
			DisplayName = "C++ Comment: Quote";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.String;
		}
	}

	#endregion
	#region Code

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Code.Mark")]
	[Name("Comment.Code.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Code_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Code_Mark()
		{
			DisplayName = "C++ Comment: Code: \"//\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Code.Text")]
	[Name("Comment.Code.Text")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Code_Text
		: ClassificationFormatDefinition
	{
		public Format_Comment_Code_Text()
		{
			DisplayName = "C++ Comment: Code";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Comment;
		}
	}

	#endregion
	#region InlineCode

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.InlineCode.Mark")]
	[Name("Comment.InlineCode.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_InlineCode_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_InlineCode_Mark()
		{
			DisplayName = "C++ Comment: Inline Code: \"`\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.InlineCode.Text")]
	[Name("Comment.InlineCode.Text")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	[Order(After = "Comment.Triple.Effect.Desc")]
	[Order(After = "Comment.Triple.Note.Desc")]
	[Order(After = "Comment.Triple.Todo.Desc")]
	[Order(After = "Comment.Triple.See.Desc")]
	[Order(After = "Comment.Triple.Bug.Desc")]
	[Order(After = "Comment.Triple.Return.Desc")]
	[Order(After = "Comment.Triple.Spare.Desc")]
	[Order(After = "Comment.Triple.Throw.Desc")]
	[Order(After = "Comment.Triple.Param.Desc")]
	[Order(After = "Comment.Triple.TParam.Desc")]
	internal sealed class Format_Comment_InlineCode_Text
		: ClassificationFormatDefinition
	{
		public Format_Comment_InlineCode_Text()
		{
			DisplayName = "C++ Comment: Inline Code";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Comment;
		}
	}

	#endregion
	#endregion
	#region Triple

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple")]
	[Name("Comment.Triple")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	internal sealed class Format_Comment_Triple
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple()
		{
			DisplayName = "C++ Documentation";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Slashes")]
	[Name("Comment.Triple.Slashes")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Slashes
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Slashes()
		{
			DisplayName = "C++ Documentation: \"///\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Punct")]
	[Name("Comment.Triple.Punct")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Punct
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Punct()
		{
			DisplayName = "C++ Documentation: Punctuation";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Punct.Header")]
	[Name("Comment.Triple.Punct.Header")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Punct_Header
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Punct_Header()
		{
			DisplayName = "C++ Documentation: Punctuation: \"@\" | \"\\\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.CommentPunct;
		}
	}

	#region Triple.Effect

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Effect.Mark")]
	[Name("Comment.Triple.Effect.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Effect_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Effect_Mark()
		{
			DisplayName = "C++ Documentation: Effect";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Effect;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Effect.Desc")]
	[Name("Comment.Triple.Effect.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Effect_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Effect_Desc()
		{
			DisplayName = "C++ Documentation: Effect: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.Note

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Note.Mark")]
	[Name("Comment.Triple.Note.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Note_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Note_Mark()
		{
			DisplayName = "C++ Documentation: Note";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Note;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Note.Desc")]
	[Name("Comment.Triple.Note.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Note_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Note_Desc()
		{
			DisplayName = "C++ Documentation: Note: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.Todo

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Todo.Mark")]
	[Name("Comment.Triple.Todo.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Todo_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Todo_Mark()
		{
			DisplayName = "C++ Documentation: Todo";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Todo;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Todo.Desc")]
	[Name("Comment.Triple.Todo.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Todo_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Todo_Desc()
		{
			DisplayName = "C++ Documentation: Todo: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.See

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.See.Mark")]
	[Name("Comment.Triple.See.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_See_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_See_Mark()
		{
			DisplayName = "C++ Documentation: See";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.See;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.See.Desc")]
	[Name("Comment.Triple.See.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_See_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_See_Desc()
		{
			DisplayName = "C++ Documentation: See: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.Bug

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Bug.Mark")]
	[Name("Comment.Triple.Bug.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Bug_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Bug_Mark()
		{
			DisplayName = "C++ Documentation: Bug";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Bug;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Bug.Desc")]
	[Name("Comment.Triple.Bug.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Bug_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Bug_Desc()
		{
			DisplayName = "C++ Documentation: Bug: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.Return

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Return.Mark")]
	[Name("Comment.Triple.Return.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Return_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Return_Mark()
		{
			DisplayName = "C++ Documentation: Return";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Return;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Return.Desc")]
	[Name("Comment.Triple.Return.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Return_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Return_Desc()
		{
			DisplayName = "C++ Documentation: Return: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.Spare

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Spare.Mark")]
	[Name("Comment.Triple.Spare.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Spare_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Spare_Mark()
		{
			DisplayName = "C++ Documentation: Spare";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Spare;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Spare.Desc")]
	[Name("Comment.Triple.Spare.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Spare_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Spare_Desc()
		{
			DisplayName = "C++ Documentation: Spare: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.Throw

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Throw.Mark")]
	[Name("Comment.Triple.Throw.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Throw_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Throw_Mark()
		{
			DisplayName = "C++ Documentation: Throw";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Throw;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Throw.Desc")]
	[Name("Comment.Triple.Throw.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Throw_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Throw_Desc()
		{
			DisplayName = "C++ Documentation: Throw: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.Param

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Param.Mark")]
	[Name("Comment.Triple.Param.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Param_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Param_Mark()
		{
			DisplayName = "C++ Documentation: Parameter";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Comment;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Param.Name")]
	[Name("Comment.Triple.Param.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Param_Name
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Param_Name()
		{
			DisplayName = "C++ Documentation: Parameter: Name";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Param;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.Param.Desc")]
	[Name("Comment.Triple.Param.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_Param_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_Param_Desc()
		{
			DisplayName = "C++ Documentation: Parameter: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#region Triple.TParam

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.TParam.Mark")]
	[Name("Comment.Triple.TParam.Mark")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_TParam_Mark
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_TParam_Mark()
		{
			DisplayName = "C++ Documentation: Template Parameter";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Comment;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.TParam.Name")]
	[Name("Comment.Triple.TParam.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_TParam_Name
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_TParam_Name()
		{
			DisplayName = "C++ Documentation: Template Parameter: Name";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.TParam;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Triple.TParam.Desc")]
	[Name("Comment.Triple.TParam.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	[Order(After = "Comment.Triple")]
	internal sealed class Format_Comment_Triple_TParam_Desc
		: ClassificationFormatDefinition
	{
		public Format_Comment_Triple_TParam_Desc()
		{
			DisplayName = "C++ Documentation: Template Parameter: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Plain;
		}
	}

	#endregion
	#endregion
}