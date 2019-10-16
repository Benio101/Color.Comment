# <img align="right" src="https://raw.githubusercontent.com/Benio101/Color.Comment/master/Color.Comment/Logo.ico"> Color.Comment
[Visual Studio](https://visualstudio.microsoft.com) extension: Color C++ Comments.

## Status
| Branch | Build Status
| ---    | ---
| [`master`](https://github.com/Benio101/Color.Comment/tree/master) | [![Build status](https://ci.appveyor.com/api/projects/status/ye6htg4leuapsaxq/branch/master?svg=true)](https://ci.appveyor.com/project/Benio101/color-comment/branch/master)
| [`2017`](https://github.com/Benio101/Color.Comment/tree/2017) | [![Build status](https://ci.appveyor.com/api/projects/status/ye6htg4leuapsaxq/branch/2017?svg=true)](https://ci.appveyor.com/project/Benio101/color-comment/branch/2017)

## Description
Extension adds options to overwrite colors of certain C++ Comments.<br>
Extension works in files of `ContentType` `"C/C++"`, _eg_ `.cpp` or `.h` files.

## Usage
New entries will appear in `Tools` → `Options` → `Environment` → `Fonts and Colors` → `Text Editor`.<br>
Each will begin with either `C++ Comments:` xor  `C++ Documentation:` prefix.
- Edit their color values, until you want to keep extension default ones (listed below).
- If you don't want to change some attribute's color at all, set it's `Item foreground` value to `Automatic`.

![](https://raw.githubusercontent.com/Benio101/Color.Comment/master/Color.Comment/Preview.png)

## Preview
| Default Comments without extension | Color Comments with extension enabled
| --- | ---
| ![](https://raw.githubusercontent.com/Benio101/Color.Comment/master/Color.Comment/PreviewDisabled.png) | ![](https://raw.githubusercontent.com/Benio101/Color.Comment/master/Color.Comment/PreviewEnabled.png)

## Options
New entries will appear in `Tools` → `Options` → `Color.Comment`. Each corresponds to different feature.<br>
Options allows to disable, enable xor conditionally enable related features (coloring blocks of comments).

![](https://raw.githubusercontent.com/Benio101/Color.Comment/master/Color.Comment/Options.png)

### States
Full list of option states:

| Enum     | State                                  | Meaning                                                                  |
| :---     | :---                                   | :---                                                                     |
| `No`     | No                                     | Disable feature (don't overwrite color of it's occurencies)              |
| `All`    | Yes, in all comments                   | Enable feature (overwrite color of it's occurencies)                     |
| `Triple` | Yes, but in triple slash comments only | _As above_, but only in triple slash comments _(that begins with `///`)_ |

### Details
Full list of options (Default state: `Triple`: Yes, but in triple slash comments only):

| Option                              | Details                                        |
| :---                                | :---                                           |
| Color parameter references          | Prefixed by `$`                                |
| Color template parameter references | Prefixed by `^`                                |
| Color member references             | Prefixed by `.`                                |
| Color static references             | Prefixed by `!`                                |
| Color local references              | Prefixed by `@`                                |
| Color macro references              | Prefixed by `%`                                |
| Color line–wide quotes              | Prefixed by `>`                                |
| Color line–wide code                | Prefixed by `//`                               |
| Color inline code                   | Surrounded by U+0060 ``​`​`` GRAVE ACCENT symbol |

### Note
Note that editing options does not take immediate effect to keep performance.<br>
It requires reclassification, _eg_ triggered by editing corresponding part of code.

## Customization
Extension exposes several entries for customization across two kinds of comments to customize:
- `C++ Comment` prefixed ones refers to Regular comments (all but triple slash comments, _eg_ `//`, `////` or `/////`).
- `C++ Documentation` prefixed ones refers to Documentation comments (triple slash comments (that begins with `///`).

Multiline comments are not supported. They will be untouched by this extensions, so shall remain default coloring.

### Quotes
Quotes are line–wide blocks of comments which value begins with `>`.

#### Option
Option that enables quotes is `C++ Comment: Quote`.

#### Example
```cpp
/// > Talk is cheap. Show me the code.
/// ~ Linus Torvalds
```

- `Talk is cheap. Show me the code.` is a quote and will be colored as `C++ Comment: Quote`.
- `>` is a quote mark and will be colored as `C++ Comment: Quote: ">"`.

### Code
Codes are line–wide blocks of comments which value begins with `//`.

#### Option
Option that enables quotes is `Color line–wide code`.

#### Example
```cpp
/// Close connection.
/// Example usage:
/// // Connection.Close();
void Close();
```

- `Connection.Close();` is a code and will be colored as `C++ Comment: Code`.
- `//` is a code mark and will be colored as `C++ Comment: Code: "//"`.

### Inline Code
Inline Codes are blocks of comments surrounded by Grave Accent (U+0060 ``​`​``) symbol.

#### Option
Option that enables quotes is `Color inline code`.

#### Example
```cpp
/// Begin a new session.
/// \note On a debug mode, .Ping `10.0.0.2` upon session creation.
void Begin();
```

- `10.0.0.2` is an inline code and will be colored as `C++ Comment: Inline Code`.
- Both ``​`​`` are an inline code marks and will be colored as ``C++ Comment: Inline Code: "`"``.

### References
References are inline mentions of entities (functions, variables _etc._) in comments.<br>
References consist of a single punctuation character immediatelly followed by an identifier.<br>
For example: `$Left` references parameter `Left`; `^Floating` references template parameter `Floating`.

#### Options
Options that enables references are:
- `Color parameter references`
- `Color template parameter references`
- `Color member references`
- `Color static references`
- `Color local references`
- `Color macro references`

#### Example
```cpp
/// Cache with absolute value of .Result
unsigned int Cache_AbsResult = 0;
```
- `.Result` is a reference to `Result` member. `Result` will be colored as `C++ Comment: Reference: Member`.
- `.` is a member reference mark and will be colored as `C++ Comment: Reference: Member: "."`.

#### Details
Full list of references:
  
| Reference          | Prefix |
| :---               | :---   |
| Parameter          | `$`    |
| Template Parameter | `^`    |
| Member             | `.`    |
| Static             | `!`    |
| Local              | `@`    |
| Macro              | `%`    |

### Headers
Headers are line–wide documentation commands for tools like Doxygen or Standardese.<br>
Headers are enabled for triple slash `C++ Documentation` comments only (that begins with `///`).<br>
Headers begins with either `@` or `\`, immediatelly followed by an identifier.

#### Details
- Headers format of Parameters and Template Parameters:<br>
`[\\@]` Identifier `[ \t\v\f]*` Identifier`?` `...?` `[ \t\v\f]*` `([:=])?` `.*`, _ie_ `\param Right Exponent` value.
- Header format for all the rest:<br>
`[\\@]` Identifier `[ \t\v\f]*` `([:=])?` `.*`, _ie_ `\short Description.`.

#### Examples
```cpp
/// \short Description.
/// @details : More info.
/// \param Right Exponent value.
/// @tparam Floating = Type convertible to `float`.
```

#### Details
Full List of supported Headers:

| Header | Command                                                   |
| :---   | :---                                                      |
| Effect | `effects?\|briefs?\|shorts?\|details?`                    |
| Note   | `notes?\|attentions?\|warn(ing)?s?\|pre\|post\|requires?` |
| Todo   | `to(do\|fix)?\|plans?\|fixme`                             |
| See    | `see(also)?\|related?s?`                                  |
| Bug    | `bugs?\|errors?\|issues?`                                 |
| Return | `returns?\|results?\|retvals?`                            |
| Spare  | `spares?\|defaults?\|backups?`                            |
| Throw  | `except(ion)?s?\|throws?`                                 |

## Details
Full list of customizable Comment entries, with their default colors:

| Comment entry                                      | Type          | Color           | RGB (0 – 255) |
| :---                                               | :---          | :---            | :---          |
| C++ Comment                                        | Comment       | Gray            | 128, 128, 128 |
| C++ Comment: "//"                                  | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Reference: Parameter: "$"             | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Reference: Parameter                  | Param         | Orange          | 224, 176, 128 |
| C++ Comment: Reference: Template Parameter: "^"    | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Reference: Template Parameter         | TParam        | Purple          | 176, 128, 224 |
| C++ Comment: Reference: Member: "."                | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Reference: Member                     | Member        | Yellow          | 224, 224, 128 |
| C++ Comment: Reference: Static: "!"                | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Reference: Static                     | Static        | Red             | 224, 128, 128 |
| C++ Comment: Reference: Local: "@"                 | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Reference: Local                      | Local         | White           | 224, 224, 224 |
| C++ Comment: Reference: Macro: "%"                 | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Reference: Macro                      | Macro         | Purple          | 176, 128, 224 |
| C++ Comment: Quote: ">"                            | Dark String   | Very Dark Green | ​ 80, ​ 96, ​ 64 |
| C++ Comment: Quote                                 | String        | Dark Green      | 128, 176, ​ 96 |
| C++ Comment: Code: "//"                            | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Code                                  | Comment       | Gray            | 128, 128, 128 |
| C++ Comment: Inline Code: "\`"                     | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Comment: Inline Code                           | Comment       | Gray            | 128, 128, 128 |
| C++ Documentation                                  | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: "///"                           | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Documentation: Punctuation                     | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Documentation: Punctuation: \"@\" \| \"\\\"    | Comment Punct | Dark Gray       | ​ 80, ​ 80, ​ 80 |
| C++ Documentation: Effect                          | Effect        | Blue            | 128, 176, 224 |
| C++ Documentation: Effect: Description             | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Note                            | Note          | Yellow          | 224, 224, 128 |
| C++ Documentation: Note: Description               | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Todo                            | Todo          | Pink            | 224, 128, 224 |
| C++ Documentation: Todo: Description               | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: See                             | Effect        | Green           | 176, 224, 128 |
| C++ Documentation: See: Description                | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Bug                             | Effect        | Dark Red        | 224, ​ 96, ​ 96 |
| C++ Documentation: Bug: Description                | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Return                          | Return        | Dark Blue       | ​ 96, 128, 224 |
| C++ Documentation: Return: Description             | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Spare                           | Spare         | Green           | 176, 224, 128 |
| C++ Documentation: Spare: Description              | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Throw                           | Throw         | Red             | 224, 128, 128 |
| C++ Documentation: Throw: Description              | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Parameter                       | Comment       | Gray            | 128, 128, 128 |
| C++ Documentation: Parameter: Name                 | Param         | Orange          | 224, 176, 128 |
| C++ Documentation: Parameter: Description          | Plain         | Dark White      | 176, 176, 176 |
| C++ Documentation: Template Parameter              | Comment       | Gray            | 128, 128, 128 |
| C++ Documentation: Template Parameter: Name        | TParam        | Purple          | 176, 128, 224 |
| C++ Documentation: Template Parameter: Description | Plain         | Dark White      | 176, 176, 176 |

## Older versions
### 2017
- Branch: [`2017`](https://github.com/Benio101/Color.Comment/tree/2017)
- Release: [`0.1.0.1+2017`](https://github.com/Benio101/Color.Comment/releases/tag/0.1.0.1%2B2017)
- Download: [`Color.Comment.vsix`](https://github.com/Benio101/Color.Comment/releases/download/0.1.0.1%2B2017/Color.Comment.vsix)
- Marketplace: [`Color.Comment (2017)`](https://marketplace.visualstudio.com/items?itemName=Benio.ColorComment)
