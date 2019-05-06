using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace Color.Comment
{
	public class CommentHeader
	{
		public IClassificationType Mark;
		public IClassificationType Desc;
		public List<string> Names = new List<string>();

		public CommentHeader(
			IClassificationType Mark,
			IClassificationType Desc
		){
			this.Mark = Mark;
			this.Desc = Desc;
		}
	}

	internal class Classifier
		: IClassifier
	{
		private bool IsClassificationRunning;
		private readonly IClassifier IClassifier;

		#pragma warning disable 67
		public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
		#pragma warning restore 67

		// Comments
		private readonly IClassificationType Comment_Default;
		private readonly IClassificationType Comment_Default_Slashes;

		private readonly IClassificationType Comment_ParamRef_Param;
		private readonly IClassificationType Comment_ParamRef_Mark;
		private readonly IClassificationType Comment_TParamRef_TParam;
		private readonly IClassificationType Comment_TParamRef_Mark;
		private readonly IClassificationType Comment_MemberRef_Member;
		private readonly IClassificationType Comment_MemberRef_Mark;
		private readonly IClassificationType Comment_StaticRef_Static;
		private readonly IClassificationType Comment_StaticRef_Mark;
		private readonly IClassificationType Comment_LocalRef_Local;
		private readonly IClassificationType Comment_LocalRef_Mark;
		private readonly IClassificationType Comment_MacroRef_Macro;
		private readonly IClassificationType Comment_MacroRef_Mark;

		private readonly IClassificationType Comment_Triple;
		private readonly IClassificationType Comment_Triple_Slashes;
		private readonly IClassificationType Comment_Triple_Punct;
		private readonly IClassificationType Comment_Triple_Punct_Header;

		private readonly IClassificationType Comment_Triple_Param_Mark;
		private readonly IClassificationType Comment_Triple_Param_Name;
		private readonly IClassificationType Comment_Triple_Param_Desc;
		private readonly IClassificationType Comment_Triple_TParam_Mark;
		private readonly IClassificationType Comment_Triple_TParam_Name;
		private readonly IClassificationType Comment_Triple_TParam_Desc;

		private readonly IClassificationType Comment_​Triple_Quote_Mark;
		private readonly IClassificationType Comment_Triple_Quote_Text;
		private readonly IClassificationType Comment_Triple_Code_Mark;
		private readonly IClassificationType Comment_Triple_Code_Text;
		private readonly IClassificationType Comment_Triple_InlineCode_Mark;
		private readonly IClassificationType Comment_Triple_InlineCode_Text;

		// Comment Headers
		private readonly Dictionary<string, CommentHeader> CommentHeaders =
			new Dictionary<string, CommentHeader>();

		internal Classifier(
			IClassificationTypeRegistryService Registry,
			IClassifier Classifier
		){
			IsClassificationRunning = false;
			IClassifier = Classifier;

			// Comments
			Comment_Default =
				Registry.GetClassificationType("Comment.Default");

			Comment_Default_Slashes =
				Registry.GetClassificationType("Comment.Default.Slashes");

			Comment_ParamRef_Mark =
				Registry.GetClassificationType("Comment.ParamRef.Mark");

			Comment_ParamRef_Param =
				Registry.GetClassificationType("Comment.ParamRef.Param");

			Comment_TParamRef_Mark =
				Registry.GetClassificationType("Comment.TParamRef.Mark");

			Comment_TParamRef_TParam =
				Registry.GetClassificationType("Comment.TParamRef.TParam");

			Comment_MemberRef_Mark =
				Registry.GetClassificationType("Comment.MemberRef.Mark");

			Comment_MemberRef_Member =
				Registry.GetClassificationType("Comment.MemberRef.Member");

			Comment_StaticRef_Mark =
				Registry.GetClassificationType("Comment.StaticRef.Mark");

			Comment_StaticRef_Static =
				Registry.GetClassificationType("Comment.StaticRef.Static");

			Comment_LocalRef_Mark =
				Registry.GetClassificationType("Comment.LocalRef.Mark");

			Comment_LocalRef_Local =
				Registry.GetClassificationType("Comment.LocalRef.Local");

			Comment_MacroRef_Mark =
				Registry.GetClassificationType("Comment.MacroRef.Mark");

			Comment_MacroRef_Macro =
				Registry.GetClassificationType("Comment.MacroRef.Macro");

			Comment_Triple =
				Registry.GetClassificationType("Comment.Triple");

			Comment_Triple_Slashes =
				Registry.GetClassificationType("Comment.Triple.Slashes");

			Comment_Triple_Punct =
				Registry.GetClassificationType("Comment.Triple.Punct");

			Comment_Triple_Punct_Header =
				Registry.GetClassificationType("Comment.Triple.Punct.Header");

			Comment_Triple_Param_Mark =
				Registry.GetClassificationType("Comment.Triple.Param.Mark");

			Comment_Triple_Param_Name =
				Registry.GetClassificationType("Comment.Triple.Param.Name");

			Comment_Triple_Param_Desc =
				Registry.GetClassificationType("Comment.Triple.Param.Desc");

			Comment_Triple_TParam_Mark =
				Registry.GetClassificationType("Comment.Triple.TParam.Mark");

			Comment_Triple_TParam_Name =
				Registry.GetClassificationType("Comment.Triple.TParam.Name");

			Comment_Triple_TParam_Desc =
				Registry.GetClassificationType("Comment.Triple.TParam.Desc");

			Comment_Triple_Quote_Mark =
				Registry.GetClassificationType("Comment.Triple.Quote.Mark");

			Comment_Triple_Quote_Text =
				Registry.GetClassificationType("Comment.Triple.Quote.Text");

			Comment_Triple_Code_Mark =
				Registry.GetClassificationType("Comment.Triple.Code.Mark");

			Comment_Triple_Code_Text =
				Registry.GetClassificationType("Comment.Triple.Code.Text");

			Comment_Triple_InlineCode_Mark =
				Registry.GetClassificationType("Comment.Triple.InlineCode.Mark");

			Comment_Triple_InlineCode_Text =
				Registry.GetClassificationType("Comment.Triple.InlineCode.Text");

			// Comment Headers
			foreach (string Header in Meta.Headers){
				CommentHeaders.Add(Header, new CommentHeader(
					Registry.GetClassificationType("Comment.Triple." + Header + ".Mark"),
					Registry.GetClassificationType("Comment.Triple." + Header + ".Desc")
				));
			}

			// Effect
			CommentHeaders["Effect"].Names.Add("effects?");
			CommentHeaders["Effect"].Names.Add("briefs?");
			CommentHeaders["Effect"].Names.Add("shorts?");
			CommentHeaders["Effect"].Names.Add("details?");

			// Note
			CommentHeaders["Note"].Names.Add("notes?");
			CommentHeaders["Note"].Names.Add("attentions?");
			CommentHeaders["Note"].Names.Add("warn(ing)?s?");
			CommentHeaders["Note"].Names.Add("remarks?");
			CommentHeaders["Note"].Names.Add("pre");
			CommentHeaders["Note"].Names.Add("post");
			CommentHeaders["Note"].Names.Add("requires?");

			// Todo
			CommentHeaders["Todo"].Names.Add("to(do|fix)?");
			CommentHeaders["Todo"].Names.Add("plans?");
			CommentHeaders["Todo"].Names.Add("fixme");

			// See
			CommentHeaders["See"].Names.Add("see(also)?");
			CommentHeaders["See"].Names.Add("related?s?");

			// Bug
			CommentHeaders["Bug"].Names.Add("bugs?");
			CommentHeaders["Bug"].Names.Add("errors?");
			CommentHeaders["Bug"].Names.Add("issues?");

			// Return
			CommentHeaders["Return"].Names.Add("returns?");
			CommentHeaders["Return"].Names.Add("results?");
			CommentHeaders["Return"].Names.Add("retvals?");

			// Spare
			CommentHeaders["Spare"].Names.Add("spares?");
			CommentHeaders["Spare"].Names.Add("defaults?");
			CommentHeaders["Spare"].Names.Add("backups?");

			// Throw
			CommentHeaders["Throw"].Names.Add("except(ion)?s?");
			CommentHeaders["Throw"].Names.Add("throws?");
		}

		public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan Span){
			if (IsClassificationRunning) return new List<ClassificationSpan>();

			try
			{
				IsClassificationRunning = true;
				return Classify(Span);
			}

			finally
			{
				IsClassificationRunning = false;
			}
		}

		private IList<ClassificationSpan> Classify(SnapshotSpan Span){
			IList<ClassificationSpan> Spans = new List<ClassificationSpan>();

			if (Span.IsEmpty) return Spans;
			string Text = Span.GetText();

			// Offset from begin of Span's Text and current Text.
			int Offset = 0;

			// Additional offset to add to @Offset on current iteration.
			int CurrentOffset;

			NextComment:
			foreach (Match Match in new Regex(
					@"(?<Star>\*)?"
				+	@"(?<Slashes>(?<!/)(/{2,}))[ \t\v\f]*"
				+	@"(?<Comment>[^\n]*)"
			).Matches(Text))
			{
				// Offset in current iteration that matches trailing "*"' or "*/"'s length.
				int StarOffset = 0;

				// If "*" is matched, check if it's not end of comment.
				// If it's end of comment, skip both "*" and next "/".
				// Otherwise, skip just "*" as it's not part of comment.
				if (Match.Groups["Star"].Length > 0){
					var StarSpan = new SnapshotSpan(Span.Snapshot, new Span(
						Span.Start + Offset + Match.Groups["Star"].Index,
						Match.Groups["Star"].Length
					));

					bool IsStarComment = false;
					var StarIntersections = IClassifier.GetClassificationSpans(StarSpan);
					foreach (ClassificationSpan Intersection in StarIntersections){
						var Classifications = Intersection.ClassificationType.Classification.Split(
							new[]{" - "}, StringSplitOptions.None
						);

						// Comment must be classified as either "comment" or "XML Doc Comment".
						if (Utils.IsClassifiedAs(Classifications, new string[]{
							PredefinedClassificationTypeNames.Comment,
							"XML Doc Comment"
						})){
							IsStarComment = true;
						}
					}

					// Star is part of comment, eg "/* multiline comment followed by single *///".
					if (IsStarComment) StarOffset = 2;

					// Star is not part of comment, eg "int i = 3 */// Triple it! \n\t 5 // 15".
					else StarOffset = 1;
				}

				var MatchedSpan = new SnapshotSpan(Span.Snapshot, new Span(
					Span.Start + Offset + StarOffset + Match.Index,
					Match.Length - StarOffset
				));

				var Intersections = IClassifier.GetClassificationSpans(MatchedSpan);
				foreach (ClassificationSpan Intersection in Intersections){
					var Classifications = Intersection.ClassificationType.Classification.Split(
						new[]{" - "}, StringSplitOptions.None
					);

					// Comment must be classified as either "comment" or "XML Doc Comment".
					if (!Utils.IsClassifiedAs(Classifications, new string[]{
						PredefinedClassificationTypeNames.Comment,
						"XML Doc Comment"
					})){
						goto SkipComment;
					}

					// Prevent recursive matching fragment of comment as another comment.
					if (Utils.IsClassifiedAs(Classifications, new string[]{
						"Comment.Default",
						"Comment.Triple"
					})){
						goto SkipComment;
					}
				}

				IClassificationType Comment = Comment_Default;
				IClassificationType Comment_Slashes = Comment_Default_Slashes;

				// Start offset of slashes (without star part: either "*" or "*/").
				int SlashesStart = Span.Start + Offset + Match.Groups["Slashes"].Index;
				if (StarOffset == 2) SlashesStart += 1;

				// Slashes length (optionally without first "/" as it's end of multiline comment).
				int SlashesLength = Match.Groups["Slashes"].Length;
				if (StarOffset == 2) SlashesLength -= 1;

				// If comment is triple slash (begins with "///").
				bool IsTripleSlash = SlashesLength == 3;

				if (IsTripleSlash){
					Comment = Comment_Triple;
					Comment_Slashes = Comment_Triple_Slashes;
				}

				Spans.Add(new ClassificationSpan(new SnapshotSpan(
					Span.Snapshot, new Span(
						Span.Start + Offset + StarOffset + Match.Index,
						Match.Length - StarOffset
					)), Comment
				));

				Spans.Add(new ClassificationSpan(new SnapshotSpan(
					Span.Snapshot, new Span(
						SlashesStart,
						SlashesLength
					)), Comment_Slashes
				));

				string CommentText = Match.Groups["Comment"].Value;
				int CommentStart = Span.Start + Offset + Match.Groups["Comment"].Index;

				if (IsTripleSlash)
				{
					#region Headers

					foreach (string Header in Meta.Headers){
						var List = string.Join("|", CommentHeaders[Header].Names.ToArray());
						foreach (Match CommentMatch in new Regex(
								@"^(?<Punct_Header>[\\@])"
							+	@"(?<Mark>(" + List + @")(?!" + Utils.Identifier + @"))"
							+	@"[ \t\v\f]*(?<Punct>[:=]?)" + @"[ \t\v\f]*"
							+	@"(?<Desc>[^\n]*)"

							,	RegexOptions.IgnoreCase
						).Matches(CommentText))
						{
							if (CommentMatch.Groups["Punct_Header"].Length > 0)
							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Punct_Header"].Index,
									CommentMatch.Groups["Punct_Header"].Length
								)
							), Comment_Triple_Punct_Header));

							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Mark"].Index,
									CommentMatch.Groups["Mark"].Length
								)
							), CommentHeaders[Header].Mark));

							if (CommentMatch.Groups["Punct"].Length > 0)
							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Punct"].Index,
									CommentMatch.Groups["Punct"].Length
								)
							), Comment_Triple_Punct));

							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Desc"].Index,
									CommentMatch.Groups["Desc"].Length
								)
							), CommentHeaders[Header].Desc));
						}
					}

					#endregion
					#region Param & TParam

					foreach (string Header in new string[]{"Param", "TParam"}){
						foreach (Match CommentMatch in new Regex(
								@"^(?<Punct_Header>[\\@])?"
							+	@"(?<Mark>(" + Header + @")(?!" + Utils.Identifier + @"))"
							+	@"[ \t\v\f]*(?<Name>(" + Utils.Identifier + @"|(?=\.{3}))(\.{3})?)"
							+	@"[ \t\v\f]*(?<Punct>[:=]?)" + @"[ \t\v\f]*"
							+	@"(?<Desc>[^\n]*)"

							,	RegexOptions.IgnoreCase
						).Matches(CommentText))
						{
							IClassificationType Mark = Comment_Triple_Param_Mark;
							IClassificationType Name = Comment_Triple_Param_Name;
							IClassificationType Desc = Comment_Triple_Param_Desc;

							if (Header == "TParam"){
								Mark = Comment_Triple_TParam_Mark;
								Name = Comment_Triple_TParam_Name;
								Desc = Comment_Triple_TParam_Desc;
							}

							if (CommentMatch.Groups["Punct_Header"].Length > 0)
							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Punct_Header"].Index,
									CommentMatch.Groups["Punct_Header"].Length
								)
							), Comment_Triple_Punct_Header));

							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Mark"].Index,
									CommentMatch.Groups["Mark"].Length
								)
							), Mark));

							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Name"].Index,
									CommentMatch.Groups["Name"].Length
								)
							), Name));

							if (CommentMatch.Groups["Punct"].Length > 0)
							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Punct"].Index,
									CommentMatch.Groups["Punct"].Length
								)
							), Comment_Triple_Punct));

							Spans.Add(new ClassificationSpan(new SnapshotSpan(
								Span.Snapshot, new Span(
									CommentStart + CommentMatch.Groups["Desc"].Index,
									CommentMatch.Groups["Desc"].Length
								)
							), Desc));
						}
					}

					#endregion

					bool SkipInlineMatching = false;

					#region Quote

					foreach (Match CommentMatch in new Regex(
							@"^(?<Mark>>)"
						+	@"[ \t\v\f]*(?<Desc>[^\n]*)"
					).Matches(CommentText))
					{
						Spans.Add(new ClassificationSpan(new SnapshotSpan(
							Span.Snapshot, new Span(
								CommentStart + CommentMatch.Groups["Mark"].Index,
								CommentMatch.Groups["Mark"].Length
							)
						), Comment_Triple_Quote_Mark));

						if (CommentMatch.Groups["Desc"].Length > 0)
						Spans.Add(new ClassificationSpan(new SnapshotSpan(
							Span.Snapshot, new Span(
								CommentStart + CommentMatch.Groups["Desc"].Index,
								CommentMatch.Groups["Desc"].Length
							)
						), Comment_Triple_Quote_Text));

						SkipInlineMatching = true;
					}

					if (SkipInlineMatching)
					goto FinishClassification;

					#endregion
					#region Code

					foreach (Match CommentMatch in new Regex(
							@"^(?<Mark>//)"
						+	@"[ \t\v\f]*(?<Desc>[^\n]*)"
					).Matches(CommentText))
					{
						Spans.Add(new ClassificationSpan(new SnapshotSpan(
							Span.Snapshot, new Span(
								CommentStart + CommentMatch.Groups["Mark"].Index,
								CommentMatch.Groups["Mark"].Length
							)
						), Comment_Triple_Code_Mark));

						if (CommentMatch.Groups["Desc"].Length > 0)
						Spans.Add(new ClassificationSpan(new SnapshotSpan(
							Span.Snapshot, new Span(
								CommentStart + CommentMatch.Groups["Desc"].Index,
								CommentMatch.Groups["Desc"].Length
							)
						), Comment_Triple_Code_Text));

						SkipInlineMatching = true;
					}

					if (SkipInlineMatching)
					goto FinishClassification;

					#endregion
				}

				var InlineCodePositions = new List<(int Min, int Max)>{};

				#region InlineCode

				foreach (Match CommentMatch in new Regex(
						@"(?<Mark_Open>`)"
					+	@"(?<Code>[^`]*)"
					+	@"(?<Mark_Close>`)"
				).Matches(CommentText))
				{
					if (CommentMatch.Groups["Mark_Open"].Length > 0)
					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Mark_Open"].Index,
							CommentMatch.Groups["Mark_Open"].Length
						)
					), Comment_Triple_InlineCode_Mark));

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Code"].Index,
							CommentMatch.Groups["Code"].Length
						)
					), Comment_Triple_InlineCode_Text));

					if (CommentMatch.Groups["Mark_Close"].Length > 0)
					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Mark_Close"].Index,
							CommentMatch.Groups["Mark_Close"].Length
						)
					), Comment_Triple_InlineCode_Mark));

					InlineCodePositions.Add((
						CommentMatch.Groups["Code"].Index,
						CommentMatch.Groups["Mark_Close"].Index
					));
				}

				#endregion
				#region ParamRef

				if(
						Options.ColorParamRef == Option_ReferenceType.All
					||	(
								Options.ColorParamRef == Option_ReferenceType.Triple
							&&	IsTripleSlash
						)
				)
				foreach (Match CommentMatch in new Regex(
						@"(?<Mark>\$)"
					+	@"(?<Param>" + Utils.Identifier + @")"
				).Matches(CommentText))
				{
					var MarkIndex = CommentMatch.Groups["Mark"].Index;
					foreach (var (Min, Max) in InlineCodePositions){
						if (MarkIndex >= Min && MarkIndex <= Max){
							goto SkipParamRef;
						}
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + MarkIndex,
							CommentMatch.Groups["Mark"].Length
						)
					), Comment_ParamRef_Mark));

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Param"].Index,
							CommentMatch.Groups["Param"].Length
						)
					), Comment_ParamRef_Param));

					SkipParamRef:;
				}

				#endregion
				#region TParamRef

				if(
						Options.ColorTParamRef == Option_ReferenceType.All
					||	(
								Options.ColorTParamRef == Option_ReferenceType.Triple
							&&	IsTripleSlash
						)
				)
				foreach (Match CommentMatch in new Regex(
						@"(?<Mark>\^)"
					+	@"(?<TParam>" + Utils.Identifier + @")"
				).Matches(CommentText))
				{
					var MarkIndex = CommentMatch.Groups["Mark"].Index;
					foreach (var (Min, Max) in InlineCodePositions){
						if (MarkIndex >= Min && MarkIndex <= Max){
							goto SkipTParamRef;
						}
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + MarkIndex,
							CommentMatch.Groups["Mark"].Length
						)
					), Comment_TParamRef_Mark));

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["TParam"].Index,
							CommentMatch.Groups["TParam"].Length
						)
					), Comment_TParamRef_TParam));

					SkipTParamRef:;
				}

				#endregion
				#region MemberRef

				if(
						Options.ColorMemberRef == Option_ReferenceType.All
					||	(
								Options.ColorMemberRef == Option_ReferenceType.Triple
							&&	IsTripleSlash
						)
				)
				foreach (Match CommentMatch in new Regex(
						@"(?<Mark>\$)"
					+	@"(?<Member>" + Utils.Identifier + @")"
				).Matches(CommentText))
				{
					var MarkIndex = CommentMatch.Groups["Mark"].Index;
					foreach (var (Min, Max) in InlineCodePositions){
						if (MarkIndex >= Min && MarkIndex <= Max){
							goto SkipMemberRef;
						}
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + MarkIndex,
							CommentMatch.Groups["Mark"].Length
						)
					), Comment_MemberRef_Mark));

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Member"].Index,
							CommentMatch.Groups["Member"].Length
						)
					), Comment_MemberRef_Member));

					SkipMemberRef:;
				}

				#endregion
				#region StaticRef

				if(
						Options.ColorStaticRef == Option_ReferenceType.All
					||	(
								Options.ColorStaticRef == Option_ReferenceType.Triple
							&&	IsTripleSlash
						)
				)
				foreach (Match CommentMatch in new Regex(
						@"(?<Mark>\$)"
					+	@"(?<Static>" + Utils.Identifier + @")"
				).Matches(CommentText))
				{
					var MarkIndex = CommentMatch.Groups["Mark"].Index;
					foreach (var (Min, Max) in InlineCodePositions){
						if (MarkIndex >= Min && MarkIndex <= Max){
							goto SkipStaticRef;
						}
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + MarkIndex,
							CommentMatch.Groups["Mark"].Length
						)
					), Comment_StaticRef_Mark));

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Static"].Index,
							CommentMatch.Groups["Static"].Length
						)
					), Comment_StaticRef_Static));

					SkipStaticRef:;
				}

				#endregion
				#region LocalRef

				if(
						Options.ColorLocalRef == Option_ReferenceType.All
					||	(
								Options.ColorLocalRef == Option_ReferenceType.Triple
							&&	IsTripleSlash
						)
				)
				foreach (Match CommentMatch in new Regex(
						@"(?<Mark>\$)"
					+	@"(?<Local>" + Utils.Identifier + @")"
				).Matches(CommentText))
				{
					var MarkIndex = CommentMatch.Groups["Mark"].Index;
					foreach (var (Min, Max) in InlineCodePositions){
						if (MarkIndex >= Min && MarkIndex <= Max){
							goto SkipLocalRef;
						}
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + MarkIndex,
							CommentMatch.Groups["Mark"].Length
						)
					), Comment_LocalRef_Mark));

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Local"].Index,
							CommentMatch.Groups["Local"].Length
						)
					), Comment_LocalRef_Local));

					SkipLocalRef:;
				}

				#endregion
				#region MacroRef

				if(
						Options.ColorMacroRef == Option_ReferenceType.All
					||	(
								Options.ColorMacroRef == Option_ReferenceType.Triple
							&&	IsTripleSlash
						)
				)
				foreach (Match CommentMatch in new Regex(
						@"(?<Mark>\$)"
					+	@"(?<Macro>" + Utils.Identifier + @")"
				).Matches(CommentText))
				{
					var MarkIndex = CommentMatch.Groups["Mark"].Index;
					foreach (var (Min, Max) in InlineCodePositions){
						if (MarkIndex >= Min && MarkIndex <= Max){
							goto SkipMacroRef;
						}
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + MarkIndex,
							CommentMatch.Groups["Mark"].Length
						)
					), Comment_MacroRef_Mark));

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
							CommentStart + CommentMatch.Groups["Macro"].Index,
							CommentMatch.Groups["Macro"].Length
						)
					), Comment_MacroRef_Macro));

					SkipMacroRef:;
				}

				#endregion

				FinishClassification:
				CurrentOffset = Match.Index + Match.Length;
				Text = Text.Substring(CurrentOffset);
				Offset += CurrentOffset;
				goto NextComment;

				SkipComment:
				CurrentOffset =
						Match.Groups["Slashes"].Index
					+	Match.Groups["Slashes"].Length
				;

				Text = Text.Substring(CurrentOffset);
				Offset += CurrentOffset;
				goto NextComment;
			}

			return Spans;
		}
	}
}