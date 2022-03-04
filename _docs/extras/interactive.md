---
title: Interactive Code Blocks
tags: 
 - jekyll
 - codefence
 - github
---

<link href="//codefence.io/codefence.css" rel="stylesheet">
<script defer type="text/javascript" src="//codefence.io/codefence.js"></script>

# Interactive Code Blocks

Thanks to <a href="https://codefence.io/" target="_blank">codefence</a> you can easily
embed interactive code snippets in your documentation! Note that we have added
the style and javascript file in <a href="https://github.com/vsoch/mkdocs-jekyll/blob/master/_docs/extras/interface.md" target="_blank">this template</a>,
that way we don't add extra code or styles to pages that don't need it.

# Examples

These are from the main codefence page. The goal is to show all the languages supported!
Heck, I bet there are a lot of new languages here!

## C


<code-fence lang="c" heading="Hello Dinosaur from C">
<textarea vue-slot="code">
#include &lt;stdio.h&gt;

int main() {
    printf("Hello Dinosaur from C");
    return 0;
}
</textarea>
</code-fence>

```html
<code-fence lang="c" heading="Hello Dinosaur from C">
<textarea vue-slot="code">
#include &lt;stdio.h&gt;

int main() {
    printf("Hello Dinosaur from C");
    return 0;
}
</textarea>
</code-fence>
```

## C++

<code-fence lang="cpp" heading="Hello Dinosaur from C++">
<textarea vue-slot="code">
#include &lt;iostream&gt;

int main() {
    std::cout &lt;&lt; "Hello Dinosaur from C++";
    return 0;
}
</textarea>
</code-fence>


```html
<code-fence lang="cpp" heading="Hello Dinosaur from C++">
<textarea vue-slot="code">
#include &lt;iostream&gt;

int main() {
    std::cout &lt;&lt; "Hello Dinosaur from C++";
    return 0;
}
</textarea>
</code-fence>
```

## C#


<code-fence lang="cs" heading="Hello Dinosaur from C#">
<textarea vue-slot="code">
Console.WriteLine("Hello Dinosaur from C#");
</textarea>
</code-fence>


```html
<code-fence lang="cs" heading="Hello Dinosaur from C#">
<textarea vue-slot="code">
Console.WriteLine("Hello Dinosaur from C#");
</textarea>
</code-fence>
```

## Clojure


<code-fence lang="clojure" heading="Hello Dinosaur from Clojure">
<textarea vue-slot="code">
(ns main)
(defn -main [] (
  println "Hello Dinosaur from Clojure")
)
</textarea>
</code-fence>

```html
<code-fence lang="clojure" heading="Hello Dinosaur from Clojure">
<textarea vue-slot="code">
(ns main)
(defn -main [] (
  println "Hello Dinosaur from Clojure")
)
</textarea>
</code-fence>
```

## Elixir

<code-fence lang="elixir" heading="Hello Dinosaur from Elixir">
<textarea vue-slot="code">
IO.puts("Hello Dinosaur from Elixir")
</textarea>
</code-fence>

```html
<code-fence lang="elixir" heading="Hello Dinosaur from Elixir">
<textarea vue-slot="code">
IO.puts("Hello Dinosaur from Elixir")
</textarea>
</code-fence>
```

## Crystal

<code-fence lang="crystal" heading="Hello Dinosaur from Crystal">
<textarea vue-slot="code">
puts "Hello Dinosaur from Crystal"
</textarea>
</code-fence>

```html
<code-fence lang="crystal" heading="Hello Dinosaur from Crystal">
<textarea vue-slot="code">
puts "Hello Dinosaur from Crystal"
</textarea>
</code-fence>
```

## Erlang

<code-fence lang="erlang" heading="Hello Dinosaur from Erlang">
<textarea vue-slot="code">
-module(main).
-export([start/0]).

start() ->
    io:fwrite("Hello Dinosaur from Erlang").
</textarea>
</code-fence>

```html
<code-fence lang="erlang" heading="Hello Dinosaur from Erlang">
<textarea vue-slot="code">
-module(main).
-export([start/0]).

start() ->
    io:fwrite("Hello Dinosaur from Erlang").
</textarea>
</code-fence>
```

## Asm

<code-fence lang="asm" heading="Hello Dinosaur from GNU Assembly">
<textarea vue-slot="code">
    .global _start
    .text
_start:
    # write(1, message, 26)
    mov     $1, %rax                # system call 1 is write
    mov     $1, %rdi                # file handle 1 is stdout
    mov     $message, %rsi          # address of string to output
    mov     $26, %rdx               # number of bytes
    syscall                         # invoke operating system to do the write

    # exit(0)
    mov     $60, %rax               # system call 60 is exit
    xor     %rdi, %rdi              # we want return code 0
    syscall                         # invoke operating system to exit
message:
    .ascii  "Hello Dinosaur from Assembly\n"
</textarea>
</code-fence>

```html
<code-fence lang="asm" heading="Hello Dinosaur from GNU Assembly">
<textarea vue-slot="code">
    .global _start
    .text
_start:
    # write(1, message, 26)
    mov     $1, %rax                # system call 1 is write
    mov     $1, %rdi                # file handle 1 is stdout
    mov     $message, %rsi          # address of string to output
    mov     $26, %rdx               # number of bytes
    syscall                         # invoke operating system to do the write

    # exit(0)
    mov     $60, %rax               # system call 60 is exit
    xor     %rdi, %rdi              # we want return code 0
    syscall                         # invoke operating system to exit
message:
    .ascii  "Hello Dinosaur from Assembly\n"
</textarea>
</code-fence>
```


## Go

<code-fence lang="go" heading="Hello Dinosaur from Go">
<textarea vue-slot="code">
package main
import "fmt"
func main() {
    fmt.Println("Hello Dinosaur from Go")
}
</textarea>
</code-fence>

```html
<code-fence lang="go" heading="Hello Dinosaur from Go">
<textarea vue-slot="code">
package main
import "fmt"
func main() {
    fmt.Println("Hello Dinosaur from Go")
}
</textarea>
</code-fence>
```

## Haskell

<code-fence lang="haskell" heading="Hello Dinosaur from Haskell">
<textarea vue-slot="code">
main = putStrLn "Hello Dinosaur from Haskell"
</textarea>
</code-fence>

```html
<code-fence lang="haskell" heading="Hello Dinosaur from Haskell">
<textarea vue-slot="code">
main = putStrLn "Hello Dinosaur from Haskell"
</textarea>
</code-fence>
```

## Java

<code-fence lang="java" heading="Hello Dinosaur from Java">
<textarea vue-slot="code">
class Main {
    public static void main(String args[]) {
        System.out.println("Hello Dinosaur from Java");
    }
}
</textarea>
</code-fence>

```html
<code-fence lang="java" heading="Hello Dinosaur from Java">
<textarea vue-slot="code">
class Main {
    public static void main(String args[]) {
        System.out.println("Hello Dinosaur from Java");
    }
}
</textarea>
</code-fence>
```

## Kotlin

<code-fence lang="kotlin" heading="Hello Dinosaur from Kotlin">
<textarea vue-slot="code">
fun main() {
    println("Hello Dinosaur from Kotlin")
}
</textarea>
</code-fence>

```html
<code-fence lang="kotlin" heading="Hello Dinosaur from Kotlin">
<textarea vue-slot="code">
fun main() {
    println("Hello Dinosaur from Kotlin")
}
</textarea>
</code-fence>
```

## Lua

<code-fence lang="lua" heading="Hello Dinosaur from Lua">
<textarea vue-slot="code">
print("Hello Dinosaur from Lua")
</textarea>
</code-fence>

```html
<code-fence lang="lua" heading="Hello Dinosaur from Lua">
<textarea vue-slot="code">
print("Hello Dinosaur from Lua")
</textarea>
</code-fence>
```

## Node

<code-fence lang="node" heading="Hello Dinosaur from JavaScript">
<textarea vue-slot="code">
console.log("Hello Dinosaur from JavaScript")
</textarea>
</code-fence>


```html
<code-fence lang="node" heading="Hello Dinosaur from JavaScript">
<textarea vue-slot="code">
console.log("Hello Dinosaur from JavaScript")
</textarea>
</code-fence>
```

## Php

<code-fence lang="php" heading="Hello Dinosaur from PHP">
<textarea vue-slot="code">
&lt;?php echo "Hello Dinosaur from PHP";
</textarea>
</code-fence>

```html
<code-fence lang="php" heading="Hello Dinosaur from PHP">
<textarea vue-slot="code">
&lt;?php echo "Hello Dinosaur from PHP";
</textarea>
</code-fence>
```

## Python

<code-fence lang="python" heading="Hello Dinosaur from Python">
<textarea vue-slot="code">
print("Hello Dinosaur from Python")
</textarea>
</code-fence>

```html
<code-fence lang="python" heading="Hello Dinosaur from Python">
<textarea vue-slot="code">
print("Hello Dinosaur from Python")
</textarea>
</code-fence>
```

## R

<code-fence lang="r" heading="Hello Dinosaur from R">
<textarea vue-slot="code">
print("Hello Dinosaur from R")
</textarea>
</code-fence>

```html
<code-fence lang="r" heading="Hello Dinosaur from R">
<textarea vue-slot="code">
print("Hello Dinosaur from R")
</textarea>
</code-fence>
```

## Ruby

<code-fence lang="ruby" heading="Hello Dinosaur from Ruby">
<textarea vue-slot="code">
puts "Hello Dinosaur from Ruby"
</textarea>
</code-fence>

```html
<code-fence lang="ruby" heading="Hello Dinosaur from Ruby">
<textarea vue-slot="code">
puts "Hello Dinosaur from Ruby"
</textarea>
</code-fence>
```

## Rust

<code-fence lang="rust" heading="Hello Dinosaur from Rust">
<textarea vue-slot="code">
fn main() {
    println!("Hello Dinosaur from Rust");
}
</textarea>
</code-fence>

```html
<code-fence lang="rust" heading="Hello Dinosaur from Rust">
<textarea vue-slot="code">
fn main() {
    println!("Hello Dinosaur from Rust");
}
</textarea>
</code-fence>
```

## Scala

<code-fence lang="scala" heading="Hello Dinosaur from Scala">
<textarea vue-slot="code">
object Main {
    def main(args: Array[String]) = {
        println("Hello Dinosaur from Scala")
    }
}
</textarea>
</code-fence>

```html
<code-fence lang="scala" heading="Hello Dinosaur from Scala">
<textarea vue-slot="code">
object Main {
    def main(args: Array[String]) = {
        println("Hello Dinosaur from Scala")
    }
}
</textarea>
</code-fence>
```

## Swift

<code-fence lang="swift" heading="Hello Dinosaur from Swift">
<textarea vue-slot="code">
print("Hello Dinosaur from Swift")
</textarea>
</code-fence>

```html
<code-fence lang="swift" heading="Hello Dinosaur from Swift">
<textarea vue-slot="code">
print("Hello Dinosaur from Swift")
</textarea>
</code-fence>
```

## TypeScript

<code-fence lang="ts" heading="Hello Dinosaur from TypeScript">
<textarea vue-slot="code">
console.log("Hello Dinosaur from TypeScript")
</textarea>
</code-fence>

```html
<code-fence lang="ts" heading="Hello Dinosaur from TypeScript">
<textarea vue-slot="code">
console.log("Hello Dinosaur from TypeScript")
</textarea>
</code-fence>
```

## D

<code-fence lang="d" heading="Hello Dinosaur from D">
<textarea vue-slot="code">
import std.stdio;

void main()
{
    writeln("Hello Dinosaur from D");
}
</textarea>
</code-fence>

```html
<code-fence lang="d" heading="Hello Dinosaur from D">
<textarea vue-slot="code">
import std.stdio;

void main()
{
    writeln("Hello Dinosaur from D");
}
</textarea>
</code-fence>
```

## Perl

<code-fence lang="perl" heading="Hello Dinosaur from Perl">
<textarea vue-slot="code">
print "Hello Dinosaur from Perl"
</textarea>
</code-fence>

```html
<code-fence lang="perl" heading="Hello Dinosaur from Perl">
<textarea vue-slot="code">
print "Hello Dinosaur from Perl"
</textarea>
</code-fence>
```

## Raku

<code-fence lang="raku" heading="Hello Dinosaur from Raku">
<textarea vue-slot="code">
say "Hello Dinosaur from Raku"
</textarea>
</code-fence>

```html
<code-fence lang="raku" heading="Hello Dinosaur from Raku">
<textarea vue-slot="code">
say "Hello Dinosaur from Raku"
</textarea>
</code-fence>
```

## Zig

<code-fence lang="zig" heading="Hello Dinosaur from Zig">
<textarea vue-slot="code">
const std = @import("std");

pub fn main() !void {
    const stdout = std.io.getStdOut().outStream();
    try stdout.print("Hello Dinosaur from Zig\n", .{});
}
</textarea>
</code-fence>

```html
<code-fence lang="zig" heading="Hello Dinosaur from Zig">
<textarea vue-slot="code">
const std = @import("std");

pub fn main() !void {
    const stdout = std.io.getStdOut().outStream();
    try stdout.print("Hello Dinosaur from Zig\n", .{});
}
</textarea>
</code-fence>
```

## Dart

<code-fence lang="dart" heading="Hello Dinosaur from Dart">
<textarea vue-slot="code">
void main() {
    print('Hello Dinosaur from Dart');
}
</textarea>
</code-fence>

```html
<code-fence lang="dart" heading="Hello Dinosaur from Dart">
<textarea vue-slot="code">
void main() {
    print('Hello Dinosaur from Dart');
}
</textarea>
</code-fence>
```

## Forth

<code-fence lang="forth" heading="Hello Dinosaur from Forth">
<textarea vue-slot="code">
.( Hello Dinosaur from Forth) CR
bye
</textarea>
</code-fence>

```html
<code-fence lang="forth" heading="Hello Dinosaur from Forth">
<textarea vue-slot="code">
.( Hello Dinosaur from Forth) CR
bye
</textarea>
</code-fence>
```

## Ada

<code-fence lang="ada" heading="Hello Dinosaur from Ada">
<textarea vue-slot="code">
with Text_IO; use Text_IO;
procedure main is
    begin Put_Line("Hello Dinosaur from Ada");
end main;
</textarea>
</code-fence>

```html
<code-fence lang="ada" heading="Hello Dinosaur from Ada">
<textarea vue-slot="code">
with Text_IO; use Text_IO;
procedure main is
    begin Put_Line("Hello Dinosaur from Ada");
end main;
</textarea>
</code-fence>
```
