module FSharpPlus.Tests.Lens

open System
open FSharpPlus
open FSharpPlus.Lens
open NUnit.Framework
open FsCheck
open Helpers
[<Test>]
let ok_prism() =
  areEqual (None) (preview _Ok (Error None))
  areEqual (Some 1) (preview _Ok (Ok 1))

[<Test>]
let error_prism() =
  areEqual (Some None) (preview _Error (Error None))
  areEqual (None) (preview _Error (Ok 1))

[<Test>]
let some_prism() =
  areEqual (None) (preview _Some None)
  areEqual (Some 1) (preview _Some (Some 1))

[<Test>]
let none_prism() =
  areEqual (Some None) (preview _None None)
  areEqual (None) (preview _None (Some 1))