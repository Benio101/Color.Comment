# <img align="right" src="https://raw.githubusercontent.com/Benio101/Color.Token/master/Color.Token/Logo.ico"> Color.Token
[Visual Studio](https://visualstudio.microsoft.com) extension: Color C++ Tokens.

## Status
| Branch | Build Status
| ---   | ---
| `master` | [![Build status](https://ci.appveyor.com/api/projects/status/fduwr8hv17jn39lo/branch/master?svg=true)](https://ci.appveyor.com/project/Benio101/color-token/branch/master)

## Description
Extension adds options to overwrite colors of certain C++ Tokens in files of `ContentType` `"C/C++"`, _eg_ `.cpp` or `.h` files.

## Usage
New entries will appear in `Tools` → `Options` → `Fonts and Colors` → `Text Editor`, each will begin with `C++ Token:` prefix.
- Edit their color values, until you want to keep extension default ones (listed below).
- If you don't want to change some token's color at all, set it's `Item foreground` value to `Automatic`.

![](https://raw.githubusercontent.com/Benio101/Color.Token/master/Color.Token/Preview.png)

## List of Tokens
Extension exposes following Tokens for customization:
- All [keyword](https://en.cppreference.com/w/cpp/keyword)s, except:
  - Keywords that provide an [alternative way to represent standard tokens](https://en.cppreference.com/w/cpp/language/operator_alternative), _eg_ `xor_eq` (trigraphs are removed)
  - `register` keyword (it's unused)
- Identifiers with special meaning, except:
  - Identifiers used as [`contract-level`](http://eel.is/c++draft/gram#nt:contract-level) in [Contract Attributes](https://en.cppreference.com/w/cpp/language/attributes/contract), except `default` (it's also a keyword)

Full list of customizable Tokens, with their default colors:

| Token                      | Type      | Color      | RGB (0 – 255) |
| :---                       | :---      | :---       | :---          |
| `alignas`                  | Keyword   | Blue       | 128, 176, 224 |
| `alignof`                  | Keyword   | Blue       | 128, 176, 224 |
| `asm`                      | Assembler | Purple     | 176, 128, 224 |
| `atomic_cancel`            | Keyword   | Blue       | 128, 176, 224 |
| `atomic_commit`            | Keyword   | Blue       | 128, 176, 224 |
| `atomic_noexcept`          | Keyword   | Blue       | 128, 176, 224 |
| `auto`                     | Type      | Green      | 176, 224, 128 |
| `bool`                     | Type      | Green      | 176, 224, 128 |
| `break`                    | Flow      | Dark Blue  |  96, 128, 224 |
| `case`                     | Flow      | Dark Blue  |  96, 128, 224 |
| `catch`                    | Flow      | Dark Blue  |  96, 128, 224 |
| `char`                     | Type      | Green      | 176, 224, 128 |
| `char8_t`                  | Type      | Green      | 176, 224, 128 |
| `char16_t`                 | Type      | Green      | 176, 224, 128 |
| `char32_t`                 | Type      | Green      | 176, 224, 128 |
| `class`                    | Keyword   | Blue       | 128, 176, 224 |
| `concept`                  | Keyword   | Blue       | 128, 176, 224 |
| `const`                    | Keyword   | Blue       | 128, 176, 224 |
| `consteval`                | Keyword   | Blue       | 128, 176, 224 |
| `constexpr`                | Keyword   | Blue       | 128, 176, 224 |
| `const_cast`               | Keyword   | Blue       | 128, 176, 224 |
| `continue`                 | Flow      | Dark Blue  |  96, 128, 224 |
| `co_await`                 | Flow      | Dark Blue  |  96, 128, 224 |
| `co_return`                | Flow      | Dark Blue  |  96, 128, 224 |
| `co_yield`                 | Flow      | Dark Blue  |  96, 128, 224 |
| `decltype`                 | Keyword   | Blue       | 128, 176, 224 |
| `default`                  | Keyword   | Blue       | 128, 176, 224 |
| `delete`                   | Important | Dark Red   | 224,  96,  96 |
| `do`                       | Flow      | Dark Blue  |  96, 128, 224 |
| `double`                   | Type      | Green      | 176, 224, 128 |
| `dynamic_cast`             | Keyword   | Blue       | 128, 176, 224 |
| `else`                     | Flow      | Dark Blue  |  96, 128, 224 |
| `enum`                     | Keyword   | Blue       | 128, 176, 224 |
| `explicit`                 | Keyword   | Blue       | 128, 176, 224 |
| `export`                   | Keyword   | Blue       | 128, 176, 224 |
| `extern`                   | Keyword   | Blue       | 128, 176, 224 |
| `false`                    | Static    | Red        | 224, 128, 128 |
| `final`                    | Keyword   | Blue       | 128, 176, 224 |
| `float`                    | Type      | Green      | 176, 224, 128 |
| `for`                      | Flow      | Dark Blue  |  96, 128, 224 |
| `friend`                   | Keyword   | Blue       | 128, 176, 224 |
| `goto`                     | Flow      | Dark Blue  |  96, 128, 224 |
| `if`                       | Flow      | Dark Blue  |  96, 128, 224 |
| `import`                   | Keyword   | Blue       | 128, 176, 224 |
| `inline`                   | Keyword   | Blue       | 128, 176, 224 |
| `int`                      | Type      | Green      | 176, 224, 128 |
| `long`                     | Type      | Green      | 176, 224, 128 |
| `module`                   | Keyword   | Blue       | 128, 176, 224 |
| `mutable`                  | Keyword   | Blue       | 128, 176, 224 |
| `namespace`                | Keyword   | Blue       | 128, 176, 224 |
| `new`                      | Important | Dark Red   | 224,  96,  96 |
| `noexcept`                 | Keyword   | Blue       | 128, 176, 224 |
| `nullptr`                  | Static    | Red        | 224, 128, 128 |
| `operator`                 | Keyword   | Blue       | 128, 176, 224 |
| `override`                 | Keyword   | Blue       | 128, 176, 224 |
| `private`                  | Access    | Dark Green | 128, 176,  96 |
| `protected`                | Access    | Dark Green | 128, 176,  96 |
| `public`                   | Access    | Dark Green | 128, 176,  96 |
| `reflexpr`                 | Keyword   | Blue       | 128, 176, 224 |
| `reinterpret_cast`         | Keyword   | Blue       | 128, 176, 224 |
| `requires`                 | Keyword   | Blue       | 128, 176, 224 |
| `return`                   | Flow      | Dark Blue  |  96, 128, 224 |
| `short`                    | Type      | Green      | 176, 224, 128 |
| `signed`                   | Type      | Green      | 176, 224, 128 |
| `sizeof`                   | Keyword   | Blue       | 128, 176, 224 |
| `static`                   | Keyword   | Blue       | 128, 176, 224 |
| `static_assert`            | Keyword   | Blue       | 128, 176, 224 |
| `static_cast`              | Keyword   | Blue       | 128, 176, 224 |
| `struct`                   | Keyword   | Blue       | 128, 176, 224 |
| `switch`                   | Flow      | Dark Blue  |  96, 128, 224 |
| `synchronized`             | Keyword   | Blue       | 128, 176, 224 |
| `template`                 | Keyword   | Blue       | 128, 176, 224 |
| `this`                     | Keyword   | Blue       | 128, 176, 224 |
| `thread_local`             | Keyword   | Blue       | 128, 176, 224 |
| `throw`                    | Flow      | Dark Blue  |  96, 128, 224 |
| `transaction_safe`         | Keyword   | Blue       | 128, 176, 224 |
| `transaction_safe_dynamic` | Keyword   | Blue       | 128, 176, 224 |
| `true`                     | Static    | Red        | 224, 128, 128 |
| `try`                      | Flow      | Dark Blue  |  96, 128, 224 |
| `typedef`                  | Keyword   | Blue       | 128, 176, 224 |
| `typeid`                   | Keyword   | Blue       | 128, 176, 224 |
| `typename`                 | Keyword   | Blue       | 128, 176, 224 |
| `union`                    | Keyword   | Blue       | 128, 176, 224 |
| `unsigned`                 | Type      | Green      | 176, 224, 128 |
| `using`                    | Keyword   | Blue       | 128, 176, 224 |
| `virtual`                  | Keyword   | Blue       | 128, 176, 224 |
| `void`                     | Type      | Green      | 176, 224, 128 |
| `volatile`                 | Keyword   | Blue       | 128, 176, 224 |
| `wchar_t`                  | Type      | Green      | 176, 224, 128 |
| `while`                    | Flow      | Dark Blue  |  96, 128, 224 |
