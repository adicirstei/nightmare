module Kata.TennisProperties

open Kata.Tennis

open FsCheck
open FsCheck.Xunit
open Swensen.Unquote

[<Property>]
let ``Given advantaged player when advantaged player wins score is correct``
  (player : Player) =
  let actual : Score = scoreWhenAdvantage player player

  let expected = Game player

  actual =! expected
